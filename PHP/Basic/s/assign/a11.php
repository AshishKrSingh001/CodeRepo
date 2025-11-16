

<?php
echo "<h1>12. Check given no. is palindrome or not.</h1>";
?>
<?php
$num = 121;
$rev = strrev(strval($num));
echo ($num == $rev) ? 'Palindrome' : 'Not Palindrome';
?>