<?php
    abstract class Animal{
        public function __construct()
        {   
            echo "Animal construcor<br>";
        }
        abstract public function sound();
        abstract public function hello();
        public function bye(){
            echo "bye<br>";
        }
    }


    class Dog extends Animal{
        public function __construct()
        {
            Animal::__construct();
            echo "Dog constructor<br>";
        }
        public function sound(){
            echo "sound<br>";
        }
        public function hello(){
            echo "hello<br>";
        }
    }

    $dog = new Dog();
    $dog->bye();
    $dog->hello();
    $dog->sound();
?>