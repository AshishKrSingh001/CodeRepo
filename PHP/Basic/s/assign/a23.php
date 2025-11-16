
<?php
echo "<h1>24. WAP to validate a password (must contain at least eight characters, one number, one capital, one special character).</h1>";
?>
<?php
function validatePassword($password) {
    if (preg_match('/^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*]).{8,}$/', $password)) {
        return 'Valid Password';
    } else {
        return 'Invalid Password';
    }
}
echo validatePassword('Passw0rd!');
?>