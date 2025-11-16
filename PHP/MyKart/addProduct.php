<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        $user = $_SESSION['s_user'];
        if($user == false)
        {
            header("location: sellerLogin.php");
        }
        if(isset($_POST['submit']))
        {
            if(!empty($_POST["category"]) && !empty($_POST["pname"]) && !empty($_POST["cname"]) && !empty($_POST["quan"]) && !empty($_POST["pd"]))
            {
                $pname = trim($_POST["pname"]);
                $cname = trim($_POST["cname"]);
                $quan = $_POST['quan'];
                $category = $_POST['category'];
                $pd = $_POST['pd'];
                $sno = $user;

            }
            else
            {
                $msg =  ("Error description(Not all field filled): " . mysqli_error($con));
            } 
        }
    }
    else
    {
        $msg =  ("Error description(connection): " . mysqli_error($con));
    } 
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="register.css">
    <link rel="icon" type="image/iconMykart.jpg" href="image/faviconMyKart.ico">
    <title>MyKart</title>
    <STYLE>
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
        .body{
            padding:1vh 2vw;
            height:95vh;
            width:96vw; 
        }
        .body .head{
            background-color:grey;
            padding:2vh 0;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
            border-radius:2%;
            float:right;
            width:20vw;
            margin:1vh 0;
        }
        .head a .link p{
            text-align:center;
            color:blue;
        }
        .main{
            margin:10vh 7vw;
            border-radius:5%;
            border-top-left-radius:10%;
            border-bottom-left-radius:10%;
            height:80vh;
            width:80vw;
            background-color:grey;
            box-shadow: rgba(50, 50, 93, 0.25) 0px 30px 60px -12px inset, rgba(0, 0, 0, 0.3) 0px 18px 36px -18px inset;
        }
        .body .main .left{
            border-top-left-radius:10%;
            border-bottom-left-radius:10%;
            width:20vw;
            height:80vh;
            background-color:blue;
            padding: 10vh 2vw;
            float: left;
        }
        .left{
            color: white;
        }

        .left p{
            text-align: center;
        }
        .left .down img{
            height: 20vh;
            width: 16vw;
            border-radius: 10%;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
        }
        .body .main .right{
            width:60vw;
            height:80vh;
            /* background-color:white; */
            padding: 0 2vw;
            float: left;
            margin:5vh 0;
        }

        .input{
            border: none;
            width: 25vw;
            height:5vh;
            border-radius: 2%;
            padding:0 1vw;
            margin: 1vh 0;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
        }
        ul li.sub input,.transfer input{
            border: none;
            width: 25vw;
            height:6vh;
            border-radius: 2%;
            padding:0 1vw;
            margin: 1vh 0;
            background-color: blue;
            color: white;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
        }
        .right .login a p{
            text-align: center;
            color: rgb(2, 35, 59);
        }
        .transfer input{
            color: blue;
            Background-color:grey;
            text-align:center;
        }

        .upleft,.upright{
            display: flex;
            justify-content: center;
            height: 50%;
            width:50%;  
        }
        .text{
            border-radius: 2%;
            width: 25vw;
            border: none;
            padding:1vh 1vw;
            margin: 1vh 0;
            color: black;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
        }
        .upleft{
            float:left;
        }
        .adimage{
            border-radius: 2%;
            width:25vw;
            height:57vh;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
        }
    </STYLE>
</head>
<body>
<div class="header"><?php include("header.php") ?></div>
<div class="body">
    <div class="msg" style="margin:1vh 0;height:2vh;font-weight:bold;"><p style="color:red; text-align:center;"><?php echo $msg; ?></p></div>
    <div class="head"><a href="seller.php"><div class="link"><p>Show available Products</p></div></a></div>
    <div class="main">
        <div class="left">
            <div class="up">
                <h3 style="text-align:center;">PRODUCT ENTRY</h3><hr style="margin-top:1vh;">
                <h3 style="margin-top:2vh;color:grey;text-align:center;">Welcome to MyKart</h3>
                <p style="font-size:2vh; margin-top:1vh;color:grey;"> "Most people spend more time and energy going around problems than in trying to solve them."</p><hr style="margin:2vh 0 2vh 0;">
            </div>
            <div class="down" style="margin: 2vh 0 2vh 0;">
                <img style="margin:2vh 0;"src="image/logo.jpg" alt="image/alt.jpg">
                <img src="image/logo.png" alt="image/alt.jpg">
            </div>
        </div>
        <div class="right">
            <form action="" class="form" method="POST" enctype="multipart/form-data">
                <div class="upleft">
                    <ul>
                        <li><input class="input" type="text" name="pname" placeholder="Product Name" value=""></li>
                        <li><input class="input" type="text" name="cname" placeholder="Company Name"></li>
                        <li><input class="input" type="Number" name="quan" placeholder="Quantity"></li>
                        <li style="margin-top:2vh;"><label class="label" for="HTML">Product Description:</label></li>
                        <li><textarea class="text" name="pd" cols="50" rows="5"></textarea></li>                
                    </ul>
                </div>
                <div class="upright">
                    <ul>
                        <li><img class="adimage"src="Image/ad_image01.jpg" alt="Image/alt.jpg"></li>
                        <li class="sub"><input style="cursor:pointer;" type="submit" name="submit" value="Submit"></li>
                        <li class="transfer"><input style="cursor:pointer;" type="reset" name="reset" value="Reset"></li>
                    </ul>
                </div>
            </form>
        </div>
    </div>
</div>
<div class="footer"><?php include("footer.php") ?></div>
</body>
</html>