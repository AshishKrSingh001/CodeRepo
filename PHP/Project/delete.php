<?php
						$conn=mysqli_connect("localhost","root","","StudentDB");
						if($conn)
						{
							$dl = $_GET['dl'];
							$query = "DELETE from Student where id=" . $dl . "";
							$rs=mysqli_query($conn,$query);
							if($rs)
							{
								header("location: show.php");
							}
							else
							{
								$conn->error;
							}
						}
						else
						{
							echo "MYSQL not connected<br>";
						}
?>