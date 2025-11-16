<?php
	include('Input.php');
?>
	<hr>
<?php
	if(isset($_POST['submit']))
	{
		if(!empty($_POST['name'])&& !empty($_POST['post']) && !empty($_POST['email']) && !empty($_POST['salary']))
		{
			$name = $_POST['name'];
			//$id = $_POST['id'];
			$post = $_POST['post'];
			$email = $_POST['email'];
			$salary = $_POST['salary'];
			
			$con = mysqli_connect("localhost","root","","cimage");
			if($con)
			{
				$SQL_query = "INSERT INTO Employee(name,post,email,salary) VALUES('$name','$post','$email','$salary')";
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
