package GUI;
import java.awt.Font;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JLabel;

class Menu extends JFrame
{
	JButton option1;
	JButton option2;
	JButton option3;
	JLabel name;
	JPanel jp;
	public Menu()
	{
		jp = new JPanel();
		jp.setSize(200,200);
		option1 = new JButton("Play Game");
		option2 = new JButton("View Instructions");
		option3 = new JButton("Exit");
		name = new JLabel("HANGMAN");
		name.setFont(new Font("Serif", Font.PLAIN, 24));
		setTitle("Hangman Game");
		setSize(300,200);
		//setResizable(false);
		setVisible(true);
	}
	public void addComponent()
	{
		setLayout(new GridBagLayout());
		GridBagConstraints c = new GridBagConstraints();
		c.gridx = 0;
		c.gridy = 0;
		c.weighty =1;
		c.anchor = c.CENTER;
		jp.add(name,c);
		c.gridx = 0;
		c.gridy = 1;
		c.fill = c.HORIZONTAL;
		jp.add(option1, c);
		c.gridx = 0;
		c.gridy = 2;
		c.fill = c.HORIZONTAL;
		jp.add(option2, c);
		c.gridx = 0;
		c.gridy = 3;
		c.fill = c.HORIZONTAL;
		jp.add(option3, c);
		add(jp);
	}
	public static void main(String []str)
	{
		Menu m=new Menu();
		m.addComponent();
	}
}