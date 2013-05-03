using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuickSharp
{
    public class ApplicationStart : System.Windows.Forms.Form //extends Windows.Forms.Form which is basically the presentation of a frame
    {
        public ApplicationStart(){
            Application.ApplicationExit += new EventHandler(Exit_Form);
            /*
                The part above specifies the function to be called which should be a event handler.
                When the user presses the exit button, the event handler function is executed
            */
        }
        
        private static void Main()
        {
            Console.WriteLine("Location: " + Application.StartupPath); //Prints the location of the file!
            Console.WriteLine("Company Name: " + Application.CompanyName); //Prints the name of the company who owns the software/ the software that compiled the code
            Console.WriteLine("Product Name: " + Application.ProductName); //Prints the product name of the form
            Application.Run(new ApplicationStart()); //The application is initiated.
        }
        
        private void Exit_Form(object sender, EventArgs evArgs){
            Console.WriteLine("Bakit mo pinatay!");
        }
        
    }
}