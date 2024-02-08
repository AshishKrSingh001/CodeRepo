package GUI;
import javax.swing.*;
import java.awt.*; 

public class JLabelEx extends JFrame
{
	JPanel jp;
	JLabel jl1,jl2,jl3;
	public JLabelEx()
	{
		jp = new JPanel();
		
		jl1 = new JLabel("First Name: ");
		jl2 = new JLabel("Last Name: ");
		
		ImageIcon icon = new ImageIcon(new ImageIcon("C:\\Users\\ashis\\OneDrive\\Pictures\\Dark-Wallpaper-01-2560-x-1569.jpg").getImage().getScaledInstance(30,30,Image.SCALE_SMOOTH));
		jl3 = new JLabel(icon);
		
		jp.add(jl1);
		jp.add(jl3);
		jp.add(jl2);
		//jp.setTitle("JPanel");
		
		add(jp);
		setTitle("JLabel");
		setSize(600,600);
		setVisible(true);
	}
	public static void main(String[]args)
	{
		JLabelEx jlabel = new JLabelEx();
	}
}
