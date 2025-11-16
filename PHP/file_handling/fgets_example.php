<?php
    $my_file = fopen('demo.txt', 'r');
    echo "<b>fgets()</b>=> ";
    while(!feof($my_file)){
        echo fgets($my_file);
    }
    fclose($my_file);
?>