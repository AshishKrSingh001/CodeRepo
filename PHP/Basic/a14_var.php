<?php
	$a=10;
	$b=9;
	function abc()
	{
		global $b;
		$a=30;
		echo $a . "<br>" . $b . "<br>";
	}
	abc();
	echo $a . "<br>" . $b . "<br>";
?>