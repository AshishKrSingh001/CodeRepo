<?php
	include("h.html");
	include("connect.php");
?>
<?php $msg="";
	if(isset($_POST['submit']))
	{
		if(!empty($_POST['name'])&& !empty($_POST['num']) && !empty($_POST['email']) && !empty($_POST['story']))
		{
			$name=$_POST['name'];
			$num=$_POST['num'];
			$email=$_POST['email'];
			$story=$_POST['story'];
			$query = "insert into Hues(name,number,email,story) VALUES('$name','$num','$email','$story');";
			$rs=mysqli_query($con,$query);
			if($rs)
			{
				$msg= "Record is inserted";
			}
			else
			{
				$q1 = "select * from Hues where number='$num'";
				$rs1 = mysqli_query($con,$q1);
				$row1 = mysqli_num_rows($rs1);
				if($row1==1)
				{
					$msg= "Record already exsists";
				}
				else
				{
					$msg="Something went wrong!";
				}
			}
		}
	}
?>
<!DOCTYPE html>
<html>

<head>
  <!-- Basic -->
  <meta charset="utf-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <!-- Mobile Metas -->
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
  <!-- Site Metas -->
  <meta name="keywords" content="" />
  <meta name="description" content="" />
  <meta name="author" content="" />

  <title>Hues</title>

  <!-- slider stylesheet -->
  <!-- slider stylesheet -->
  <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.min.css" />

  <!-- bootstrap core css -->
  <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />

  <!-- fonts style -->
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:400,700|Poppins:400,700&display=swap" rel="stylesheet">
  <!-- Custom styles for this template -->
  <link href="css/style.css" rel="stylesheet" />
  <!-- responsive style -->
  <link href="css/responsive.css" rel="stylesheet" />
</head>

<body class="sub_page">

  <!-- contact section -->

  <section class="contact_section layout_padding">
    <div class="container">
		<div><center><font color="red"><?php echo $msg;?></font></center></div>
      <div class="heading_container">
        <h2>
          Request A Call Back
        </h2>
      </div>
      <div class="">
        <div class="">
          <div class="row">
            <div class="col-md-9 mx-auto">
              <div class="contact-form">
                <form action="" method="post">
                  <div>
                    <input type="text" placeholder="Full Name" name="name" required>
                  </div>
                  <div>
                    <input type="text" placeholder="Phone Number" name="num" required>
                  </div>
                  <div>
                    <input type="email" placeholder="Email Address" name="email" required>
                  </div>
                  <div>
                    <input type="text" placeholder="Message" class="input_message" name="story" required>
                  </div>
                  <div class="d-flex justify-content-center">
                    <button type="submit" class="btn_on-hover" name="submit">
                      Send
                    </button>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="map_img-box">
        <img src="images/map-img.png" alt="">
      </div>
    </div>
  </section>


  <!-- end contact section -->

<?php include("f.html");?>
</body>

</html>
