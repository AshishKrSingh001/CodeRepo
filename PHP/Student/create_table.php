<?php
	$con=mysqli_connect("localhost","root","");
	if($con)
	{
		//$table="create table student(id int,name varchar(20)not null,primary key(id))";
		$database = "create database Ashish";
		$query=mysqli_query($con,$database);
		if($query)
		{
			echo("table is created");
		}
		else
		{
			echo("table is not created");
		}
	}
	else
	{
		echo("mysqli_not connected");
	}
?>