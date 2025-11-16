package GUI;
import javax.swing.*;

public class JMenuItemEx extends JFrame
{
	JPanel jp;
	JMenuBar jmb;
	JMenu jm1;
	JMenu jm2;
	JMenu jm3;
	
	JMenuItem jmt1,jmt2,jmt3,jmt4,jmt5,jmt6,jmt7,jmt8;
	public JMenuItemEx()
	{
		jp = new JPanel();
		jmb = new JMenuBar();
		
		jmt1 = new JMenuItem("New");
		jmt2 = new JMenuItem("Open");
		jmt3 = new JMenuItem("Copy");
		jmt4 = new JMenuItem("Paste");
		jmt5 = new JMenuItem("close");
		jmt6 = new JMenuItem("save");
		jmt7 = new JMenuItem("Theme");
		jmt8 = new JMenuItem("Export");
		
		jm1 = new JMenu("File");
		jm1.add(jmt1);
		jm1.add(jmt2);
		jm1.add(jmt3);
		jm1.add(jmt4);
		
		jm2 = new JMenu("Edit");
		jm2.add(jmt5);
		jm2.add(jmt6);
		jm2.add(jmt7);

		
		jm3 = new JMenu("View");
		jm3.add(jmt8);
		
		jmb.add(jm1);
		jmb.add(jm2);
		jmb.add(jm3);
		
		jp.add(jmb);
		add(jp);
		setSize(600,600);
		setVisible(true);
		setTitle("JMenuBar");
	}
	public static void main(String[]args)
	{
		JMenuItemEx jmb = new JMenuItemEx();
	}
}