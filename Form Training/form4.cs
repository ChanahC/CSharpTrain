using System; 
using System.Windows.Forms; 
 
class AddMenuForm : Form { 
  MainMenu MyMenu; 
 
  public AddMenuForm() { 
    Text = "Adding a Main Menu"; 
    MyMenu  = new MainMenu(); 
 
    MenuItem m1 = new MenuItem("File"); 
    MyMenu.MenuItems.Add(m1); 
 
    MenuItem m2 = new MenuItem("Tools"); 
    MyMenu.MenuItems.Add(m2); 
 
    MenuItem subm1 = new MenuItem("Open"); 
    m1.MenuItems.Add(subm1); 
 
    MenuItem subm2 = new MenuItem("Close"); 
    m1.MenuItems.Add(subm2); 
 
    MenuItem subm3 = new MenuItem("Exit"); 
    m1.MenuItems.Add(subm3); 
 
    MenuItem subm4 = new MenuItem("Coordinates"); 
    m2.MenuItems.Add(subm4); 
 
    MenuItem subm5 = new MenuItem("Change Size"); 
    m2.MenuItems.Add(subm5); 
 
    MenuItem subm6 = new MenuItem("Restore"); 
    m2.MenuItems.Add(subm6); 
 
 
    subm1.Click += MMOpenClick; 
    subm2.Click += MMCloseClick; 
    subm3.Click += MMExitClick; 
    subm4.Click += MMCoordClick; 
    subm5.Click += MMChangeClick; 
    subm6.Click += MMRestoreClick; 
 
    Menu = MyMenu; 
  }   
 
  [STAThread] 
  public static void Main() { 
    AddMenuForm skel = new AddMenuForm(); 
 
    Application.Run(skel); 
  } 
 
  protected void MMCoordClick(object who, EventArgs e) { 
  } 
 
  protected void MMChangeClick(object who, EventArgs e) { 
    
  } 
 
  protected void MMRestoreClick(object who, EventArgs e) { 
    
  } 
 
  protected void MMOpenClick(object who, EventArgs e) { 
 
    Console.WriteLine("MMOpenClick"); 
  } 
 
  protected void MMCloseClick(object who, EventArgs e) { 
    Console.WriteLine("MMCloseClick"); 
  } 
 
  protected void MMExitClick(object who, EventArgs e) { 
     Console.WriteLine("Exit"); 
  } 
}