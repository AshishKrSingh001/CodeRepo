<?php
if(isset($_POST["submit"])) 
{
	// The target directory of uploading is uploads
	$target_dir = "profile/";
	$target_file1 = $target_dir . basename($_FILES["file1"]["name"]);
	$target_file2 = $target_dir . basename($_FILES["file2"]["name"]);
	$target_file3 = $target_dir . basename($_FILES["file3"]["name"]);
	
	// Check if file already exists
	// if (file_exists($target_file)) 
	// {
	// 	echo "file already exists.<br>";
	// 	echo "Your file was not uploaded.<br>";
	// }
	
	// else 
	// {
		// $_FILES["file"]["tmp_name"] implies storage path
		// in tmp directory which is moved to uploads
		// directory using move_uploaded_file() method
		if ( move_uploaded_file($_FILES["file1"]["tmp_name"],$target_file1) && move_uploaded_file($_FILES["file2"]["tmp_name"],$target_file2) && move_uploaded_file($_FILES["file3"]["tmp_name"],$target_file3))
		{
			echo "The file ". basename( $_FILES["file1"]["name"]) . " has been uploaded.<br>";
			echo "The file ". basename( $_FILES["file2"]["name"]) . " has been uploaded.<br>";
			echo "The file ". basename( $_FILES["file3"]["name"]) . " has been uploaded.<br>";
		}
		else 
		{
			echo "Sorry, there was an error uploading your file.<br>";
		}
	//}
}

?>

<html>

<head>
	<title>
		Move a file into a different
		folder on the server
	</title>
</head>

<body>
	<form method="post" enctype="multipart/form-data">
		
		<input type="file" name="file1" id="file">
		<input type="file" name="file2" id="file">
		<input type="file" name="file3" id="file">
		
		<br><br>
		
		<input type="submit" name="submit" value="Submit">
	</form>
</body>

</html>					
