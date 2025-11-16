package GUI;
import javax.swing.*;

public class JDIalogBoxEx extends JFrame
{
	JDialog obj;
	
	JDIalogBoxEx()
	{
		obj = new JDialog();
		obj.setTitle("JDialog Demo");
		obj.setVisible(true);
		obj.setSize(500,500);
	}
	public static void main(String args[])
	{
		JDIalogBoxEx obj = new JDIalogBoxEx();
	}
}