<?php
	$conn = mysqli_connect("localhost","root","","cimage");
	if($conn)
	{
		$query = "create table Page(title VARCHAR(20) NOT NULL,description VARCHAR(100),PRIMARY KEY(title))";
		if(mysqli_query($conn,$query))
		{
			echo "Table is created<br>";
		}
		else
		{
			echo "Table not created<br>";
		}
	}
	else
	{
		echo "Not connected with mysql :" . mysqli_connect_error() . "<br>";
	}
?>