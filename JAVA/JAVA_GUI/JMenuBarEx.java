package GUI;
import javax.swing.*;

public class JMenuBarEx extends JFrame
{
	JMenuBar jmb;
	public JMenuBarEx()
	{
		jmb = new JMenuBar();
		add(jmb);
		setSize(600,600);
		setVisible(true);
		setTitle("JMenuBar");
	}
	public static void main(String[]args)
	{
		JMenuBarEx jmb = new JMenuBarEx();
	}
}