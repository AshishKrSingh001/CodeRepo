<?php
    
    function fun(){
        $a = 5;
        static $b = 5;
       $a = $a+1;
       $b = $b+1;
       echo "a=".$a." b=".$b."<br>";
    }
    fun();
    fun();
    fun();
    fun();
?>