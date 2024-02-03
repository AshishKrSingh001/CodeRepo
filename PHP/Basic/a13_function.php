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
		<tr><td><input type="submit" name="Prime" value="Prime"</td></tr>
		<tr><td><input type="submit" name="Palindrome" value="Palindrome"</td></tr>
	</table>
</form>
<?php

	function check_prime($num)
	{
		$c=0;
		for($i=2;$i<$num/2;$i++)
		{
			if($num%$i==0)
			{
				$c++;
			}
		}
		if($c==0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	function print_prime($a,$b)
	{
		for($i=$a;$i<=$b;$i++)
		{
			if(check_prime($i))
			{
				echo $i . " ";
			}
		}
		echo "<br>";
	}
	
	function rev_of_int($num)
	{
		$rev=0;
		while($num>0)
		{
			$d=$num%10;
			$rev=$rev*10+$d;
			$num=intdiv($num,10);
		}
		return $rev;
	}
	
	function print_palindrome($a,$b)
	{
		for($i=$a;$i<=$b;$i++)
		{
			if(rev_of_int($i)==$i)
			{
				echo $i . " ";
			}
		}
		echo "<br>";
	}
	if(isset($_POST['Prime']))
	{
		if(!empty($_POST['fn']) && !empty($_POST['sn']))
		{
			$num1=$_POST['fn'];
			$num2=$_POST['sn'];
			print_prime($num1,$num2);
		}
	}
	if(isset($_POST['Palindrome']))
	{
		if(!empty($_POST['fn']) && !empty($_POST['sn']))
		{
			$num1=$_POST['fn'];
			$num2=$_POST['sn'];
			print_palindrome($num1,$num2);
		}
	}
?>