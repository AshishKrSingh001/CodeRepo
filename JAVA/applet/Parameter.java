import java.awt.*;
import java.applet.*;
/*
	<applet code="Parameter.class" height=800 width=1000></applet>
		<param name="fontName" value="Comic Sans MS">
		<param name="fontSize" value="40">
		<param name="leadingFontName" value="14.80">
		<param name="active" value="true">
*/	
public class Parameter extends Applet
{
	String fontName;
	String param;
	int fontSize;
	float leading;
	boolean active;
	public void init()
	{
		//Param is not used here because to get the string value and again to pass to strng , no temp var is needed
		fontName = getParameter("fontName");
		if(fontName==null)
		{
			fontName = "Not spcified";
		}
		param = getParameter("fontSize");
		try
		{
			if(param!=null)
			{
				fontSize = Integer.parseInt(param);
			}
			else
			{
				fontSize = 0;
			}
		}
		catch(NumberFormatException e)
		{
			fontSize = 1;
		}
		param = getParameter("leading");
		try
		{
			if(param!=null)
			{
				leading = Float.valueOf(param).floatValue();
			}
			else
			{
				leading = 0f;
			}
		}
		catch(NumberFormatException e)
		{
			leading = 1;
		}
		param = getParameter("active");
		if(param!=null)
		{
			active = Boolean.valueOf(param).booleanValue();
		}
	}
	public void paint(Graphics g)
	{
		g.drawString("Font name: "+fontName,100,50);
		g.drawString("Font size: "+fontSize,100,60);
		g.drawString("Leading: "+leading,100,70);
		g.drawString("Active: "+active,100,80);
	}
}