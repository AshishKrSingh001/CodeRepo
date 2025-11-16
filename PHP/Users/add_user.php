<?php
	include('form.php');
?>
	<hr>
<?php
	if(isset($_POST['submit']))
	{
		if(!empty($_POST['uname']) && !empty($_POST['pword']))
		{
			$username = $_POST['uname'];
			$password = $_POST['pword'];
			
			$con = mysqli_connect("localhost","root","","cimage");
			if($con)
			{
				$querry = "INSERT INTO users(username,password) VALUES('$username','$password')";
				if(mysqli_query($con,$querry))
				{
					echo "Record added successfully<br>";
				}
				else
				{
					echo "MySQL error :" . mysql_error . "<br>";
				}
			}
			else
			{
				echo "Database error :" . mysqli_connect_error() . "<br>";
			}
		}
	}
?>
