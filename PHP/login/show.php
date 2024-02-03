<?php
	$conn=mysqli_connect("localhost","root","","AKS");
	if($conn)
	{
		$query = "SELECT * from data";
		$rs=mysqli_query($conn,$query);
		if($rs)
		{
			$row = mysqli_fetch_array($rs);
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
?>
			<table height="auto" width="100%" border="2px solid red" align="center" cellspacing="0" bgcolor="#c995ef" style="color:blue;">
			<tr><td align="center" colspan="23"><big><i><b>ENTITY DETAILS</b></i></big></td></tr>
			<tr>
				<th><b>sr.no.</b></th>
				<th><b>NAME</b></th>
				<th><b>GENDER</b></th>
				<th><b>FATHER'S NAME</b></th>
				<th><b>MOTHER'S NAME</b></th>
				<th><b>HUSBAND NAME</b></th>
				<th><b>MOB NO</b></th>
				<th><b>DATE OF BIRTH</b></th>
				<th><b>AADHAR</b></th>
				<th><b>ACCOUNT No.</b></th>
				<th><b>IFSC</b></th>
				<th><b>EMAIL</b></th>
				<th><b>PAN</b></th>
				<th><b>STATE</b></th>
				<th><b>DISTRICT</b></th>
				<th><b>SUB-DIVISION</b></th>
				<th><b>BLOCK</b></th>
				<th><b>TYPE</b></th>
				<th><b>POST OFFICE</b></th>
				<th><b>POLICE STATION</b></th>
				<th><b>TOWN</b></th>
				<th><b>WARD No.</b></th>
				<th><b>PINCODE</b></th>
			</tr>
			<tr>
	<?phpwhile($row)
	{?>
			<td><?php echo $row['sr_no'];?></td>
			<td><?php echo $row['name'];?></td>
			<td><?php echo $row['gen'];?></td>
			<td><?php echo $row['fname'];?></td>
			<td><?php echo $row['mname'];?></td>
			<td><?php echo $row['hname'];?></td>
			<td><?php echo $row['mob'];?></td>
			<td><?php echo $row['dob'];?></td>
			<td><?php echo $row['aadhar'];?></td>
			<td><?php echo $row['account'];?></td>
			<td><?php echo $row['ifsc'];?></td>
			<td><?php echo $row['email'];?></td>
			<td><?php echo $row['pan'];?></td>
			<td><?php echo $row['state'];?></td>
			<td><?php echo $row['district'];?></td>
			<td><?php echo $row['sub'];?></td>
			<td><?php echo $row['block'];?></td>
			<td><?php echo $row['vp'];?></td>
			<td><?php echo $row['po'];?></td>
			<td><?php echo $row['ps'];?></td>
			<td><?php echo $row['town'];?></td>
			<td><?php echo $row['ward'];?></td>
			<td><?php echo $row['pin'];?></td>
			
	<?php}?>
			</tr>
		</table>
