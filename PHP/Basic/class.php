<?php
    class Student{
        public $name;
        public $id;
       public function __construct($name, $id){
        $this->name=$name;
        $this->id = $id;
       }
       public function __destruct()
       {
        echo "Name: ". $this->name . "<br>Id: ".$this->id."<br>";
       }
    }
    $s1 = new Student("Seema patel", 47);
?>