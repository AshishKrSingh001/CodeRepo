<form method="post">
	<table>
		<tr>
			<td>First No: </td>
			<td><input type="number" name="fn"></td>
		</tr>
		<tr>
			<td>Second No: </td>
			<td><input type="number" name="sn"></td>
		</tr>
		<tr><td><input type="submit" name="swap" value="swap">
		<!-- <input type="reset" name="reset" value="reset"></td></tr> -->
	</table>
</form>
<?php
    $fno=0;
    $sno=0;
    if(isset($POST['swap'])){
        if(!empty($_POST['fn']) && !empty($_POST['sn'])){
            $fno=$_POST['fn'];
            $sno=$_POST['sn'];
            echo "First No: ",$fno,"\nSecond No: ",$sno;
        }
    }

?>