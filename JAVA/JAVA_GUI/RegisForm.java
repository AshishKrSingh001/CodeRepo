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
		
		setLayout(new GridBagLayout());
		GridBagConstraints c = new GridBagConstraints();
		
		main = new JPanel();
		rbutton= new JPanel();
		sub = new JButton("SignUp");
		lblName = new JLabel("Name: ");
		lblEmail = new JLabel("Email: ");
		lblPno = new JLabel("Phone No: ");
		lblGender = new JLabel("Gender: ");
		header = new JLabel("Registration Form");
		name = new JTextField(20);
		email = new JTextField(20);
		pno = new JTextField(20);
		gender = new ButtonGroup();
		male = new JRadioButton("Male");
		female = new JRadioButton("Female");
		
		
		c.gridx = 0;
		c.gridy = 0;
		c.weighty =1;
		c.weightx=2;
		//c.anchor = c.FIRST_LINE_START;
		main.add(header,c);
		
		c.gridx = 1;
		c.gridy= 0;
		c.weightx=1;
		main.add(lblName,c);

		c.gridy = 1;
		main.add(name,c);
		
		c.gridx = 2;
		c.gridx = 0;
		main.add(lblEmail,c);
		
		c.gridy = 1;
		main.add(email,c);

		c.gridx = 3;
		c.gridx = 0;
		main.add(lblPno,c);
		
		c.gridy = 1;
		main.add(pno,c);
		
		c.gridx = 4;
		c.gridy = 0;
		main.add(lblGender,c);
		
		c.gridy = 1;
		rbutton.add(male);
		rbutton.add(female);
		main.add(rbutton,c);
		
		c.gridx = 5;
		c.gridy = 1;
		main.add(sub,c);
		
		main.setBackground(Color.CYAN);
		c.anchor = c.FIRST_LINE_START;
		c.fill = GridBagConstraints.HORIZONTAL; 
		main.setSize(750,750);
		add(main,c);
		setSize(800,800);
		setVisible(true);
		setResizable(false);
		setTitle("Registration Form");
	}
	
	public static void main(String[]args)
	{
		RegisForm rf = new RegisForm();
	}
}