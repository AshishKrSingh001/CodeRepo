import java.awt.*;
import java.applet.*;
// <applet code="Bike.class" height=500 width=500></applet>
public class Bike extends Applet
{
	Image img;
	public void init()
	{
		img = getImage(getDocumentBase(),"bike.jpeg");
	}
	public void paint(Graphics g)
	{
		for(int i=0;i<500;i++)
		{
			g.drawImage(img,i,50,this);
			try
			{
				Thread.sleep(10);
			}
			catch(Exception e)
			{
				System.out.println(e);
			}
		}		
	}
}