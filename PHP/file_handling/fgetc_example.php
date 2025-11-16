<?php
    $my_file = fopen('demo.txt', 'r');
    echo "<b>fgetc()</b>=> ";
    while(!feof($my_file)){
        $temp = fgetc($my_file);
        echo $temp;
    }
    fclose($my_file);
?>