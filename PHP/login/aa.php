<?php
	$con = mysqli_connect("localhost","root","","anshu2");
	if($con)
	{
		$SQL_query = "SELECT * from stu2";
		$rs = mysqli_query($con,$SQL_query);
		if($rs)
		{
			//$row = mysqli_fetch_array($rs);
			/*echo "Records are:<br>";
			echo "Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Post&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbspSalary<br>";
			while($row = mysqli_fetch_array($rs))
			{
				echo $row['name'] . "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" . $row['id'] . "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" . $row['post'] . "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" . $row['email'] . "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" . $row['salary'] . "<br>";
			}*/
		}
		else
		{
			echo "MySQL error :" . mysqli_error($con) . "<br>";
		}
	}
	else
	{
		echo "Database error :" . mysqli_connect_error() . "<br>";
	}
?>

	<table height="auto" width="auto" border="2px" align="center" cellspacing="0">
		<tr><td colspan="2" align="center"><b><i><big>Student-Details</big></i></b></td></tr>
		<tr align="center">
			<td><b>NAME</b></td>
			<td><b>ID</b></td>
		</tr>
		<?php
			while($row = mysqli_fetch_array($rs))
			{
		?>
			<tr align="center">
				<td><?php echo $row['name']?></td>
				<td><?php echo $row['id']?></td>
			</tr>
		<?php
			}
		?>
	</table>
