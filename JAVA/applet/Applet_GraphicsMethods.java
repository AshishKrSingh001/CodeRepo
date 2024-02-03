import java.applet.Applet;
import java.awt.*;
/*
	<applet code="Applet_GraphicsMethods.class" width=1000 height=1000></applet>
*/
public class Applet_GraphicsMethods extends Applet
{
	public Applet_GraphicsMethods()
	{
		System.out.println("constructor():");
	}
	public void init()
	{
		setBackground(Color.red);
		setForeground(Color.cyan);
		System.out.println("init():");
	}
	public void start()
	{
		System.out.println("start():");
	}
	public void paint(Graphics gr)
	{
		System.out.println("paint():");
		gr.drawString("My name is Ashish Kumar Singh",50,50);
		gr.drawLine(50,90,950,90);
		gr.drawRect(50,100,400,500);
		gr.fillRect(50,100,400,500);
		gr.drawOval(500,100,400,500);
		gr.fillOval(500,100,400,500);
		gr.drawLine(50,610,950,610);
		gr.drawArc(50,620,500,300,60,60);
		gr.fillArc(50,620,500,300,60,60);
		gr.drawLine(50,930,950,930);
	}
	public void stop()
	{
		System.out.println("stop():");
	}
	public void destroy()
	{
		System.out.println("destroy():");
	}
}