import java.applet.Applet;
import java.awt.*;
public class AppletLifeCyle1 extends Applet
{
	public AppletLifeCyle1()
	{
		System.out.println("Constructor():");
	}
	public void init()
	{
		setBackground(Color.black);
		setForeground(Color.red);
		System.out.println("1.init():");
	}
	public void start()
	{
		System.out.println("2.start():");
	}
	public void paint(Graphics g)
	{
		System.out.println("3.paint():");
		g.drawString("Hello world",0,50);
	}
	public void stop()
	{
		System.out.println("4.stop():");
	}
	public void destroy()
	{
		System.out.println("5.destroy():");
	}
}
/*
	<applet code="AppletLifeCyle1.class" width=300 height=300></applet>
*/