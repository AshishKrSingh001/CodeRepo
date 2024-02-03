<?php
	$con = mysqli_connect("localhost","","","AKS");
	if($con)
	{
		$q="create table data(name)";
	}
	else
	{
		echo "Not connected";
	}
?>