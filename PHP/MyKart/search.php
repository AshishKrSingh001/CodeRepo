<?php
    $connect = mysqli_connect("localhost", "root", "", "mykart");
    session_start();
    $search = $_SESSION['search'];
    if($connect)
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

        $query1 = "SELECT * FROM product WHERE productName LIKE '%$search%' order by productName DESC LIMIT $start_from, $record_per_page";
        $result1 = mysqli_query($connect, $query1);   
        if($result1)
        {
            $noDataFound = "";
            $q = "SELECT COUNT(*) as count FROM product WHERE productName LIKE '%$search%' order by productName";
            $r = mysqli_query($connect, $q);   
            $row = $r->fetch_assoc();

            if ($row['count'] >= 1) {
                $noDataFound = "<b style='color:green;'>" .ucwords($search) . "</b>";
            }
            else{
                $noDataFound = "<b style='color:red;'>" .ucwords($search) . " not found!</b>";
            }
        }
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" type="image/iconMykart.jpg" href="image/faviconMyKart.ico">
    <title>MyKart</title>
    <style>
        *{
            margin:0;
            padding:0;
        }
        .main{
            height:71vh;
            width:100vw;
            background-color: black;
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
            margin:2vh 0 0 2vw;
            color:black;
            background-color: white;
            padding:1vh 1vw;
            border-radius:10px;
        }
        .a:hover{
            color:white;
            background-color:#36383F;
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
    </style>
</head>
<body>
    <div class="header"><?php include("header.php"); ?></div>
    <div class="main">
            <div class="row">
            <h2 align="center"><?php echo $noDataFound; ?></h2>
                <?php while($row = mysqli_fetch_array($result1)){?>
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
                $page_query1 = "SELECT * FROM product WHERE productName LIKE '%$search%' order by productName DESC LIMIT $start_from, $record_per_page";
                $page_result1 = mysqli_query($connect, $page_query1);
                $total_records = mysqli_num_rows($page_result1);
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
    <div class="footer"><?php include("footer.php"); ?></div>
</body>
</html>

