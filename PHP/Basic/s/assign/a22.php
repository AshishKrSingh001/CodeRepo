<?php
echo "<h1>23. WAP to check a string is valid URL or not.</h1>";
?>
<?php
$url = 'https://www.example.com';
if (filter_var($url, FILTER_VALIDATE_URL)) {
    echo 'Valid URL';
} else {
    echo 'Invalid URL';
}
?>