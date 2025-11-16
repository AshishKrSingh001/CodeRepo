<?php
echo "<h1>25. WAP to extract domain name from URL.</h1>";
?>
<?php
$url = 'https://www.example.com/page';
echo parse_url($url, PHP_URL_HOST);
?>