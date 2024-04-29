package GUI;

import javax.swing.*;
import java.awt.event.*;
import java.awt.*;

public class FocusListenerInterface extends JFrame implements FocusListener
{
	JTextField txtUserId;
	JPasswordField txtPassword;
	
	public FocusListenerInterface()
	{
		JPanel panel1 = new JPanel();
		panel1.add(new JLabel("Enter User ID: "));
		txtUserId = new JTextField(20);
		panel1.add(txtUserId);
		add(panel1);
		
		JPanel panel2 = new JPanel();
		panel2.add(new JLabel("Enter User Password: "));
		txtPassword = new JPasswordField(20);
		panel2.add(txtPassword);
		add(panel2);
		
		txtUserId.addFocusListener(this);
		txtPassword.addFocusListener(this);
		
		/*add(panel1);
		add(panel2);
		setVisible(true);
		setTitle("FocusListenerInterface");
		setSize(500,500);*/
	}
	public void focusGained(FocusEvent e)
	{
		Component c = (Component)e.getSource();
		Color green = new Color(0,200,0);
		c.setBackground(green);
	}
	
	public void focusLost(FocusEvent e)
	{
		Component c = (Component)e.getSource();
		Color white = new Color(255,255,255);
		c.setBackground(white);
	}
	
	public static void main(String[]args)
	{
		FocusListenerInterface obj = new FocusListenerInterface();
		obj.setTitle("FocusListenerInterface");
		obj.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		obj.setBounds(100,200,400,200);
		obj.setVisible(true);
		
	}
}