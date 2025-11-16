<?php
$msg="If any query or suggestions you have you may post it";
    $connect = mysqli_connect("localhost", "root", "", "hues");
    if($connect)
    {
        $id = $_GET['dl'];
        $q = "SELECT * FROM hues where id='$id'";
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
    <title><?php echo $row['name']; ?></title>
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
            width:98.9vw;
            background-color: black;
            color:white;
            padding:5vh 15vw;
        }
        .abc{
            /* height:440vh; */
            height:auto;
            width:70vw;
            background-color:#2a2b2f;
            border-radius:30px;
            padding:2vh 2vw;
        }
        .a,.b,.c,.d,.e{
            height:auto;
            width:66vw;
        }
        .a{
            padding:2vh 2vw;
        }
        .b{
            background-color: black;
            padding:2vh 2vw;
            border-radius:10px;
            display:flex;
            justify-content:center;
        }
        .logo1{
            border-radius:20px;
            height:300px;
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
            width:62vw;
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
            height:7vh;
            width:25vw;
            border-radius:20px;
            cursor: pointer;
            color:white;
            border:none;
            background-color: black;
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
            height:auto;
            width:35vw;
            border:2px dotted black;
            font-weight:bold;
            border-radius:10px;
        }
        .f li input,textarea{
            margin-bottom:2vh;
            border-radius:10px;
            border:none;
            background-color: black;
            color:white;
        }
        .f li .input,textarea{
            padding-left:1vw;
        }
        textarea{
            height:20vh;
            padding:2vh;
            width:30vw;
        }
        .f li .input{
            height:5vh;
            width:30vw;
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
            background-color: white;
            color:black;
        }
        .f .pic img{
            height:57vh;
            width:30vw;
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
        <div class="header"><?php include("head.php"); ?></div>
        <div class="main">
            <div class="abc">
                <div class="a">
                    <h2 style="text-align:center; margin-bottom:1vh;"><?php echo "Download " . ucwords($row['name']) . "  (" . $row['years'] . ")  " . $row['category'] . "  Movies{" . ucwords($row['language']) . "}   [" .  $row['quality'] . "]"; ?></h2>
                    <p>
                        Hues.com is The Best Website/Platform For Bollywood And Hollywood HD Movies. We Provide Direct Google Drive Download Links For Fast And Secure Downloading. Just Click On Download Button And Follow Steps To Download And Watch Movies Online For Free.
                    </p>
                </div>
                <div class="b">
                    <div class="b1"><img src="<?php echo $row['logo'];?>" alt="alt.jpg" class="logo1"></div>
                    <div class="b2">
                        <p><h2><?php echo $row['name'];?></h2>
                        <?php echo $row['genre'];?><?php echo " (" . $row['years'] . ")";?></p>
                        <hr>
                        <p><?php echo $row['story'];?></p>
                        <hr>
                        <p><?php echo "<b>Director</b> : " . $row['Director'] . "<br><b>Actor</b> : " . $row['Actor1'] . ", " . $row['Actor2'];?></p>
                    </div>
                </div>
                <div class="c">
                    <p class="p1"><b><?php echo "Download " . ucwords($row['name']) . "  (" . $row['years'] . ")  " . $row['category'] . "  Movies{" . ucwords($row['language']) . "}   [" .  $row['quality'] . "]"; ?></b></p>
                    <p><b>Name</b> : <?php echo $row['name'];?></p>
                    <p><b>Language</b> : <?php echo $row['language'];?></p>
                    <p><b>Category</b> : <?php echo $row['category'];?></p>
                    <p><b>Quality</b> : <?php echo $row['quality'];?></p>
                </div>
                <div class="d">
                    <h2>Screenshorts</h2>
                    <img src="<?php echo $row['image1'];?>" alt="alt.jpg">
                    <img src="<?php echo $row['image2'];?>" alt="alt.jpg">
                    <img src="<?php echo $row['image3'];?>" alt="alt.jpg">
                </div>
                <div class="e"  align="center">
                <p class="p1" style="color:green;"><b><?php echo "Download " . ucwords($row['name']) . "  (" . $row['years'] . ")  " . $row['category'] . "  Movies{" . ucwords($row['language']) . "}   [" .  $row['quality'] . "]"; ?></b></p>
                    <a href="abc.html" style="margin:.5vh 2vw;"><div><h2>Download</h2></div></a>
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
                    <nav class="pic"><img src="alt.jpg" alt="alt"></nav>
                </div>
            </div>
        </div>
        <div class="footer"><?php include("foot.php"); ?></div>
    </div>
</body>
</html>