
package GUI;
import javax.swing.*;
import java.awt.event.MouseMotionListener;
import java.awt.event.MouseEvent;


public class MouseMotionListenerInterface extends JFrame implements MouseMotionListener
{
	JPanel jp;
	int x,y;
	JLabel jl,jl1;
	MouseMotionListenerInterface()
	{
		jp = new JPanel();
		jl = new JLabel();
		jl1 = new JLabel("Hi");
		jp.add(jl);
		jp.add(jl1);
		
		add(jp);
		setTitle("MouseMotionListenerInterface");
		setVisible(true);
		setSize(100,100);
		
		this.addMouseMotionListener(this);
	}
	public void mouseDragged(MouseEvent me)
	{
		jl1.setText("Position of Cursor is "+x+" X "+y);
	}
	public void mouseMoved(MouseEvent me)
	{
		x = me.getX();
		y = me.getY();
		jl.setText("Position of Cursor is "+x+" X "+y);
	}
	
	public static void main(String[]args)
	{
		MouseMotionListenerInterface a = new MouseMotionListenerInterface();
	}
}