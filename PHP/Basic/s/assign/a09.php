<?php
echo "<h1>10. WAP to check whether given no. is prime no. or not.</h1>";
?>
<?php
function isPrime($n) {
    if ($n <= 1) return false;
    for ($i = 2; $i <= sqrt($n); $i++) {
        if ($n % $i == 0) return false;
    }
    return true;
}
echo isPrime(7) ? 'Prime' : 'Not Prime';
?>