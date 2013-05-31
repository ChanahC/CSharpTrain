using System.IO; 
using System.Net; 
using System; 
using System.Threading; 
using N = System.Net; 
using System.Collections; 
using System.Windows.Forms; 
using System.ComponentModel; 
using System.Runtime.InteropServices; 

class TalkUser { 
    
   static Form talk; 
   static N.Sockets.TcpClient TC; 

   [DllImport("kernel32.dll")] 
   private static extern void ExitProcess(int a); 
    
   public static void Main() { 
       talk = new Form(); 
       talk.Text = "TalkUser - The OFFICIAL TalkServ Client"; 
       talk.Closing += new CancelEventHandler(talk_Closing); 
       talk.Controls.Add(new TextBox()); 
       talk.Controls[0].Dock = DockStyle.Fill; 
       talk.Controls.Add(new TextBox()); 
       talk.Controls[1].Dock = DockStyle.Bottom; 
       ((TextBox)talk.Controls[0]).Multiline = true; 
       ((TextBox)talk.Controls[1]).Multiline = true; 
       talk.WindowState = FormWindowState.Maximized; 
       talk.Show(); 
       ((TextBox)talk.Controls[1]).KeyUp += new KeyEventHandler(key_up); 
       TC = new N.Sockets.TcpClient(); 
       TC.Connect("IP OF A SERVER HERE",4296); 
       Thread t = new Thread(new ThreadStart(run)); 
       t.Start(); 
       while(true) { 
           Application.DoEvents(); 
       } 
   } 
    
   private static void talk_Closing(object s, CancelEventArgs e) { 
       e.Cancel = false; 
       Application.Exit(); 
       ExitProcess(0); 
   } 
    
   private static void key_up(object s,KeyEventArgs e) { 
       TextBox TB = (TextBox)s; 
       if(TB.Lines.Length>1) { 
           StreamWriter SW = new StreamWriter(TC.GetStream()); 
           SW.WriteLine(TB.Text); 
           SW.Flush(); 
           TB.Text = ""; 
           TB.Lines = null; 
       } 
   } 
    
   private static void run() { 
       StreamReader SR = new StreamReader(TC.GetStream()); 
       while(true) { 
           Application.DoEvents(); 
           TextBox TB = (TextBox)talk.Controls[0]; 
           TB.AppendText(SR.ReadLine()+"\r\n"); 
           TB.SelectionStart = TB.Text.Length; 
       } 
   } 
}