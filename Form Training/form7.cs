using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

public class FormClosingEventCancle : System.Windows.Forms.Form
{
  private System.ComponentModel.Container components = null;

  public FormClosingEventCancle()
  {
    InitializeComponent();

    this.Closing += new System.ComponentModel.CancelEventHandler(this.FormClosingEventCancle_Closing);
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
    this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
    this.ClientSize = new System.Drawing.Size(280, 177);

  }
  [STAThread]
  static void Main() 
  {
    Application.Run(new FormClosingEventCancle());
  }

  private void FormClosingEventCancle_Closing(object sender, System.ComponentModel.CancelEventArgs e)
  {
    DialogResult dr = MessageBox.Show("Do you REALLY want to close this app?",
      "Closing event!", MessageBoxButtons.YesNo); //Creating a dialog result from an input with choices yes or no.
    if(dr == DialogResult.No)
      e.Cancel = true;
    else
      e.Cancel = false;    //event canceller.
  }
}