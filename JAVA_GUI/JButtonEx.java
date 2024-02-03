package GUI;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JButton;

public class JButtonEx extends JFrame
{ 
	JPanel jp;
	JButton jb;
	public JButtonEx()
	{
		jp = new JPanel();
		jb = new JButton("Submit");
		
		add(jp);
		setTitle("JButton");
		setVisible(true);
		setSize(600,500);
		
		
		jp.add(jb);
		
	}
	public static void main(String []args)
	{
		JButtonEx jb = new JButtonEx();
	}
}