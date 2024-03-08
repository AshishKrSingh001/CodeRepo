<?php
    session_start();
    $msg="If any query or suggestions you have you may post it";
    $connect = mysqli_connect("localhost", "root", "", "mykart");
    if($connect)
    {
        $user = $_SESSION['c_user'];
        if($user == false)
        {
            header("location: login.php");
        }
        $id = $_GET['dl'];
        $q = "SELECT productNo,productName,companyName,quan,category,productImage1,productImage2,productDescription,seller.sellerNo,price,manufacturer,discount,delivery,warranty,inc_com,specialFeature,sellerFName,sellerMName,sellerLName,email,saddress,sDateOfBirth,MobileNo FROM product,seller where productNo='$id' and product.sellerNo = seller.sellerNo";
        $rs = mysqli_query($connect,$q);
        $row  = mysqli_fetch_array($rs);
		
        if(isset($_POST['sub']))
        {
            header("location: error.html");
        }
        if(isset($_POST['post']) && !empty($_POST['name']) && !empty($_POST['email']) && !empty($_POST['comment']))
        {
            $name = $_POST['name'];
            $email = $_POST['email'];
            $comment = $_POST['comment'];
            $q = "INSERT INTO comment(name,email,comment) values('$name','$email','$comment')";
            $rs = mysqli_query($connect,$q);
            if($rs)
            {
                $msg="Thanks for posting your comment";
            }
        }
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>MyKart</title>
    <style>
        *{
            margin:0;
            padding:0;
            /*#2a2b2f 
            #36383F*/
        }
        .main{
            /* height:450vh; */
            height:auto;
            width:99vw;
            background-color: #2a2b2f;
            color:white;
            padding:5vh 5vw;
        }
        .abc{
            /* height:440vh; */
            height:auto;
            width:89vw;
            background-color:black;
            border-radius:30px;
            padding:2vh 2vw;
        }
        .a,.b,.c,.d,.e{
            height:auto;
            width:85vw;
        }
        .a{
            padding:2vh 2vw;
        }
        .b{
            background-color: #2a2b2f;
            padding:2vh 2vw;
            border-radius:10px;
            display:flex;
            justify-content:center;
        }
        .logo1{
            border-radius:20px;
            height:330px;
            width:220px;
        }
        .b1{
            margin:0 2vw 0 0;
        }
        .b2 p{
            margin-bottom:3vh;
        }
        .c{
            padding:2vh;
        }
        .c .p1{
            color:green;
            text-align:center;
        }
        .d{
            padding:2vh;
        }
        .d img{
            width:83vw;
            border-radius:20px;
            margin-top:2vh;
        }
        .d h2{
            text-align:center;
        }
        hr{
            margin:2vh 0;
        }
        .e a div{
            height:9vh;
            width:25vw;
            border-radius:20px;
            cursor: pointer;
            color:white;
            border:none;
            background-color: blue;
            padding:1vh;
        }
        .e .msg{
            font-weight:bold;
            margin:3vh 3vw;
            background-color: pink;
            color:black;
            border-radius:10px;
        }
       
        .f ul{
            padding:2vh 2vw;
            margin:2vh 2vw;
            height:57vh;
            width:45vw;
            border:2px dotted white;
            font-weight:bold;
            border-radius:10px;
        }
        .f li input,textarea{
            margin-bottom:1vh;
            border-radius:10px;
            border:none;
            background-color: white;
            color:black;
        }
        .f li .input,textarea{
            padding-left:1vw;
        }
        textarea{
            height:20vh;
            padding:2vh;
            width:40vw;
        }
        .f li .input{
            height:5vh;
            width:40vw;
        }
        .f li .btn{
            cursor:pointer;
            margin:1vh 1vw;
            height:4vh;
            width:6vw;
            font-weight:bold;
            background-color: green;
            color:white;
        }
        .btn:hover,.input:hover,textarea:hover{
            background-color: grey;
        }
        .f .pic img{
            margin:2vh 0 ;
            height:57vh;
            width:35vw;
            border-radius:10px;
        }
        .f .com{
            float:left;
        }
        .f .pic{
            float:none;
        }
        .f nav{
            margin:.5vh;
        }
    </style>
</head>
<body>
    <dic class="container">
        <div class="header"><?php include("header.php"); ?></div>
        <div class="main">
            <div class="abc">
                <div class="a">
                    <h2 style="text-align:center; margin-bottom:1vh;color:blue;"><?php echo "Buy " . ucwords($row['productName']) . "  (" . $row['companyName'] . ")  " . $row['category']; ?></h2>
                </div>
                <div class="b">
                    <div class="b1"><img src="<?php echo $row['productImage1'];?>" alt="Image/alt.jpg" class="logo1"></div>
                    <div class="b2">
                    <p><b>Price: </b><?php 
                        $p = $row['price'] + (($row['price'] * $row['discount'])/100);
                        echo "<b style='color:red;'>-" . $row['discount'] . "%&nbsp;off</b>" . "&nbsp;&nbsp;<i style='text-decoration:line-through'>&#8377;" . $p . "</i>&nbsp;&nbsp;<b style='color:red;'>&#8377;" . $row['price'] . "</b>";?></p>
                        <hr>
                        <p><?php echo $row['productDescription'];?></p>
                        <hr>
                        <p style='color:yellow;'><i>Only&nbsp;<?php echo $row['quan'];?>&nbsp;item left</i></p>
                    </div>
                </div>
                <div class="c">
                    <p><b>Name</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['productName'];?></p>
                    <p><b>Company Name</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['companyName'];?></p>
                    <p><b>Category</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['category'];?></p>
                    <p><b>Brand</b>&nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['manufacturer'];?></p>
                    <p><b>Delivery Charges</b> &nbsp;&nbsp;:&nbsp;&nbsp; 
                    <?php if($row['delivery'] ==0){echo "<b style='text-decoration:line-through;color:green;'>&#8377;40</b> Free";}else{echo "<b style='color:green;'>&#8377;" . $row['delivery'] . "</b>";};?></p>
                    <p><b>Discount</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo "<b style='color:red;'>-" . $row['discount'] . "%&nbsp;off</b>";?></p>
                    <p><b>Feature</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['specialFeature'];?></p>
                    <p><b>Included Component</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['inc_com'];?></p>
                    <hr>
                    <h3 style="text-align:center;">Seller Contact Details</h3>
                    <p><b>Name</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['sellerFName'] . " " . $row['sellerMName'] . " " . $row['sellerLName'];?></p>
                    <p>&#128231; &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['email'];?></p>
                    <p>&#9742; &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['MobileNo'];?></p>
                    <p><b>Address</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['saddress'];?></p>
                    <hr>
                    <p><b>Warranty</b> &nbsp;&nbsp;:&nbsp;&nbsp; <?php echo $row['warranty'];?></p>
                </div>
                <div class="d">
                    <h2>Images</h2>
                    <img src="<?php echo $row['productImage1'];?>" alt="Image/alt.jpg">
                    <img src="<?php echo $row['productImage2'];?>" alt="Image/alt.jpg">
                </div>
                <div class="e"  align="center">
                    <a href="abc.html" style="margin:1vh 2vw;"><div><h2>Buy Now</h2></div></a>
                    <p class="msg"><?php echo $msg;?></p>
                </div>
                <div class="f">
                    <nav class="com">
                        <form action="" method="POST">
                            <ul>
                                <li>&nbsp;&nbsp;Comment: </li>
                                <li><textarea name="comment"required></textarea></li>
                                <li>&nbsp;&nbsp;Name: </li>
                                <li><input class="input" type="text" name="name" required></li>
                                <li>&nbsp;&nbsp;Email: </li>
                                <li><input class="input" type="email" name="email" required></li>
                                <li align="right"><input class="btn" type="submit" name="post" value="Post"></li>
                            </ul>
                        </form>
                    </nav>
                    <nav class="pic"><img src="Image/ad_image01.jpg" alt="Image/alt.jpg"></nav>
                </div>
            </div>
        </div>
        <div class="footer"><?php include("footer.php"); ?></div>
    </div>
</body>
</html>