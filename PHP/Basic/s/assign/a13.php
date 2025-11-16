
<?php
echo "<h1>14. WAP to show set or unset function.</h1>";
?>
<?php
$a = 'test';
unset($a);
echo isset($a) ? 'Set' : 'Unset';
?>