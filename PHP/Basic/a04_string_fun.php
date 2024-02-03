<?php
	/*
		String Functions:
			strlen
			strrev
			str_word_count;
			strpos;
			str_replace
			str_repeat
			rtrim
			ltrim
	*/
	#string
	$s = "My name is Ashish and i am pursuing BCA from CIMAGE";
	echo "String: " . $s . "<br>";
	
	#strlen
	echo "strlen: " . strlen($s) . "<br>";
	
	#strrev
	echo "strrev: " . strrev($s) . "<br>";
	
	#str_word_count
	echo "str_word_count: " . str_word_count($s) . "<br>";
	
	#strpos
	echo "strpos: " . strpos($s,"Ashish") . "<br>";
	
	#str_repeat
	echo "str_repeat: " . str_repeat("Ashish",3) . "<br>";
	
	#str_replace
	echo "str_replace: " . str_replace("CIMAGE","ABC",$s) . "<br>";
	
	#rtrim
	$st = "		Ashish		";
	echo "String before trim: " . $st . "<br>";
	echo "rtrim: " . rtrim($st) . "<br>";
	echo "ltrim: " . ltrim($st) . "<br>";
	
	
?>