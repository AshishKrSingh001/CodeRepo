<?php 
    session_start();
    $msg ="";
    $con = mysqli_connect("localhost","root","","mykart");
    if($con)
    {
        $user = $_SESSION['c_user'];
        if($user == false)
        {
            header("location: login.php");
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
</head>
<body>
    <div class="header"><?php include("header.php") ?></div>
    <div class="body">
    </div>
    <div class="footer"><?php include("footer.php") ?></div>
</body>
</html>