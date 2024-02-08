package GUI;
import javax.swing.*;

public class JMenuEx extends JFrame
{
	JMenuBar jmb;
	JMenu jm1;
	JMenu jm2;
	JMenu jm3;
	public JMenuEx()
	{
		jmb = new JMenuBar();
		jm1 = new JMenu("File");
		jm2 = new JMenu("Edit");
		jm3 = new JMenu("View");
		jmb.add(jm1);
		jmb.add(jm2);
		jmb.add(jm3);
		
		
		add(jmb);
		setSize(600,200);
		setVisible(true);
		setTitle("JMenuBar");
	}
	public static void main(String[]args)
	{
		JMenuEx jmb = new JMenuEx();
	}
}