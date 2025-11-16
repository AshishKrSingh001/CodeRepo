<?php
    $my_file = fopen('demo.txt', 'a');
    $str = "<strong>My name is Ashish</strong>";
    echo fwrite($my_file, $str);
    fclose($my_file);
?>