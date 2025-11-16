<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        if(isset($_POST['submit']))
        {
            if(!empty($_POST['mob']) && !empty($_POST['password']))
            {
                $mob = trim($_POST['mob']);
                $pass = trim($_POST['password']);

                $query = "SELECT * from seller where MobileNo='$mob'and password='$pass' ";
                $rs = mysqli_query($con,$query);
                $row = mysqli_num_rows($rs);
                if($row)
                {
                    $user="";
                    foreach ($con->query($query) as $r) 
                    {
                        $user = $r['sellerNo'];
                    }
                    $_SESSION['s_user'] = $user;
                    header("location: seller.php");
                } 
                else
                {
                    $msg = "Invalid Username or Password";
                }
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
            margin:1vw 2vw;
            height:30vw;
            width:96vw; 
        }
        .body .main{
            margin:0 22vw;
            border-radius:5%;
            border-top-left-radius:10%;
            border-bottom-left-radius:10%;
            height:28vw;
            width:50vw;
            background-color:grey;
            box-shadow: rgba(50, 50, 93, 0.25) 0px 30px 60px -12px inset, rgba(0, 0, 0, 0.3) 0px 18px 36px -18px inset;
        }
        .body .main .left{
            border-top-left-radius:10%;
            border-bottom-left-radius:10%;
            width:40%;
            height:100%;
            background-color:blue;
            padding: 5vw 2vw;
            float: left;
        }
        .left{
            color: white;
        }

        .left p{
            text-align: center;
        }
        .left .down img{
            height: 10vw;
            width: 16vw;
            border-radius: 10%;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
        }
        .body .main .right{
            width:60%;
            height:100%;
            /* background-color:white; */
            padding: 5vh 2vw;
            float: left;
        }

        .username, .password{
            border: none;
            width: 25vw;
            height:2.5vw;
            border-radius: 2%;
            padding:0 1vw;
            margin: .5vw 0;
        }
        ul li.sub input,.register{
            border: none;
            width: 25vw;
            height:3vw;
            border-radius: 2%;
            padding:0 1vw;
            margin: .5vw 0;
            background-color: blue;
            color: white;
            box-shadow: 0px -25px 20px -20px rgba(0, 0, 0, 0.45), 25px 0 20px -20px rgba(0, 0, 0, 0.45), 0px 25px 20px -20px rgba(0, 0, 0, 0.45), -25px 0 20px -20px rgba(0, 0, 0, 0.45);
        }
        .right .register a p{
            text-align: center;
            color: rgb(2, 35, 59);
        }
        .register{
            background-color: grey;
            padding-top:.8vw;
        }
        .register a{
            color: blue;
            text-align:center;
        }
    </style>
    <script>
        function show() 
        {
            var x = document.getElementById("myInput");
            if (x.type === "password") {
                x.type = "text";
            } else {
                x.type = "password";
            }
        }
    </script>
</head>
<body>
<div class="header"><?php include("header.php") ?></div>
<div class="body">
    <div class="msg" style="margin:.5vw;height:1vw;font-weight:bold;"><p style="color:red; text-align:center;"><?php echo $msg; ?></p></div>
    <div class="main">
        <div class="left">
            <div class="up">
                <h4 style="text-align:center;">SELLER-LOGIN-PAGE</h4><hr style="margin-top:.5vw;">
                <h5 style="margin-top:1vw;color:grey;text-align:center">Welcome to MyKart</h5>
                <p style="font-size:2vh; margin-top:1vh;color:grey;"> "Most people spend more time and energy going around problems than in trying to solve them."</p>
                <hr style="margin:1vw;">
            </div>
            <div class="down">
                <img src="image/logo.png" alt="image/alt.jpg">
            </div>
        </div>
        <div class="right">
            <form action="" class="form" method="POST">
                <ul>
                    <li><input class="username" type="text" name="mob" placeholder="Enter Mobile number"></li>
                    <li><input class="password" id="myInput"type="password" name="password" placeholder="Enter Password"></li>
                    <li style="margin-left:15vw;"><input class="checkbox" type="checkbox" onclick="show()" name="checkbox">&nbsp;<b style="font-size:1vw;">Show Password</b>&nbsp;&nbsp;&nbsp;&nbsp;</li>
                    <li style="margin:2vh 0;"><p style="font-size:.9vw; text-align:center;">By continuing, you agree to Flipkart's <a style="color:maroon;" href="">Terms of Use</a> and <a style="color:maroon;" href="">Privacy Policy</a>.</p></li>
                    <li class="sub">
                        <input style="cursor:pointer;" type="submit" name="submit" value="Submit"></li>
                </ul>
            </form>
            <div class="register" style="margin-top: 6vw;"><a href="registerSellerMob.php"><p style="font-size:1.3vw;">New to MyKart? Create an account</p></a></div>
        </div>
    </div>
</div>
<div class="footer"><?php include("footer.php") ?></div>
</body>
</html>