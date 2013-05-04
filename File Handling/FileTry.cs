using System;
using System.Windows.Forms;
using System.IO;

//Not functioning

namespace QuickSharp
{
    public class FileTry
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            OpenFileDialog dlgOpen = new OpenFileDialog();
            Console.WriteLine("Dumaan na dito!");
            dlgOpen.ShowDialog();
            Console.WriteLine("Ito na ulit!");
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
              string s = dlgOpen.FileName;
              Console.WriteLine("Filename " + s);
              Console.WriteLine(" Created at " + File.GetCreationTime(s));
              Console.WriteLine(" Accessed at " + File.GetLastAccessTime(s));
            }
        }
    }
}