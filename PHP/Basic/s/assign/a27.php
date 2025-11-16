<?php
echo "<h1>28. WAP to count no. of vowels in a string.</h1>";
?>
<?php
$str = 'Hello World';
echo preg_match_all('/[aeiou]/i', $str, $matches);
?>