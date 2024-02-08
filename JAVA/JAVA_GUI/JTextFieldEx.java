package GUI;
import javax.swing.*;

public class JTextFieldEx extends JFrame
{
	JPanel jp;
	JLabel jl1,jl2;
	JTextField jt1,jt2;
	public JTextFieldEx()
	{
		jp = new JPanel();
		
		jl1 = new JLabel("First Name: ");
		jl2 = new JLabel("Last Name: ");
		
		jt1 = new JTextField(10);
		jt2 = new JTextField(10);
		
		jp.add(jl1);
		jp.add(jt1);
		jp.add(jl2);
		jp.add(jt2);
		
		add(jp);
		setTitle("JTextField");
		setSize(600,600);
		setVisible(true);
	}
	public static void main(String[]args)
	{
		JTextFieldEx jt = new JTextFieldEx();
	}
}