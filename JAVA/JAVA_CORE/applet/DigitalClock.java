import java.util.*;
import java.text.*;
import java.awt.*;
import java.applet.*;
public class DigitalClock extends Applet implements Runnable
{
	Thread t;
	String timeString;
	public void init()
	{
		setForeground(Color.black);
		setBackground(Color.white);
	}
	public void start()
	{
		t = new Thread(this);
			t.start();
	}
	public void run()
	{
		try
		{
			while(true)
			{
				Calendar cal = Calendar.getInstance();
				
				SimpleDateFormat s = new SimpleDateFormat("hh:mm:ss");
				Date date = cal.getTime();
				timeString = s.format(date);
				
				repaint();
				t.sleep(1000);
			}
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
	public void paint(Graphics g)
	{
		g.setColor(Color.blue);
		g.drawString(timeString,50,50);
	}
}
//<applet code="DigitalClock.class" height=800 width=1000></applet>