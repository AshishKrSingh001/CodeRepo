<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        $record_per_page = 4;
        $page = '';
        if(isset($_GET["page"]))
        {
            $page = $_GET["page"];
        }
        else
        {
            $page = 1;
        }

        $start_from = ($page-1)*$record_per_page;

        $query = "SELECT * FROM product where discount>0 LIMIT $start_from, $record_per_page";
        $result = mysqli_query($con, $query);
        //search
        if(isset($_POST["sub_search"]) && !empty($_POST['search']))
        {           
            $_SESSION['search'] = $_POST['search'];
            if($_SESSION)
            {
                header("location:search.php");
            }
        }
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="index.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>MyKart</title>
    <style>
        *{
            margin: 0;
            padding: 0;
        }
        body{
            overflow-y: scroll;
            overflow-x: hidden;
            scrollbar-width: none;  
            -ms-overflow-style: none;
            
        }
        /* body .header{
            position: sticky;
        } */
        .body{
            background-color:white;
            height:auto;
            width:100%;
            
        }
        .body .head{
            height:12vw;
            width:98vw;
            background-color: grey;
            padding:.2vw 4.2vw;
            border-radius: 2%;
            margin-left:1vw;
        }

        .body .head img{
            width: 9vw;
            height: 15vh;
            border-radius: 10%;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
        }
        .body .head li{
            float: left;
            margin:1vw;
        }
        .body .head li a p{
            text-align: center;
            font-size:1.2vw;
        }
        .body .ad{
            height:40vw;
            width:98vw;
            background-color: blue;
            margin: 1vw 0;
            border-radius: 2%;
            margin-left:1vw;
        }
        .body .ad #imgBanner{
            height:40vw;
            width:98vw;
            background-color: blue;
            border-radius: 1%;
        }
        .product{
            height:40vw;
            width:100vw;
            margin-bottom:4vh;
        }
        .msg{
            height:6vw;
            width:98vw;
            background: Black;
            padding: 1vw 2vw;
            margin-left:1vw;
        }
        .offer{
            height:4vw;
            width:98vw;
            padding: 1vw 2vw;
        }
        .msg p,.offer p{
            text-align: center;
            font-weight: bold;
            color: black;
        }
        .main{
            margin:2vh 0;
            height:71vh;
            background-color: rgb(28, 26, 26);
            color:white;   
        }
        .row{
            height:51vh;
            width:100vw;
            padding:5vh 5vw 5vh 5vw;
        }
        .card{
            float:left;
            width:17vw;
            height:45vh;
            margin :3.5vh 0 0 4vw;
            background-color:#36383F;
            border-radius:10px;
            box-shadow: 0px 10px 100px 25px #28283d;
        }
        img{
            width:100%;
            height:60%;
            border-radius:10px;
        }
        .card a img:hover{
            width: 16vw;
            height:25vh;
            margin:1vh;
        }
        .php{
            padding:8vh;
        }
        .a{
            margin:2vh 0;
            color:black;
            background-color: white;
            padding:1vh 1vw;
            border-radius:10px;
        }
        .a:hover{
            color:white;
            background-color:grey;
        }
        .card a{
            color:white;
        }
        .card a:hover{
            color:black;
        }
        .card_body{
            padding:2px;
        }
        .card a img:hover{
            width:16vw;
            height:29vh;
            margin:.5vh .5vw;
        }



    </style>
    <script type = "text/javascript">

        // Initialize images in an array
            var picPaths = ['image/ad_image01.jpg','image/ad_image02.jpg','image/ad_image03.jpg','image/ad_image04.jpg','image/ad_image05.jpg'];
            // An index to track the contender image 
            var imageIndex = 0;
            var bannerImage; 

            // An event callback for starting the interval
            function startInterval() {
            setInterval(displayNextImage, 3000);
            }

            function displayNextImage() {
            bannerImage.src = picPaths[imageIndex];
            if(imageIndex === (picPaths.length-1)) {
                imageIndex = 0;
            }
            else {
                imageIndex = imageIndex + 1; // It can be replaced with imageIndex ++  
            }
            }

            window.onload=function() {
            bannerImage = document.getElementById('imgBanner');
            startInterval();
            }
    </script>
</head>
<body>
    <div class="header" style="font-size:1.5vw;"><?php include("header.php") ?></div>
    <div class="body">
        <ul class="head">
            <li class="grocery"><a href="page.php?id=Grocery"><img src="image/grocery.jpg" alt="image/alt.jpg"><p>Grocery</p></a></li>
            <li class="mobiles"><a href="page.php?id=Mobile"><img src="image/mobile.jpg" alt="image/alt.jpg"><p>Mobiles</p></a></li>
            <li class="fashion"><a href="page.php?id=Fashion"><img src="image/fashion.jpg" alt="image/alt.jpg"><p>Fashion</p></a></li>
            <li class="elecrtic"><a href="page.php?id=Electronics"><img src="image/electronics.jpg" alt="image/alt.jpg"><p>Electronics</p></a></li>
            <li class="furniture"><a href="page.php?id=Furniture"><img src="image/furniiture.jpg" alt="image/alt.jpg"><p>Home & Furniture</p></a></li>
            <li class="Appliances"><a href="page.php?id=Appliance"><img src="image/electrical.jpg" alt="image/alt.jpg"><p>Appliances</p></a></li>
            <li class="toy"><a href="page.php?id=Beauty_Toy"><img src="image/toy.jpg" alt="image/alt.jpg"><p>Beauty, Toy <br>and More</p></a></li>
            <li class="twowheeler"><a href="page.php?id=TwoWheeler"><img src="image/twowheeler.jpg" alt="image/alt.jpg"><p>Two Wheeler</p></a></li>
        </ul>
        <div class="ad" onload = "changeImage()"><img id="imgBanner" src="image/ad_image05.jpg"></div>
        <div class="product">
            <div class = "msg"><p style="font-size: 1.5vw;color:white;">Product with offers <br>upto 50% off</p></div>
            <div class="main">
                <div class="row">
                    <?php while($row = mysqli_fetch_array($result)){?>
                    <div class="col">
                    <div class="card">
                    <a href="details.php?dl=<?php echo $row['productNo'];?>"><img src="<?php echo $row['productImage1']; ?>" alt="alt.jpg"></a>
                        <a href="details.php?dl=<?php echo $row['productNo'];?>"><div align="center" class="card_body">
                            <h4><?php echo "Buy Now<br>" . ucwords($row['productName']); ?></h4><h3 style="color:red;"><?php echo "&#8377;" . $row['price'];?></h3>
                        </div></a>
                    </div>
                    </div>
                    <?php
                    }?>
            </div>
            <div class="php" align="center">
                <?php
                    $page_query = "SELECT * FROM product where discount>0 LIMIT $start_from, $record_per_page";
                    $page_result = mysqli_query($con, $page_query);
                    $total_records = mysqli_num_rows($page_result);
                    $total_pages = ceil($total_records/$record_per_page);
                    $start_loop = $page;
                    $difference = $total_pages - $page;
                    if($difference <= 3)
                    {
                        $start_loop = $total_pages - 3;
                        if($start_loop<1)
                        {
                            $start_loop=1;
                        }
                    }
                    $end_loop = $start_loop + 2;
                    if($end_loop>$total_pages)
                    {
                        $end_loop = $start_loop + 1;
                        if($end_loop>$total_pages)
                        {
                            $end_loop = $start_loop;
                        }
                    }
                    if($page > 1)
                    {
                        echo "<a class='a' href='index.php?page=1'>First</a>";
                        echo "<a class='a' href='index.php?page=".($page - 1)."'>Previous</a>";
                    }
                    for($i=$start_loop; $i<=$end_loop; $i++)
                    {     
                        echo "<a class='a' href='index.php?page=".$i."'>".$i."</a>";
                    }
                    if($page < $end_loop)
                    {
                        echo "<a class='a' href='index.php?page=".($page + 1)."'>Next</a>";
                        echo "<a class='a' href='index.php?page=".$total_pages."'>Last</a>";
                    }
                ?>
            
            </div>
        </div>
    </div>
    <div class="footer"><?php include("footer.php") ?></div>
</body>
</html>