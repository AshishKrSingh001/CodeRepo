<?php
echo "<h1>26. WAP to find a specific word in string.</h1>";
?>
<?php
$str = 'Hello world';
if (strpos($str, 'world') !== false) {
    echo 'Word found';
} else {
    echo 'Word not found';
}
?>