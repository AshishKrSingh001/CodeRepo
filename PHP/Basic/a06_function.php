<?php
	function s_sort($arr)
	{
		for($i=0;$i<count($arr)-1;$i++)
		{
			for($j=$i+1;$j<count($arr);$j++)
			{
				if($arr[$i]>$arr[$j])
				{
					$temp = $arr[$i];
					$arr[$i] = $arr[$j];
					$arr[$j] = $temp;
				}
			}
		}
		foreach($arr as $value)
		{
			echo $value . "<br>";
		}
	}
	$num = array(10,20,98,78,56,41,01,20,32,014,1456,789,213,11);
	echo "Array: <br>";
	foreach($num as $value)
	{
		echo $value . "<br>";
	}
	echo "Sorted Array: <br>";
	s_sort($num);
	
?>