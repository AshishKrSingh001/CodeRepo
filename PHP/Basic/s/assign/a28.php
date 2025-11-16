




<?php
echo "<h1>29. WAP to upload an image or file, validate its type and display.</h1>";
?>
<?php
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $file = $_FILES['image'];
    $allowed_types = ['image/jpeg', 'image/png', 'image/gif'];
    if (in_array($file['type'], $allowed_types)) {
        move_uploaded_file($file['tmp_name'], 'uploads/' . $file['name']);
        echo '<img src="uploads/' . $file['name'] . '" alt="Uploaded Image" />';
    } else {
        echo 'Invalid file type';
    }
}
?>
<form method='post' enctype='multipart/form-data'>
    <input type='file' name='image' required>
    <button type='submit'>Upload</button>
</form>
