using System;
using System.Drawing;
using System.Windows.Forms;

public class LabelTextChange : Form
{
  Label lblEcho;
  TextBox txt;

  public LabelTextChange()
  {
    Size = new Size(900,380);

    lblEcho = new Label();
    lblEcho.Parent = this;
    lblEcho.Text = "test";
    lblEcho.Location = new Point(0,0);
    lblEcho.AutoSize = true; //dynamic sizing enabled... dependent on the length of the string
    lblEcho.BorderStyle = BorderStyle.Fixed3D; //making the border 3d and making it beveled
    int yDelta = lblEcho.Height + 10;
    
    Image img = Image.FromFile("akiko04.jpg"); //creating a image class on the program
    Label lblImage = new Label(); //creates a label class
    lblImage.Parent = this;
    lblImage.Location = new Point(250, 0);
    lblImage.Image = img; //sets the img class visible
    lblImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    lblImage.Size = new Size(img.Width, img.Height);

    Label lblCaption = new Label();
    lblCaption.Parent = this;
    lblCaption.Text = "&Enter Text Here:";
    lblCaption.Size = new Size(lblCaption.PreferredWidth, lblCaption.PreferredHeight);
    lblCaption.Location = new Point(0, yDelta);
    lblCaption.BorderStyle = BorderStyle.FixedSingle;

    txt = new TextBox();
    txt.Parent = this;
    txt.Size = new Size(100,23);
    txt.Location = new Point(lblCaption.Width + 5, yDelta);
    txt.TextChanged += new System.EventHandler(txt_TextChanged); //Sets the function that will handle when the text on the textbox is changed

  }

  static void Main() 
  {
    Application.Run(new LabelTextChange());
  }

  private void txt_TextChanged(object sender, EventArgs e)
  {
    lblEcho.Text = txt.Text;
  }
}