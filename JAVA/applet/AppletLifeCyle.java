import java.applet.Applet;
import java.awt.Graphics;
public class AppletLifeCyle extends Applet
{
	/*
		<applet code="AppletLifeCyle.class" width=300 height=300></applet>
	*/
	public void init()
	{
		System.out.println("1.init():");
	}
	public void start()
	{
		System.out.println("2.start():");
	}
	public void paint(Graphics g)
	{
		System.out.println("3.paint():");
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