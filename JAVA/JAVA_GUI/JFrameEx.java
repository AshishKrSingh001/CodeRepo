package GUI;
import javax.swing.JFrame;
public class JFrameEx extends JFrame
{ 
	public JFrameEx()
	{
		setTitle("JButton");
		setVisible(true);
		setSize(600,500);
	}
	public static void main(String []args)
	{
		JFrameEx jb = new JFrameEx();
	}
}