<html>
	<head>
		<title>
			Home Page
		</title>
		<style>
			*{
				margin:0;
				padding:0;
			}
			.container{
				background-color:white;
				height:700vh;
				width:100vw;
			}
			.head{
				background-color:black;
				height:10vh;
				width:100vw;
				font-color:white;
				position:fixed;
			}
			.tail{
				background-color:black;
				height:10vh;
				width:100vw;
			}
			.main{
				background-color:grey;
				height:auto;
				width:100vw;
			}
			li{
				list-style:none;
				float:right;
			}
			li a{
				display:block;
				color:white;
				text-align:center;
				padding:3.5vh 2vw;
				text-decoration:none;
			}
			td{
				height:50%;
				width:25%;
			}
			.img1{
				background-image:url("img1.jpg");
				background-repeat:no-repeat;
				background-size:cover;
			}
			.img2{
				background-image:url("img2.jpg");
				background-repeat:no-repeat;
				background-size:cover;
			}
			h1{
				text-align:center;
				background-color:pink;
				
			}
			p{
				font-weight:bold;
				padding:2vh 0 5vh 0;
			}
		</style>
	</head>
	<body>
		<div class="container">
			<div class="head">
			<ul>
				<li><a href="home1.php">HOME</a></li>
				<li><a href="insert.php">INSERT</a></li>
				<li><a href="show.php">SHOW</a></li>
				<li><a href="code.php">CODE</a></li>
				<li><a href="home.php">LOGOUT</a></li>
			</ul>
			</div>
			<div class="main">
				<div class="home1"><h1 style="padding:10vh 0 1vh 0;">Home page</h1><p><?php show_source("home1.php")?></p></div><hr>
				<div class="show"><h1>Show page</h1><p><pre><?php show_source("show.php")?></p></div><hr>
				<div class="insert"><h1>Insert page</h1><p><pre><?php show_source("insert.php")?></p></div><hr>
				
				<div class="update"><h1>Update page</h1><p><?php show_source("update.php")?></p></div><hr>
				<div class="delete"><h1>Delete page</h1><p><?php show_source("delete.php")?></p></div><hr>
				<div class="home"><h1>Signin page</h1><p><?php show_source("home.php")?></p></div><hr>
				<div class="signup"><h1>Signup page</h1><p><?php show_source("signup.php")?></p></div><hr>
				
			</div>
			<div class="tail">
				<center><p><font color="white">Content on this website is owned, by the  Ashish Kumar singh</p>
				<p>Site is technically designed, hosted and maintained by Myself</p>
				<p>Powered By — Myself</font></p></center>
			</div>
		</div>
	</body>
</html>