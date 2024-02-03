package GUI;
import javax.swing.*;

public class JTabbedPaneEx extends JFrame
{
	JTabbedPane jt;
	public JTabbedPaneEx()
	{
		jt= new JTabbedPane(JTabbedPane.LEFT);
		jt.addTab("tab1",null);
		jt.addTab("tab2",null);
		jt.addTab("tab3",null);
		jt.addTab("tab4",null);
		jt.setSize(500,500);
		
		add(jt);
		setTitle("JTabbedPane");
		setSize(600,600);
		setVisible(true);
	}
	public static void main(String[]args)
	{
		JTabbedPaneEx jtp = new JTabbedPaneEx();
	}
}