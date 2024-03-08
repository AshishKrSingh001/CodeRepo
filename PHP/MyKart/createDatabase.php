<?php
    $msg="";
    $connect = mysqli_connect("localhost", "root", "");
    if($connect)
    {
        //Database Query
        $query = "CREATE DATABASE myKart";
        $rs = mysqli_query($connect,$query);
        if($rs)
        {
            $msg = "Database is created";
        }
        else
        {
            $msg = "Database Not created";
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
    </style>
</head>
<body>
    <div class="main" style="margin-top:5vh;"><h1 style="text-align:center;"><?php echo $msg; ?></h1></div>
</body>
</html>

