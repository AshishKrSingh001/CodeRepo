<?php
echo "<h1>20. WAP to validate an email address.</h1>";
?>
<?php
$email = 'example@test.com';
if (filter_var($email, FILTER_VALIDATE_EMAIL)) {
    echo 'Valid Email';
} else {
    echo 'Invalid Email';
}
?>