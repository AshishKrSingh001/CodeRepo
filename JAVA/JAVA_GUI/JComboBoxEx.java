package GUI;
import javax.swing.*;
public class JComboBoxEx extends JFrame
{
	JPanel jp;
	JComboBox city;
	public JComboBoxEx()
	{
			jp = new JPanel();
			city = new JComboBox();
			city.addItem("California");
			city.addItem("Florida");
			city.addItem("Montanan");
			city.addItem("New York");
			city.addItem("Oklahoma");
			jp.add(city);
			setTitle("JComboBox Demo");
			setVisible(true);
			setSize(300,200);
			add(jp);
	}
	
	public static void main(String[]args)
	{
		JComboBoxEx jc = new JComboBoxEx();
		
	}
}