package GUI;
import javax.swing.*;

public class NullLayout extends JFrame
{
	JLabel lblName,lblPass,lblAdd;
	JTextField txtName,txtPass,txtAdd;
	public NullLayout()
	{
		//setDefaultCloseOperation(EXIT.CLOSE);
		
		lblName = new JLabel("Name: ");
		lblName.setBounds(20,20,80,50);
		add(lblName);
		
		txtName = new JTextField();
		txtName.setBounds(80,20,80,50);
		add(txtName);
		
		lblPass = new JLabel("Address: ");
		lblPass.setBounds(20,35,80,50);
		add(lblPass);
		

		setSize(500,500);
		setLayout(null);
		setVisible(true);
		setTitle("NullLayout");
	}
	public static void main(String[]args)
	{
		NullLayout n = new NullLayout();
	}
}