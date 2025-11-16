
<?php
echo "<h1>15. WAP to reverse a string using simple function or using parameterized function.</h1>";
?>
<?php
function reverseString($str) {
    return strrev($str);
}
echo reverseString('hello');
?>