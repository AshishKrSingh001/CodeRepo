package GUI;
import javax.swing.JFrame;
import java.awt.FlowLayout;
public class JFrameEx extends JFrame
{ 
	public JFrameEx()
	{
		setTitle("JFrameEx");
		setVisible(true);
		setSize(600,500);
		setLayout(new FlowLayout());
	}
	public static void main(String []args)
	{
		JFrameEx jb = new JFrameEx();
	}
}