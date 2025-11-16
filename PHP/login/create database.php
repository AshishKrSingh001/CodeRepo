<?php
	$conn = mysqli_connect("localhost","root","");
	$q = "create database AKS";
	if(mysqli_query($conn,$q))
	{
		echo "Database created";
	}
	else
	{
		echo "Database not created";
	}
?>