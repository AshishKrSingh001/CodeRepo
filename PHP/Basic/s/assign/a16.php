<?php
echo "<h1>17. WAP to create constructor and initialize the object of a class using constructor.</h1>";
?>
<?php
class Person {
    public $name;
    function __construct($name) {
        $this->name = $name;
    }
}
$p = new Person('Ashish');
echo $p->name;
?>