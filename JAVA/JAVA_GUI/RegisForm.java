package GUI;

import javax.swing.*;
import java.awt.*;

public class RegisForm extends JFrame
{
	JPanel main,rbutton;
	JButton sub;
	JLabel lblName,lblEmail,lblPno,lblGender,header;
	JTextField name,email,pno;
	JRadioButton male,female;
	ButtonGroup gender;
	
	public RegisForm()
	{
		GridBagConstraints c = new GridBagConstraints();
		
		c.fill = GridBagConstraints.HORIZONTAL; 
		
		main = new JPanel();
		main.setLayout(new GridBagLayout());
		
		c.gridx = 0;
		c.gridy= 0;
		c.gridwidth = 2;
		header = new JLabel("Registration Form");
		c.anchor = GridBagConstraints.CENTER;
		main.add(header,c);
		
		c.gridwidth = 1;
		c.fill = c.HORIZONTAL;
		lblName = new JLabel("Name: ");
		c.gridx = 0;
		c.gridy= 1;
		main.add(lblName,c);
		
		name = new JTextField(20);
		c.gridx = 1;
		main.add(name,c);
		
		lblEmail = new JLabel("Email: ");
		c.gridx = 0;
		c.gridy= 2;
		main.add(lblEmail,c);
		
		email = new JTextField(20);
		c.gridx = 1;
		main.add(email,c);
		
		lblPno = new JLabel("Phone No: ");
		c.gridy = 3;
		c.gridx = 0;
		main.add(lblPno,c);
		
		pno = new JTextField(20);
		c.gridx = 1;
		main.add(pno,c);
		
		lblGender = new JLabel("Gender: ");
		c.gridx = 0;
		c.gridy = 4;
		main.add(lblGender,c);
		
		gender = new ButtonGroup();
		rbutton= new JPanel();
		male = new JRadioButton("Male");
		female = new JRadioButton("Female");
		c.gridx = 1;
		rbutton.add(male);
		rbutton.add(female);
		main.add(rbutton,c);
		
		sub = new JButton("SignUp");
		c.gridx = 1;
		c.gridy = 5;
		c.gridwidth = 2;
		main.add(sub,c);
		
		main.setBackground(Color.CYAN);
		add(main);
		setSize(800,800);
		setVisible(true);
		setTitle("Registration Form");
	}
	
	public static void main(String[]args)
	{
		RegisForm rf = new RegisForm();
	}
}