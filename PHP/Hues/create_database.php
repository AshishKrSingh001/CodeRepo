<?php
    
    $connect = mysqli_connect("localhost", "root", "");
    if($connect)
    {
        $query = "CREATE DATABASE HUES";
        $rs = mysqli_query($connect,$query);
        if($rs)
        {
            echo "Database created";
        }
        else
        {
            echo "Database Not created";
        }
    }

?>

