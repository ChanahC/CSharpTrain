using System;
using System.Windows.Forms;

public class EmptyForm : Form //extends the class form
{
  public EmptyForm() //constructor
  {
    InitializeComponents();
  }
  //proper manner of doing the GUI is chopping the initialization of components
  public void InitializeComponents(){
    this.Size = new System.Drawing.Size(300,300); // Sets the size.
    this.Text = "My First Window"; //initializes the text on the header of the program to be "My First Window"    
  }
  
  public static int Main()
  {
    Application.Run(new EmptyForm()); //initializes a application with class empty form
    return 0; // returns 0 is the form is closed.
  }       
}