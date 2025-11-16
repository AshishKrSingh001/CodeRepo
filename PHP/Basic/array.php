<?php
$arr=array(100,20,30,40);
$arr1=array(100,200,20,80);
// $arr1=[10,20,440,40];
// print_r($arr);
// echo"<br>";
// print_r($arr1);
// echo"<br>";
$assoc_arr=array('name'=>'seema','roll'=>'y047');
// print_r($assoc_arr);
// echo"<br>";
// $multi_dem_array = array(array(10, 20, 30), array(11, 21, 31), array(12, 22, 32));
// print_r($multi_dem_array);

// Array Functions
print_r($arr);
print_r($arr1);
echo"<br>";
// array_push($arr,11,12);
// echo array_pop($arr) . "<br>";
// echo array_shift($arr) . "<br>";
// array_unshift($arr,1);
// echo array_search(40, $arr) . "<br>";
// sort($arr);
// echo count($arr) . "<br>";
// print_r(array_merge($arr,$arr));
// print_r(array_diff($arr,$arr1));
// print_r(array_intersect($arr,$arr1));
// print(in_array(1000,$arr));
// print_r(array_keys($assoc_arr));
// print_r(array_values($assoc_arr));
print_r(array_slice($arr,2,2));
// print_r(array_reverse($arr));
echo array_sum($arr);
echo"<br>";
print_r($arr);
?>