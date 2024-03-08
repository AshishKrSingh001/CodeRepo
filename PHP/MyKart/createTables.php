<?php
    $msg="";
    $connect = mysqli_connect("localhost", "root", "","mykart");
    if($connect)
    {
         //Customer Table Query
        $query1 = "CREATE TABLE customer(customerNo int AUTO_INCREMENT,customerFName varchar(20)NOT NULL,customerMName varchar(20)NOT NULL,customerLName varchar(20)NOT NULL,email varchar(50)NOT NULL,cDateOfBirth DATE NOT NULL,caddress text NOT NULL,password varchar(50)NOT NULL,MobileNo VARCHAR(12) NOT NULL,CONSTRAINT customer_pk  primary key(customerNo))";
        $rs1 = mysqli_query($connect,$query1);
        if($rs1)
        {
             //Seller Table Query
             $query2 = "CREATE TABLE seller(sellerNo int AUTO_INCREMENT,sellerFName varchar(20)NOT NULL,sellerMName varchar(20)NOT NULL,sellerLName varchar(20)NOT NULL,email varchar(50)NOT NULL,sDateOfBirth DATE NOT NULL,saddress text NOT NULL,password varchar(50)NOT NULL,MobileNo VARCHAR(12) NOT NULL,CONSTRAINT seller_pk primary key(sellerNo))";
             $rs2 = mysqli_query($connect,$query2);
            if($rs2)
            {
                //Product Table Query
                $query3 = "CREATE TABLE product(productNo int AUTO_INCREMENT,productName varchar(50)NOT NULL,companyName varchar(50)NOT NULL,quan int NOT NULL,category varchar(50)NOT NULL,productImage1 varchar(150)NOT NULL,productImage2 varchar(150) NOT NULL,productDescription text NOT NULL,sellerNo int NOT NULL,price int NOT NULL,manufacturer varchar(50) NOT NULL,discount int NOT null,delivery int not null,warranty varchar(100) not null,inc_com varchar(100) not null,weight decimal(2,2) not null,CONSTRAINT product_pk primary key(productNo),CONSTRAINT product_fk FOREIGN KEY (sellerNo) REFERENCES seller(sellerNo));";
                $rs3 = mysqli_query($connect,$query3);
                if($rs3)
                {
                    //ProductBuyed
                    $query4 = "CREATE TABLE productBuyed(productBuyedNo int AUTO_INCREMENT,primary key(productBuyedNo),sellerNo int NOT NULL,customerNo int NOT NULL,productNo int NOT NULL,orderDate DATE not null,deliveryDate DATE not null,CONSTRAINT productByued_fk FOREIGN KEY (sellerNo) REFERENCES seller(sellerNo),CONSTRAINT productByued_fk1 FOREIGN KEY (customerNo) REFERENCES customer(customerNo),CONSTRAINT productByued_fk2 FOREIGN KEY (productNo) REFERENCES product(productNo));";
                    $rs4 = mysqli_query($connect,$query4);
                    if($rs4)
                    {
                        $query5 = "CREATE TABLE Comment(id int AUTO_INCREMENT,name varchar(50)NOT NULL,email varchar(50)NOT NULL,comment text NOT NULL,primary key(id))";
                        $rs5 = mysqli_query($connect,$query5);
                        if($rs5)
                        {
                            $msg = "Database is Ready";
                        }
                    }
                    else
                    {
                        $msg = "ProductBuyed Table Not created";
                    }
                }
                else
                {
                    $msg = "Product Table Not created";
                }
            }
            else
            {
                $msg = "Seller Table Not created";
            }
        }
        else
        {
            $msg = "Customer Table Not created";
        }
    }
    else
    {
        $msg = "Server Not connected";
    }
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="icon" type="image/iconMykart.jpg" href="Image/faviconMyKart.ico">
    <title>MyKart</title>
    <style>
        *{
            margin: 0;
            padding: 0;
        }
        body{
            overflow-y: scroll;
            overflow-x: hidden;
            scrollbar-width: none;  
            -ms-overflow-style: none;
        }
    </style>
</head>
<body>
    <div class="main" style="margin-top:5vh;"><h1 style="text-align:center;"><?php echo $msg; ?></h1></div>
</body>
</html>

