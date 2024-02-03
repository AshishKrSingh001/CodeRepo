<?php
    
    $connect = mysqli_connect("localhost", "root", "", "hues");
    if($connect)
    {
        $query = "CREATE TABLE HUES(id int AUTO_INCREMENT,name varchar(30)NOT NULL,Director varchar(30)NOT NULL,Actor1 varchar(30)NOT NULL,Actor2 varchar(30)NOT NULL,genre varchar(30)NOT NULL,years year NOT NULL,category varchar(30)NOT NULL,language varchar(30)NOT NULL,quality varchar(30)NOT NULL,logo varchar(30)NOT NULL,image1 varchar(30)NOT NULL,image2 varchar(30)NOT NULL,image3 varchar(30)NOT NULL,story text NOT NULL,primary key(id))";
        $rs = mysqli_query($connect,$query);
        $query1 = "CREATE TABLE Comment(id int AUTO_INCREMENT,name varchar(30)NOT NULL,email varchar(30)NOT NULL,comment text NOT NULL,primary key(id))";
        $rs = mysqli_query($connect,$query1);
        if($rs)
        {
            echo "Table created";
        }
        else
        {
            echo "Table Not created";
        }
    }

?>
