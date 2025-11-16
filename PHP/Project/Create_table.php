<?php
$con=mysqli_connect("localhost","root","","StudentDB");

if($con)
{
	$query="create table Student(id int,name varchar(20)NOT NULL,s1 float NOT NULL,s2 float NOT NULL,s3 float NOT NULL,s4 float NOT NULL,s5 float NOT NULL,s6 float NOT NULL,CGPA float NOT NULL, primary key(id)); ";
	$result=mysqli_query($con,$query);
	if($result)
	{
		echo"table created";
	}
	else
	{
		echo"table not created";
	}
}
else
{
	echo"not connected<br>";
}
	
?>