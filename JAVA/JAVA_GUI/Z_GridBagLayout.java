package GUI;
import java.awt.Color;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import javax.swing.JButton;
import javax.swing.JFrame;

public class Z_GridBagLayout extends JFrame
{
	JButton red, blue, green;
	
	public Z_GridBagLayout()
	{
		red = new JButton("Red");
		blue = new JButton("Blue");
		green = new JButton("Green");
		setBackground(new Color(0,0,255));
		setVisible(true);
		setSize(500,500);
		setTitle("GridBagLayout Demo");
		setLayout(new GridBagLayout());
		GridBagConstraints c = new GridBagConstraints();
		c.gridx = 0;
		c.gridy = 0;
		add(red,c);
		red.setBackground(new Color(255,0,0));
		c.gridx = 0;
		c.gridy = 1;
		add(blue, c);
		c.gridx = 0;
		c.gridy = 2;
		add(green, c);
	}
	public static void main(String[] args)
	{
		Z_GridBagLayout obj = new Z_GridBagLayout();
	}
}