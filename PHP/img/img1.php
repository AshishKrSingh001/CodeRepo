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
				height:100vh;
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
				height:80vh;
				width:100vw;
			}
			.table{
				margin-left:auto;
				margin-right:auto;
			}
			.a,.c{
				height:30vh;
			}
			.btn{
				background-color:green;
				color:white;
				border:none;
			}
		</style>
	</head>
	<body>
		<div class="container">
			<div class="head">
			</div>
			<div class="main">
			<div class="a"></div>
			<div class="b">
				<form method="post" enctype="multipart/form-data">
				<table style="margin-left:auto; margin-right:auto;">
				<tr>
					<td>Upload&nbsp;image:</td>
					<td><input type="file" name="file" id="file"></td>
				</tr>
				<tr>
					<td><input type="submit" name="sub" value="Submit"></td>
				</tr>
				</table>
				</form>
			</div>
			<div class="c">
				<?php
					if(isset($_POST["sub"])) 
					{
						// The target directory of uploading is uploads
						$target_dir = "profile/";
						$target_file = $target_dir . basename($_FILES["file"]["name"]);
						
						// Check if file already exists
						if (file_exists($target_file)) 
						{
							echo "file already exists.<br>";
							echo "Your file was not uploaded.<br>";
						}
						
						else 
						{
							// $_FILES["file"]["tmp_name"] implies storage path
							// in tmp directory which is moved to uploads
							// directory using move_uploaded_file() method
							if (move_uploaded_file($_FILES["file"]["tmp_name"],$target_file))
							{
								echo "The file ". basename( $_FILES["file"]["name"]) . " has been uploaded.<br>";
							}
							else 
							{
								echo "Sorry, there was an error uploading your file.<br>";
							}
						}
					}

					?>
			</div>
			</div>
			<div class="tail">
				<center><p><font color="white">Content on this website is owned, by the Ashish Kumar Singh</p>
				<p>Site is technically designed, hosted and maintained by Myself</p>
				<p>Powered By — Myself</font></p></center>
			</div>
		</div>
	</body>
</html>
