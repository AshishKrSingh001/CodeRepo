package GUI;
import javax.swing.*;

public class JOptionPaneEx extends JFrame
{
	public JOptionPaneEx()
	{
		setVisible(true);
		setSize(600,600);
		JOptionPane.showConfirmDialog(this,"Do you want to save it?","confirmation message",JOptionPane.YES_NO_CANCEL_OPTION,JOptionPane.WARNING_MESSAGE);
	}
	public static void main(String[]args)
	{
		JOptionPaneEx jop = new JOptionPaneEx();
	}
}