<?php
    $my_file = fopen('demo.txt', 'r');
    $str = fread($my_file, filesize('demo.txt'));
    echo "<b>fread()</b>=> ".$str;
    fclose($my_file);
?>