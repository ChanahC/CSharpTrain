using System; 
using System.Windows.Forms; 
using System.Drawing; 
 
class FormExit : Form { 
  Button StopButton; 
 
  public FormExit() { 
    Text = "Adding a Stop Button"; 
 
    StopButton = new Button(); 
    StopButton.Text = "Stop"; 
    StopButton.Location = new Point(100, 100); 
 
    StopButton.Click += StopButtonClick;  //this sets the action to be executed when StopButton is clicked. it should be a  protected functions so that no one
    //could override the function.
    Controls.Add(StopButton); //controls is a special class on forms
  }   
 
  [STAThread] 
  public static void Main() { 
    FormExit skel = new FormExit(); 
 
    Application.Run(skel); 
  } 
 
  protected void StopButtonClick(object who, EventArgs e) {
     MessageBox.Show("Bakit mo pinatay!"); // messagebox is like the messagedialog of java
     Application.Exit(); 
  } 
}