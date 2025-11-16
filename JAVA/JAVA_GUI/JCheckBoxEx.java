package GUI;
import javax.swing.*;

public class JCheckBoxEx extends JFrame
{
	JPanel jp;
	JCheckBox music,dance,cricket,football,other;
	public JCheckBoxEx()
	{
		jp = new JPanel();
		music = new JCheckBox("Music");
		dance = new JCheckBox("Dance");
		cricket = new JCheckBox("Cricket");
		football = new JCheckBox("Football");
		
		ImageIcon icon = new ImageIcon(new ImageIcon("C:\\Users\\ashis\\OneDrive\\Pictures\\Dark-Wallpaper-01-2560-x-1569.jpg").getImage().getScaledInstance(20,20,4));
		other = new JCheckBox(icon);
		
		jp.add(music);
		jp.add(dance);
		jp.add(cricket);
		jp.add(football);
		add(other);
		
		add(jp);
		setTitle("JCheckBox");
		setSize(600,600);
		setVisible(true);
	}
	public static void main(String[]args)
	{
		JCheckBoxEx jc = new JCheckBoxEx();
	}
}
