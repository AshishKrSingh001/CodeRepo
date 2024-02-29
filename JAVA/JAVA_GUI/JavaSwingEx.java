package GUI;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.FlowLayout;

public class JavaSwingEx extends JFrame
{
	JPanel panel1;
	JButton button1;
	JLabel label1,imgLabel1;
	JTextField textfield1;
	JTextArea textarea1;
	JavaSwingEx()
	{
		panel1 = new JPanel();
		
		label1 = new JLabel("Enter your name : ");
		//label1.setBounds(100,100,50,50);
		panel1.add(label1);
		
		
		textfield1 = new JTextField("Name",16);
		//textField1.setBounds(100,100,50,50);
		panel1.add(textfield1);
		
		textarea1 = new JTextArea(10,20);
		//textArea1.setBounds(100,100,50,50);
		panel1.add(textarea1);
		
		
		button1 = new JButton("Submit");
		
		panel1.add(button1);
		ImageIcon i = new ImageIcon(new ImageIcon("img1.jpg").getImage().getScaledInstance(300,300,Image.SCALE_SMOOTH));
		imgLabel1 = new JLabel(i);
		//imgLabel1.setBounds(100,100,50,50);
		imgLabel1.setVisible(false);
		panel1.add(imgLabel1);
		
		button1.addActionListener(new ActionListener(){
		public void actionPerformed(ActionEvent e)
		{
				textfield1.setText("Ashish Kumar Singh");
				imgLabel1.setVisible(true);
		}});
		
		add(panel1);
		setVisible(true);
		setTitle("JavaSwingEx");
		setSize(500,700);
		setLayout(new FlowLayout());
	}
	public static void main(String []args)
	{
		JavaSwingEx jws = new JavaSwingEx();
	}
}