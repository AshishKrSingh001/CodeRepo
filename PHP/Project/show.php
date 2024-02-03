<?php
	$con = mysqli_connect("localhost","root","","StudentDB");
	if($con)
	{
		$query = "SELECT * from Student";
		$rs = mysqli_query($con,$query);
	}
	else
	{
		echo "Database error :" . mysqli_connect_error() . "<br>";
	}
?>
<html>
	<head>
		<title>
			Display Page
		</title>
		<style>
			*{
				margin:0;
				padding:0;
			}
			.container{
				background-color:white;
				height:auto;
				width:100vw;
			}
			.head{
				background-color:black;
				height:10vh;
				width:100vw;
				font-color:white;
			}
			.tail{
				background-color:black;
				height:10vh;
				width:100vw;
			}
			.main{
				background-color:grey;
				height:80%;
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
			td a{
				display:block;
				text-align:center;
				text-decoration:none;
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
			.btn2
			{
				color:red;
				background-color:transparent;
			}
			.btn1
			{
				color:green;
				background-color:transparent;
			}
			.btn1,.btn2
			{
				
				height:4vh;
				width:5vw;
				border:none;
				cursor:pointer;
				font-weight:bold;
				font-style:italic;
				font-size:2vh;
			}
			.table
			{
				margin-left:auto;
				margin-right:auto;
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
				<table class="table" height="auto" border="2px" cellspacing="0">
					<tr><td colspan="12" align="center"><b><i><big>Student-Details</big></i></b></td></tr>
					<tr align="center">
						<th width="100px"><b>sr-no</b></th>
						<th width="200px"><b>NAME</b></th>
						<th width="100px"><b>ID</b></th>
						<th width="100px"><b>SEM-1</b></th>
						<th width="100px"><b>SEM-2</b></th>
						<th width="100px"><b>SEM-3</b></th>
						<th width="100px"><b>SEM-4</b></th>
						<th width="100px"><b>SEM-5</b></th>
						<th width="100px"><b>SEM-6</b></th>
						<th width="100px"><b>CGPA</b></th>
						<th width="100px"><b>Edit</b></th>
						<th width="100px"><b>Delete</b></th>
					</tr>
					<?php
						for($i=1;$row = mysqli_fetch_array($rs);$i++)
						{
					?>
						<tr align="center">
							<td width="50px"><?php echo $i;?></td>
							<td width="150px"><?php echo $row['name'];?></td>
							<td width="50px"><?php echo $row['id'];?></td>
							<td width="50px"><?php echo $row['s1'];?></td>
							<td width="50px"><?php echo $row['s2'];?></td>
							<td width="50px"><?php echo $row['s3'];?></td>
							<td width="50px"><?php echo $row['s4'];?></td>
							<td width="50px"><?php echo $row['s5'];?></td>
							<td width="50px"><?php echo $row['s6'];?></td>
							<td width="50px"><?php echo $row['CGPA'];?></td>
							<td width="50px"><a href="update.php?id=<?php echo $row['id'];?>& name=<?php echo $row['name'];?>& s1=<?php echo $row['s1'];?>& s2=<?php echo $row['s2'];?>& s3=<?php echo $row['s3'];?>& s4=<?php echo $row['s4'];?>& s5=<?php echo $row['s5'];?>& s6=<?php echo $row['s6'];?>"><b><font color="green">Edit</b></font></a></td>
							<td width="50px"><a href="delete.php?dl=<?php echo $row['id'];?>"><b><font color="voilet">Delete</b></font></a></td>
							</tr>
					<?php
						}
					?>
				</table>
			</div>
			<div class="tail">
				<center><p><font color="white">Content on this website is owned, by the  Ashish Kumar singh</p>
				<p>Site is technically designed, hosted and maintained by Myself</p>
				<p>Powered By — Myself</font></p></center>
			</div>
		</div>
	</body>
</html>