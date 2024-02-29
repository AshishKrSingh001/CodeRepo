package GUI;

import javax.swing.*;
import java.awt.FlowLayout;
import java.awt.BorderLayout;

class FlowLayoutEx extends JFrame
{
	JLabel fname,mname,lname;
	JPanel jp;
	FlowLayoutEx()
	{
		jp = new JPanel();
		fname = new JLabel("Enter Your  First Name: ");
		mname = new JLabel("Enter Your  Middle Name: ");
		lname = new JLabel("Enter Your  Last Name: ");
		
		jp.add(fname);
		jp.add(mname);
		jp.add(lname);
		
		add(jp);
		setTitle("FLowLayoutEx");
		setVisible(true);
		setSize(300,300);
		//setLayout(new FlowLayout());
		setLayout(new BorderLayout());
		
	}
}

public class Z_FLowLayoutEx
{
	public static void main(String[]args)
	{
		FlowLayoutEx f = new FlowLayoutEx();
	}
}