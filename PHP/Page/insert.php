<?php
	include('form.php');
?>
	<hr>
<?php
	if(isset($_POST['submit']))
	{
		if(!empty($_POST['title']) && !empty($_POST['des']))
		{
			$t = $_POST['title'];
			$d = $_POST['des'];
			
			$con = mysqli_connect("localhost","root","","cimage");
			if($con)
			{
				$SQL_query = "INSERT INTO Page(title,description) VALUES('$t','$d')";
				if(mysqli_query($con,$SQL_query))
				{
					echo "Record added successfully<br>";
				}
				else
				{
					echo "MySQL error :" . mysqli_error($con) . "<br>";
				}
			}
			else
			{
				echo "Database error :" . mysqli_connect_error() . "<br>";
			}
		}
	}
?>
