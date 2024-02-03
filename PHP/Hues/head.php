<?php

if (session_status() == PHP_SESSION_NONE) {
    session_start();
}

    $connect = mysqli_connect("localhost", "root", "", "hues");
    if($connect)
    {
        if(isset($_POST["sub"]) && !empty($_POST['search']))
        {
            $_SESSION['search'] = $_POST['search'];
            if($_SESSION)
            {
                header("location: search.php");
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
    <link rel="stylesheet" href="head_style.css">
    <title>header</title>
</head>
<body>

    <div class="container">
        <header class="header">
                <!-- Logo -->
                <a href="main.php" class="logo">HUES</a>        
                <!-- Hamburger icon -->
                <input class="side-menu" type="checkbox" id="side-menu"/>
                <label class="hamb" for="side-menu"><span class="hamb-line"></span></label>
                <!-- Menu -->
                <nav class="nav">
                    <ul class="menu">
                    <li><a href="holly.php">Hollywood</a></li>
                    <li><a href="bolly.php">Bollywood</a></li>
                    <li><a href="south.php">SouthIndian</a></li>
                    <li><a href="korean.php">Korean</a></li>
                    <li><a href="other.php">Other</a></li>
                    </ul>
                </nav>
        </header>
        <div style="margin-bottom:20px;">
            <form action="" method="POST">
                <nav class="nav">
                    <ul class="menu">
                        <li><input class="search" type="text" name="search" placeholder="SEARCH" ></li>
                        <li><button style="background-color:transparent;" class="img_search" type="submit" name="sub"><img src="image/search-icon.png" alt="alt.jpg"></button></li>
                    </ul>
                </nav>
            </form>
        </div>
    </div> 
</body>
</html>