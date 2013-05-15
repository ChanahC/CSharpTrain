using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

public class ScrollForm : System.Windows.Forms.Form
{
  private System.Windows.Forms.Label label1;
  private System.ComponentModel.Container components = null;

  public ScrollForm()
  {
    InitializeComponent();
  }
  protected override void Dispose( bool disposing )
  {
    if( disposing )
    {
      if (components != null) 
      {
        components.Dispose();
      }
    }
    base.Dispose( disposing );
  }

  private void InitializeComponent()
  {
    this.label1 = new System.Windows.Forms.Label();
    this.SuspendLayout();

    this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
    this.label1.Location = new System.Drawing.Point(16, 16);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(376, 224);
    this.label1.TabIndex = 0;
    this.label1.Text = "Scrollbars of course!";

    this.AutoScaleBaseSize = new System.Drawing.Size(5, 13); //Gets or sets the base size used for autoscaling of the form.
    this.AutoScroll = true; //Gets or sets a value indicating whether the container enables the user to scroll to any controls placed outside of its visible boundaries.
    this.AutoScrollMinSize = new System.Drawing.Size(300, 300); //Minimum size for the sroll to be visible
    this.ClientSize = new System.Drawing.Size(350, 100); // sets the size of the window
    this.Controls.Add(this.label1);
    this.Name = "Scroll Form";
    this.Text = "Scroll Form";
    this.ResumeLayout(false);

  }

  [STAThread]
  static void Main() 
  {
    Application.Run(new ScrollForm());
  }
}