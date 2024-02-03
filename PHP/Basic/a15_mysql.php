<?php
	echo "Wlcome to MySQL<br>";
	/*
		Ways to connect to a MySQL Database:
			1.MySQLi extension
			2.PDO
	*/
	$servername = "localhost";
	$username = "root";
	$password = "";
	
	//create a connection:
	$conn = mysqli_connect($servername, $username, $password);
	
	//Die if connection was not successful:
	if(!$conn)
	{
		die("Sorry failed to connect" . mysqli_connect_error());
	}
	else
	{
		echo "Connection was successfull";
	} 
?>