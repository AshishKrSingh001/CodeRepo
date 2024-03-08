<?php
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        if(isset($_POST["sub_search"]) && !empty($_POST['search']))
        {           
            $_SESSION['search'] = $_POST['search'];
            if($_SESSION)
            {
                header("location:search.php");
            }
        }
    }
?><!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="header.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>header</title>
    <style>
        @import url("https://fonts.googleapis.com/css2?family=Poppins:wght@400;700&display=swap");
        *{
            margin: 0;
            padding: 0;
            box-sizing: border-box;

        }
        body{
            overflow-x: hidden;
            overflow-y: scroll; 
            scrollbar-width: none;  
            -ms-overflow-style: none;
            font-size: 1.5vw;
        }
        .container{
            font-family: "Poppins", sans-serif;
            background-color: black;
            height: 10vw;
            width:100%;
            margin-bottom:2vh;
            
        }
        .header{
            position: sticky;
        }
        .logo{
            float: left;
            font-style: italic;
            margin-left: 0.5vw 1vw;
            margin: 2vw 2.5vw;
        }
        .x{
            float:none;
        }
        .menu li{
            float:right;
            margin: 3vw 3vw;
            
        }
        .menu .search{
            float:none;
        }
        .search{
            height:3vw;
            width: 25vw;
            border-top-left-radius: 1vw;
            border-bottom-left-radius: 1vw;
            padding: 1vw;
            border: none;

        }
        .img_search img{
            height: 2.6vw;
            width: 2vw;
            cursor: pointer;
            border-radius: 40%;
            border: none;
        }
        .cartlogo,.loginlogo{
            border-radius: 45%;
            height: 2vw;
            float: left;
            width: 2vw;
        }
        a{
            text-decoration: none;
            color: white;
        }
        ul{
            list-style: none;
        }
        li .input1{
            color:white;
            background-color:transparent;
            border:none;
            font-size:1.4vw;
            cursor: pointer;
        }
    
    </style>
</head>
<body>
    <div class="container">
        <header class="header">
                <!-- Logo -->
                <a href="index.php" class="logo"><p><img style="height:13vh; width:13vw;"src="Image/logo.jpg" alt="Image.alr.jpg"></p></a>
                <div class="x"></div>       
                <form action="" method="POST">
                    <ul class="menu">
                        <li><a href="seller.php"><p class="seller">Become a Seller</p></a></li>
                        <li style="margin-left:5px;"><a href="cart.php"><img src="image/cart.png" alt="alt.jpg" class="cartlogo"></a></li>
                        <li style="margin-right:0px;"><a href="cart.php"><p class="cart">Cart</p></a></li>
                        <li style="margin-left:5px;"><img src="image/login.png" alt="alt.jpg" class="loginlogo"></li>
                        <li style="margin-right:0px"><a href="login.php"><p class="login">Login</p></a></li>
                        <li  style="margin-left:0px;"><button style="background-color:transparent;" class="img_search" type="submit" name="sub_search"><img src="image/search-icon.png" alt="alt.jpg"></button></li>
                        <li  style="margin-right:0px;"><input class="search" type="text" name="search" placeholder="SEARCH" ></li>
                    </ul>
                </form>
        </header>
    </div> 
</body>
</html>