package GUI;
import javax.swing.*;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;


public class ActionListenerInterface extends JFrame implements ActionListener
{
	JPanel jp;
	JButton jb;
	JLabel jl;
	ActionListenerInterface()
	{
		jp = new JPanel();
		jb = new JButton("click");
		jl = new JLabel("Hi");
		jp.add(jb);
		jp.add(jl);
		
		add(jp);
		setTitle("ActionListenerInterface");
		setVisible(true);
		setSize(100,100);
		
		jb.addActionListener(this);
	}
	public void actionPerformed(ActionEvent e)
	{
		jl.setText("Bye");
	}
	
	public static void main(String[]args)
	{
		ActionListenerInterface a = new ActionListenerInterface();
	}
}