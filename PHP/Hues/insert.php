<?php 
    $msg="";
    $con = mysqli_connect("localhost","root","","hues");
    if($con)
    {
        if(isset($_POST['sub']))
        {
            if(!empty($_POST['name']) && !empty($_POST['director']) && !empty($_POST['actor1']) && !empty($_POST['actor2']) && !empty($_POST['years']) && !empty($_POST['story'])  && !empty($_POST['language']) && !empty($_POST['genre']) && !empty($_POST['quality']) && !empty($_FILES["logo"]["name"]) || !empty($_FILES["image1"]["name"]) || !empty($_FILES["image2"]["name"]) || !empty($_FILES["image3"]["name"]) || !empty($_POST["category"]))
            {
                $name = trim($_POST['name']);
                $director = trim($_POST['director']);
                $actor1 = trim($_POST['actor1']);
                $actor2 = trim($_POST['actor2']);
                $years = $_POST['years'];
                $story = trim($_POST['story']);
                $genre = $_POST['genre'];
                $language = $_POST['language'];
                $quality = $_POST['quality'];
                $category = $_POST['category'];

                // Check if file is image or not;
                $check1 = getimagesize($_FILES["img1"]["tmp_name"]);
                $check2 = getimagesize($_FILES["img2"]["tmp_name"]);
                $check3 = getimagesize($_FILES["img3"]["tmp_name"]);
                $check4 = getimagesize($_FILES["img4"]["tmp_name"]);
                if($check1 !== false && $check2 !== false && $check3 !== false && $check4 !== false) 
                {
                    $target_dir = "image/";
                    $target_file1 = $target_dir . $name . "_1.jpg";
                    $target_file2 = $target_dir . $name . "_2.jpg";
                    $target_file3 = $target_dir . $name . "_3.jpg";
                    $target_file4 = $target_dir . $name . "_4.jpg";

                    if (file_exists($target_file1) || file_exists($target_file2) || file_exists($target_file3) || file_exists($target_file4)) 
	                {
                        $msg= "image already exists";
                    }
                    else 
                    {
                        $q = "INSERT INTO hues(name,Director,Actor1,Actor2,genre,years,category,language,quality,logo,image1,image2,image3,story) values('$name','$director','$actor1','$actor2','$genre','$years','$category','$language','$quality','$target_file1','$target_file2','$target_file3','$target_file4','$story');";

                        $rs = mysqli_query($con,$q);
                        if($rs)
                        {
                            if (move_uploaded_file($_FILES["img1"]["tmp_name"],$target_file1)
                            && move_uploaded_file($_FILES["img2"]["tmp_name"],$target_file2)
                            && move_uploaded_file($_FILES["img3"]["tmp_name"],$target_file3) 
                            && move_uploaded_file($_FILES["img4"]["tmp_name"],$target_file4))
                            {
                                $msg = "Movie is uploaded";
                            }
                            else 
                            {
                                $msg= "image not uploaded";
                            }
                        }
                        else
                        {
                            $msg =  ("Error description: " . mysqli_error($con));
                        } 
                        
                    }

                } 

            }
            else
            {
                $msg="Please fill all records";
            }
        }
    }
    else
    {
        $msg="mysqli Not connected";
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="insert_style.css">
    <title>insert</title>
</head>
<body>
    <div class="header"><?php include("head.php");?></div>
    <div class="contain">
        <div class="main">
        <p class="message"><?php echo $msg?></p>
            <p class="p">MOVIES&nbsp;&nbsp;DETAILS</p>
            <form action="" class="form" method="post" enctype="multipart/form-data">
                <div class="main1">
                    <table>
                        <tr><td><p>NAME</p></td></tr>
                        <tr>
                            <td><input class="input" type="text" name="name" required></td>
                        </tr>
                        <tr><td><p>DIRECTOR</p></td></tr>
                        <tr>
                            <td><input class="input" type="text" name="director" required></td>
                        </tr>
                        <tr><td><p>ACTOR I</p></td></tr>
                        <tr>
                            <td><input class="input" type="text" name="actor1" required></td>
                        </tr>
                        <tr><td><p>ACTOR II</p></td></tr>
                        <tr>
                            <td><input class="input" type="text" name="actor2"required></td>
                        </tr>
                        <tr><td><p>YEAR OF RELEASE</p></td></tr>
                        <tr>
                            <td><input class="input"  type="number" min="1900" max="2099" step="1" name="years" ></td>
                        </tr>
                        <tr><td><p>CATEGORY</p></td></tr>
                        <tr>
                            <td>
                                <select class="input" name="category">
                                    <option value="Bollywood">&nbsp;&nbsp;&nbsp;&nbsp;----SELECT----</option>
                                    <option value="Bollywood">&nbsp;&nbsp;&nbsp;&nbsp;Bollywood</option>
                                    <option value="Hollywood">&nbsp;&nbsp;&nbsp;&nbsp;Hollywood</option>
                                    <option value="SouthIndian">&nbsp;&nbsp;&nbsp;&nbsp;SouthIndian</option>
                                    <option value="Korean">&nbsp;&nbsp;&nbsp;&nbsp;Korean</option>
                                    <option value="Other">&nbsp;&nbsp;&nbsp;&nbsp;Other</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td><p>STORY</p></td>
                        </tr>
                        <tr>
                            <!-- <td><input class="text" type="text" name="story" required></td> -->
                            <td><textarea class="text" name="story" id="" cols="30" rows="5"></textarea></td>
                        </tr>
                    </table>
                </div>
                <div class="main2">
                    <table>
                        <tr>
                            <td><p>LANGUAGE</p></td>
                        </tr>
                        <tr>
                            <td>
                                <select name="language" class="input">
                                    <option value="hindi">&nbsp;&nbsp;&nbsp;&nbsp;----SELECT----</option>
                                    <option value="hindi">&nbsp;&nbsp;&nbsp;&nbsp;Hindi</option>
                                    <option value="hindi & English">&nbsp;&nbsp;&nbsp;&nbsp;Hindi & English</option>
                                    <option value="english">&nbsp;&nbsp;&nbsp;&nbsp;English</option>
                                    <option value="bhojpuri">&nbsp;&nbsp;&nbsp;&nbsp;Bhojpuri</option>
                                    <option value="bangali">&nbsp;&nbsp;&nbsp;&nbsp;Bangali</option>
                                    <option value="Marathi">&nbsp;&nbsp;&nbsp;&nbsp;Marathi</option>
                                    <option value="Gujrati">&nbsp;&nbsp;&nbsp;&nbsp;Gujrati</option>
                                    <option value="Tamil">&nbsp;&nbsp;&nbsp;&nbsp;Tamil</option>
                                    <option value="Telgu">&nbsp;&nbsp;&nbsp;&nbsp;Telgu</option>
                                    <option value="Kannada">&nbsp;&nbsp;&nbsp;&nbsp;Kannada</option>
                                    <option value="Malayalam">&nbsp;&nbsp;&nbsp;&nbsp;Malayalam</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td><P>QUALITY</P></td>
                        </tr>
                        <tr>
                            <td>
                                <select class="input" name="quality">
                                    <option value="720">&nbsp;&nbsp;&nbsp;&nbsp;----SELECT----</option>
                                    <option value="360">&nbsp;&nbsp;&nbsp;&nbsp;360</option>
                                    <option value="480">&nbsp;&nbsp;&nbsp;&nbsp;480</option>
                                    <option value="720">&nbsp;&nbsp;&nbsp;&nbsp;720</option>
                                    <option value="1080">&nbsp;&nbsp;&nbsp;&nbsp;1080/HD</option>
                                    <option value="2K">&nbsp;&nbsp;&nbsp;&nbsp;1440/2K</option>
                                    <option value="4K">&nbsp;&nbsp;&nbsp;&nbsp;2160/4K</option>
                                </select>
                            </td>
                        </tr>
                        <tr><td><p>GENRE</p></td></tr>
                        <tr>
                            <td>
                                <select class="input" name="genre">
                                <option value="Action">&nbsp;&nbsp;&nbsp;&nbsp;----SELECT----</option>
                                    <option value="Action">&nbsp;&nbsp;&nbsp;&nbsp;Action</option>
                                    <option value="Comedy">&nbsp;&nbsp;&nbsp;&nbsp;Comedy</option>
                                    <option value="Horror">&nbsp;&nbsp;&nbsp;&nbsp;Horror</option>
                                    <option value="Romantic">&nbsp;&nbsp;&nbsp;&nbsp;Romantic</option>
                                    <option value="Drama">&nbsp;&nbsp;&nbsp;&nbsp;Drama</option>
                                    <option value="Suspense Thriller">&nbsp;&nbsp;&nbsp;&nbsp;Suspense Thriller</option>
                                    <option value="Action Comedy">&nbsp;&nbsp;&nbsp;&nbsp;Action Comedy</option>
                                    <option value="Horror Comedy">&nbsp;&nbsp;&nbsp;&nbsp;Horror Comedy</option>
                                    <option value="Thiller">&nbsp;&nbsp;&nbsp;&nbsp;Thiller</option>
                                    <option value="Fantasy">&nbsp;&nbsp;&nbsp;&nbsp;Fantasy</option>
                                    <option value="Science Fiction">&nbsp;&nbsp;&nbsp;&nbsp;Science Fiction</option>
                                    <option value="Adventure">&nbsp;&nbsp;&nbsp;&nbsp;Adventure</option>
                                    <option value="Historical">&nbsp;&nbsp;&nbsp;&nbsp;Historical</option>
                                    <option value="Documentry">&nbsp;&nbsp;&nbsp;&nbsp;Documentry</option>
                                    <option value="Mystery">&nbsp;&nbsp;&nbsp;&nbsp;Mystery</option>
                                    <option value="Biopic">&nbsp;&nbsp;&nbsp;&nbsp;Biopic</option>
                                    <option value="rom-com">&nbsp;&nbsp;&nbsp;&nbsp;rom-com</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td><P>POSTER</P></td>
                        </tr>
                        <tr>
                            <td class="file"><input type="file" name="img1"></td>
                        </tr>
                        <tr>
                            <td><P>IMAGE I</P></td>
                        </tr>
                        <tr>
                            <td class="file"><input type="file" name="img2"></td>
                        </tr>
                        <tr>
                            <td><P>IMAGE II</P></td>
                        </tr>
                        <tr>
                            <td class="file"><input type="file" name="img3"></td>
                        </tr>
                        <tr>
                            <td><P>IMAGE III</P></td>
                        </tr>
                        <tr>
                            <td class="file"><input type="file" name="img4"></td>
                        </tr>
                        <!-- <tr><td align="Right"></td></tr> -->
                    </table>
                </div>
                <input class="btn" type="submit" name="sub" value="add">
            </form>
        </div>
    </div>
    <div class="footer"><?php include("foot.php");?></div>
</body>
</html>


