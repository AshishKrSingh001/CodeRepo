<?php
$con=mysqli_connect("localhost","root","");
if($con)
{
	$query="create database MyDB";
	$result=mysqli_query($con,$query);
	if($result)
	{
		echo"database created";
		
	}
	else
	{
		echo"database not created";
	}
}
else
{
	echo "data base not connected<br>";
	
}
?>