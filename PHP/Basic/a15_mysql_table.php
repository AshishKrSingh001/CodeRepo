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
	
	//create a Database:
	$sql = "CREATE DATABASE ASHISH01";
	$result = mysqli_query($conn,$sql);
	
	// check Database creation: 
	if($result)
	{
		echo "DataBase is created<br>";
	}
	else
	{
		echo "DataBase is not created because " . mysqli_error($conn);
	}
	echo "The result is ";echo  var_dump($result) . "<br>";
	
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