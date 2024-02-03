import java.awt.*;
import java.applet.*;
import java.io.*;
import java.util.*;
/*
	<Applet code="MovingText.class" width=1200 height=800></applet>
*/
public class MovingText extends Applet implements Runnable
{
	private String display;
	private int x,y,flag;
	Thread t;
	public void init()
	{
		display = "Hello World";
		x = 100;
		y = 100;
		flag = 1;
		
		t = new Thread(this,"Mythread");
		t.start();
	}
	public void update()
	{
		Random r = new Random();
		int n = r.nextInt(10);
		x = x + 10 * n * flag;
		if(x > 1100)
		{
			flag = -1;
		}
		if(x < 10)
		{
			flag = 1;
		}
		y = y + 10 * n * flag;
		if(y > 700)
		{
			flag = -1;
		}
		if(y < 10)
		{
			flag = 1;
		}
	}
	public void run()
	{
		while(true)
		{
			repaint();
			
			update();
			
			try
			{
				t.sleep(800);
			}
			catch(Exception e)
			{
				System.out.println(e);
			}
		}
	}
	public void paint(Graphics g)
	{
		g.drawString(display,x,y);
	}
}