using System;
using System.Drawing;
using System.Windows.Forms;

public class ButtonEvent : Form
{
  Button btn1;
  Button btn2;

  public ButtonEvent()
  {
        Size = new Size(200,100);

    btn1 = new Button();
    btn1.Parent = this;
    btn1.Text = "Button1";
    btn1.Location = new Point(10,10);
    btn1.Click += new System.EventHandler(btn1_Click);

    btn2 = new Button();
    btn2.Parent = this;
    btn2.Text = "Button2";
    btn2.Location = new Point(100,10);
    btn2.Click += new System.EventHandler(btn2_Click);
  }

  static void Main() 
  {
    Application.Run(new ButtonEvent());
  }

  private void btn1_Click(object sender, EventArgs e)
  {
    MessageBox.Show("Button1 clicked.");
    btn2.PerformClick(); //also clicks other buttons
  }

  private void btn2_Click(object sender, EventArgs e)
  {
    MessageBox.Show("Button2 clicked.");
  }
}