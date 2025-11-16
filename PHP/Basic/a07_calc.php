<form method="post">
	<table>
		<tr>
			<td>First No: </td>
			<td><input type="number" name="fn"</td>
		</tr>
		<tr>
			<td>Second No: </td>
			<td><input type="number" name="sn"></td>
		</tr>
		<tr><td><input type="submit" name="sum" value="+">
		<input type="submit" name="sub" value="-">
		<input type="submit" name="mult" value="*">
		<input type="submit" name="div" value="/">
		<input type="reset" name="reset" value="reset"></td></tr>
	</table>
</form>
<?php
	/*$fno=$_POST['fn'];
	$sno=$_POST['sn'];
	$r=$fno+$sno;
	echo "Result: " . ($r) . "<br>";
	print_r($_POST);*/
	if(isset($_POST['sum']))
		{
			if(!empty($_POST['fn']) && !empty($_POST['sn']))
			{
				$fno=$_POST['fn'];
				$sno=$_POST['sn'];
				$r=$fno+$sno;
				echo "Result: " . ($r) . "<br>";
				
			}
		}
		elseif(isset($_POST['sub']))
		{
			if(!empty($_POST['fn']) && !empty($_POST['sn']))
			{
				$fno=$_POST['fn'];
				$sno=$_POST['sn'];
				$r=$fno-$sno;
				echo "Result: " . ($r) . "<br>";
			}
		}
		elseif(isset($_POST['mult']))
		{
			if(!empty($_POST['fn']) && !empty($_POST['sn']))
			{
				$fno=$_POST['fn'];
				$sno=$_POST['sn'];
				$r=$fno*$sno;
				echo "Result: " . ($r) . "<br>";
			}
		}
		elseif(isset($_POST['div']))
		{
			if(!empty($_POST['fn']) && !empty($_POST['sn']))
			{
				$fno=$_POST['fn'];
				$sno=$_POST['sn'];
				$r=$fno/$sno;
				echo "Result: " . ($r) . "<br>";
			}
		}
	
?>