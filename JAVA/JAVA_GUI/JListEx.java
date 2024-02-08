package GUI;
import javax.swing.*;
public class JListEx extends JFrame
{
	JPanel jp;
	DefaultListModel dlist;
	JList list;
	public JListEx()
	{
		jp = new JPanel();
		add(jp);
		setTitle("JListEx");
		setVisible(true);
		setSize(800,800);
		
		list = new JList();
		list.setSelectedIndex(0);
		dlist = new DefaultListModel();
		dlist.addElement("Delhi");
		dlist.addElement("Patna");
		dlist.addElement("Kolkatta");
		dlist.addElement("Banglore");
		dlist.addElement("Mumbai");
		
		list.setModel(dlist);
		jp.add(list);
	}
	public static void main(String[]args)
	{
		JListEx jl = new JListEx();
	}
}