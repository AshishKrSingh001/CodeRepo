
<?php
echo "<h1>19. WAP to find compound interest.</h1>";
?>
<?php
function compoundInterest($principal, $rate, $time) {
    return $principal * pow((1 + $rate/100), $time);
}
echo compoundInterest(1000, 5, 2);
?>