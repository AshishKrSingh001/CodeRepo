<?php
	$a=array(array(10,20,30),array(30,40,50),array(60,70,80));
	echo "Matrix: <br>";
	for($i=0;$i<count($a);$i++)
	{
		for($j=0;$j<count($a[$i]);$j++)
		{
			echo $a[$i][$j] . "		";
		}
		echo "<br>";
	}

	echo "<hr>Matrix: <br>";
	foreach($a as $b)
	{
		foreach($b as $c)
		{
			echo $c . "		";
		}
		echo "<br>";
	}
?>