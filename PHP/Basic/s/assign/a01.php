<h1>1. write php program  to show a use of operator</h1>
<?php
// Arithmetic operators
$a = 10;
$b = 2;
echo"addition is:".$a+$b."<br>";
echo"subtraction is:".$a-$b."<br>";
echo"multiplication is:".$a*$b."<br>";
echo"division is:".$a/$b."<br>";
echo"a is greater than b:".($a>$b ?"yes":"no")."<br>";
echo"a is not greater than b:".($a<=$b?"yes":"no")."<br>";
//logical operators
$c=True;
$d=false;
echo"c and d:".($c && $d ? "True":"false")."<br>";
echo"c or d:".($c || $d ?"True":"false")."<br>";
?>
