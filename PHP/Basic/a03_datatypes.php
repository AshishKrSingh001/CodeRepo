<?php
	/*
		Datatypes: 
			String
			Integer
			Float
			Boolean
			Object
			Array 
			Null
	*/
	
	#string
	$f_name="Ashish";
	$l_name=" Singh";
	echo "My name is :". $f_name . $l_name . "<br>";
	
	#Integer
	$f_num=100;
	$l_num=200;
	echo "Sum: ". ($f_num+$l_num) . "<br>";
	
	#Float
	$income=20000.50;
	$spent=19000.365;
	$saving=$income-$spent;
	echo "Saving: ". $saving . "<br>";
	
	#Boolean
	$t=true;
	$f=false;
	echo var_dump($t) . "<br>";
	echo var_dump($f) . "<br>";
	
	#Object
	
	
	#Array
	$arr = array(10,20,30,40,50);
	$arr2 = array("Ashish","Kumar","Singh");
	echo var_dump($arr) . "<br>";
	echo var_dump($arr) . "<br>";
	$i;
	echo "Array :<br>";
	for($i=0;$i<3;$i++)
	{
		echo $arr[$i] . "<br>";
	}
	
	#Null
	$n=NULL;
	echo var_dump($n) . "<br";
	
	/*echo var_dump($f_name) . "<br>";
	echo var_dump($f_num) . "<br>";
	echo var_dump($income) . "<br>";
	echo var_dump($arr) . "<br>";
	echo var_dump($arr) . "<br>";*/
	
?>