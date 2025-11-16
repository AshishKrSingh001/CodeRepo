<?php
    $str = "ashish";
    // echo strrev($str);
    function rev($str){
        $rev_str ="";
        for($i=0;$i<strlen($str);$i++){
            $rev_str[strlen($str)-$i] = $str[$i];
        }
        return $rev_str;
    }
    echo rev("ashish");
?>