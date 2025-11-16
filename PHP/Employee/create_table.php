<?php
	$conn = mysqli_connect("localhost","root","","cimage");
	if($conn)
	{
		$query = "create table Employee(name VARCHAR(20) NOT NULL,id INT AUTO_INCREMENT,post VARCHAR(20) NOT NULL,email VARCHAR(30) NOT NULL,salary INT NOT NULL,PRIMARY KEY(id))";
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