<?php
	include("signup_form.html");
	if(isset($_POST['submit']))
		{
			$gen;				$dob=$_POST['dob'];
			$name=strtoupper($_POST['name']);	$aadhar=$_POST['aadhar'];
			$fname=strtoupper($_POST['fname']);	$acc=$_POST['account'];
			$mname=strtoupper($_POST['mname']);	$ifsc=strtoupper($_POST['ifsc']);
			$hname=strtoupper($_POST['hname']);		$pan=strtoupper($_POST['pan']);
			$mob=$_POST['mob'];	$email=$_POST['email'];
			$state=strtoupper($_POST['state']);	$district=strtoupper($_POST['district']);
			$sub=strtoupper($_POST['sub']);$block=strtoupper($_POST['block']);
			$vp;			$ward=$_POST['ward'];
			$town=strtoupper($_POST['town']);	$po=strtoupper($_POST['po']);
			$ps=strtoupper($_POST['ps']);		$pin=$_POST['pin'];
			if(!empty($_POST['male']))
				{
					$gen="MALE";
				}
				elseif(!empty($_POST['female']))
				{
					$gen = "FEMALE";
				}
				else
				{
					$gen = "OTHER";
				}
				if(!empty($_POST['vp1']))
				{
					$vp = "VILLAGE PANCHAYAT";
				}
				elseif(!empty($_POST['vp2']))
				{
					$vp = "MUNCIPAL CORPORATION";
				}
				elseif(!empty($_POST['vp3']))
				{
					$vp = "MUNCIPALITY";
				}
				else
				{
					$vp = "TOWN PANCHAYAT";
				}
			
			if(!empty($name) && !empty($fname) && !empty($mname) && !empty($aadhar) && !empty($acc) && !empty($mob) && !empty($town) && !empty($sub) && !empty($pin) && !empty($state) && !empty($ps))
			{
				$conn=mysqli_connect("localhost","root","","AKS");
				if($conn)
				{
					$query = "insert into data(name,gen,fname,mname,hname,mob,dob,aadhar,account,ifsc,email,pan,state,district,sub,block,vp,ps,po,town,ward,pin) values('$name','$gen','$fname','$mname','$hname','$mob','$dob','$aadhar','$acc','$ifsc','$email','$pan','$state','$district','$sub','$block','$vp','$po','$ps','$town','$ward','$pin')";
					$rs=mysqli_query($conn,$query);
					if($rs)
					{
						echo "Table is created<br>";
					}
					else
					{
						$conn -> error;
					}
				}
				else
				{
					echo "MYSQL not connected<br>";
				}
			}
			
		}
	
?>
