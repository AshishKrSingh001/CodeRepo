package GUI;
import javax.swing.*;

public class JRadioButtonEx extends JFrame
{
	JPanel jp;
	JRadioButton male,female,other;
	ButtonGroup bg;
	public JRadioButtonEx()
	{
		jp = new JPanel();
		bg = new ButtonGroup();
		
		male = new JRadioButton("Male");
		female = new JRadioButton("Female");
		
		ImageIcon icon = new ImageIcon(new ImageIcon("C:\\Users\\ashis\\OneDrive\\Pictures\\Dark-Wallpaper-01-2560-x-1569.jpg").getImage().getScaledInstance(20,20,4));
		other = new JRadioButton(icon);

		bg.add(male);
		bg.add(female);
		bg.add(other);
		
		jp.add(male);
		jp.add(female);
		jp.add(other);
		
		add(jp);
		setTitle("JRadioButton");
		setSize(600,600);
		setVisible(true);
	}
	public static void main(String[]args)
	{
		JRadioButtonEx jr = new JRadioButtonEx();
	}
}
