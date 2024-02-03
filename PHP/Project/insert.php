<html>
	<head>
		<title>
			Insert Page
		</title>
		<style>
			*{
				margin:0;
				padding:0;
			}
			.container{
				background-color:white;
				height:100vh;
				width:100vw;
			}
			.head{
				background-color:black;
				height:10%;
				width:100%;
				font-color:white;
			}
			.tail{
				background-color:black;
				height:10%;
				width:100%;
			}
			.main{
				background-color:grey;
				height:80vh;
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
			.a,.c{
				height:25%;
				width:100%;
			}
			.input{
				height:3.5vh;
				width:15vw;
			}
			.btn1
			{
				color:blue;
				background-color:green;
				height:4vh;
				width:6vw;
				border:none;
			}
			.btn2
			{
				color:blue;
				background-color:red;
				height:4vh;
				width:5vw;
				border:none;
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
				<div class="a"></div>
				<div class="b">
				<table height="50%" width="20%" cellspacing="0" align="center" style="margin-left:auto;margin-right:auto;">
					<form method="post">
						<tr align="center"><td colspan="2"><big><b>Student-Details</b></big></td></tr>
						<tr align="center">
							<td><b>Name:</b></td>
							<td><input class="input"type="text" name="name" placeholder="Ashish Kumar Singh"required></td>
						</tr>
						<tr align="center">
							<td><b>Id:</b></td>
							<td><input class="input"type="number" name="id" placeholder="13089"required></td>
						</tr>
						<tr align="center">
							<td><b>SEM-1:</b></td>
							<td><input class="input"type="number" name="s1" min="0" max="10"step="0.01" placeholder="SGPA"required></td>
						</tr>
						<tr align="center">
							<td><b>SEM-2:</b></td>
							<td><input class="input"type="number" name="s2" min="0" max="10"step="0.01" placeholder="SGPA"required></td>
						</tr>
						<tr align="center">
							<td><b>SEM-3:</b></td>
							<td><input class="input"type="number" name="s3" min="0" max="10"step="0.01" placeholder="SGPA"required></td>
						</tr>
						<tr align="center">
							<td><b>SEM-4:</b></td>
							<td><input class="input"type="number" name="s4" min="0" max="10"step="0.01" placeholder="SGPA"required></td>
						</tr>
						<tr align="center">
							<td><b>SEM-5:</b></td>
							<td><input class="input"type="number" name="s5" min="0" max="10"step="0.01" placeholder="SGPA"required></td>
						</tr>
						<tr align="center">
							<td><b>SEM-6:</b></td>
							<td><input class="input"type="number" name="s6" min="0" max="10"step="0.01" placeholder="SGPA"required></td>
						</tr>
						<tr>
							<td colspan="2" align="right"><input class="btn1"type="submit" name="submit" value="add">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input class="btn2"type="reset" name="reset" value="reset"></td>
						</tr>
					</form>
				</table>
				</div>
				<div class="c"><div class="ca"><b><center>
					<?php
						if(isset($_POST['submit']))
						{
							if(!empty($_POST['name']) && !empty($_POST['id']) && !empty($_POST['s1']) && !empty($_POST['s2']) && !empty($_POST['s3']) && !empty($_POST['s4']) && !empty($_POST['s5']) && !empty($_POST['s6']))
							{
								$name=$_POST['name'];
								$id=$_POST['id'];
								$s1=$_POST['s1'];
								$s2=$_POST['s2'];
								$s3=$_POST['s3'];
								$s4=$_POST['s4'];
								$s5=$_POST['s5'];
								$s6=$_POST['s6'];
								$cgpa=($s1+$s2+$s3+$s4+$s5+$s6)/6;
								$conn=mysqli_connect("localhost","root","","StudentDB");
								if($conn)
								{
									$query = "insert into Student(name,id,s1,s2,s3,s4,s5,s6,cgpa) VALUES('$name','$id','$s1','$s2','$s3','$s4','$s5','$s6','$cgpa');";
									$rs=mysqli_query($conn,$query);
									if($rs)
									{
										echo "Record is inserted<br>";
									}
									else
									{
										$q1 = "select * from Student where id='$id'";
										$rs1 = mysqli_query($conn,$q1);
										$row1 = mysqli_num_rows($rs1);
										if($row1==1)
										{
											echo "Record already exsists";
										}
										else
										{
											echo "Something went wrong!";
										}
									}
								}
								else
								{
									echo "MYSQL not connected<br>";
								}
							}
						}
					?>
				</center></b></div></div>
			</div>
			<div class="tail">
				<center><p><font color="white">Content on this website is owned, by the Ashish Kumar singh</p>
				<p>Site is technically designed, hosted and maintained by Myself</p>
				<p>Powered By — Myself</font></p></center>
			</div>
		</div>
	</body>
</html>