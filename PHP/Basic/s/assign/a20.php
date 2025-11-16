<?php
echo "<h1>21. WAP to show the use of file handling.</h1>";
?>
<?php
$file = fopen('test.txt', 'w');
fwrite($file, 'Hello File!');
fclose($file);
echo 'File written successfully';
?>