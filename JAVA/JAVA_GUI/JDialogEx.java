package GUI;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JDialog;

public class JDialogEx extends JFrame
{
	JPanel jp;
	JDialog jd;
	public JDialogEx()
	{
		jp = new JPanel();
		jd = new JDialog();
		
		add(jp);
		setTitle("JDialog");
		setSize(900,900);
		setVisible(true);
		
		jp.add(jd);
		
		
	}
	public static void main(String[]args)
	{
		JDialogEx jd = new JDialogEx();
	}
}