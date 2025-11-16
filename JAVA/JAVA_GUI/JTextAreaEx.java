package GUI;
import javax.swing.*;

public class JTextAreaEx extends JFrame
{
	JPanel jp;
	JLabel jl1;
	JTextArea ja;
	public JTextAreaEx()
	{
		jp = new JPanel();
		
		
		jl1 = new JLabel("Story: ");
		ja = new JTextArea(5,10);
		
		jp.add(jl1);
		jp.add(ja);
		add(jp);
		setTitle("JTextArea");
		setSize(600,600);
		setVisible(true);
	}
	public static void main(String[]args)
	{
		JTextAreaEx j = new JTextAreaEx();
	}
}