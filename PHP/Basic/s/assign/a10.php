
<?php
echo "<h1>11. Find factorial of a number.</h1>";
?>
<?php
function factorial($n) {
    if ($n == 0) return 1;
    else return $n * factorial($n - 1);
}
echo factorial(5);
?>