<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="footer.css">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>footer</title>
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
        .containr{
            font-family: "Poppins", sans-serif;
            color: white;
            height: 15vw;
            width:100vw;
        }
        .footer .menu{
            background-color: #36383F;
            width: 100vw;
            height: 10vw;
            margin:2vh 0;
        }
        .foot{
            background-color: black;
            width: 100%;
            height: 5vw;
        }
        .foot{
            padding:2vw 0;
        }
        .footer .menu ul li a{
            text-decoration: none;
            color:grey;
        }
        li{
            list-style: none;
        }
        .footer .menu ul li{
            float: left;
            margin:3.5vw 3.2vw;
        }

    </style>
</head>
<body>
  <div class="containr">
        <footer class="footer">
            <div class="menu">
                <ul>
                    <li style="margin-left:25vw;"class="about"><a href="">About</a></li>
                    <li class="help"><a href="help">Help</a></li>
                    <li class="customer"><a href="customer">Customer-Policy</a></li>
                    <li class="mail"><a href="mail">Mail</a></li>
                    <li class="address"><a href="address">Address</a></li>
                </ul>
            </div>
            <div class="foot"><center><p>&copy; 2023 All Rights Reserved By MyKart</p></center></div>
        </footer>
  </div>
</body>
</html>