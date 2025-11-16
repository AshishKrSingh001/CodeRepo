<?php
include("connect.php");
$query="create table Hues(name varchar(20)NOT NULL,number varchar(20)NOT NULL,email varchar(20)NOT NULL,story text NOT NULL, primary key(number)); ";
	$result=mysqli_query($con,$query);
	if($result)
	{
		echo"table created";
	}
	else
	{
		echo"table not created";
	}
?>