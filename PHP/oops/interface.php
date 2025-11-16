<?php
    interface Animal{
        public const NUM = 5;
        public function sound();
        public function hello();
    }


    class Dog implements Animal{
        public function __construct()
        {
            echo "Dog constructor<br>";
        }
        public function sound(){
            echo "sound<br>";
        }
        public function hello(){
            echo "hello<br>";
        }
        // public function bye(){

        // }
    }

    $dog = new Dog();
    echo DOG::NUM;
    $dog->hello();
    $dog->sound();
?>