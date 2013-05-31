using System.IO; 
using System.Net; 
using System; 
using System.Threading; 
using N = System.Net; 
using System.Collections; 

class TalkServ { 
    
   System.Net.Sockets.TcpListener server; 
   public static Hashtable handles; 
   public static Hashtable handleByConnect; 
    
   public static void Main() { 
       TalkServ TS = new TalkServ(); 
   } 

   public TalkServ() { 
       handles = new Hashtable(100); 
       handleByConnect = new Hashtable(100); 
       server = new System.Net.Sockets.TcpListener(4296); 
       while(true) { 
           server.Start(); 
           if(server.Pending()) { 
               N.Sockets.TcpClient connection = server.AcceptTcpClient(); 
               Console.WriteLine("Connection made"); 
               BackForth BF = new BackForth(connection);             
           } 
       } 
   } 
    
   public static void SendToAll(string name,string msg) { 
       StreamWriter SW; 
       ArrayList ToRemove = new ArrayList(0); 
       N.Sockets.TcpClient[] tc = new N.Sockets.TcpClient[TalkServ.handles.Count];
       TalkServ.handles.Values.CopyTo(tc,0); 
       for(int i=0;i<tc.Length;i++) { 
           try { 
           if(msg.Trim()==""||tc[i]==null) 
               continue; 
           SW = new StreamWriter(tc[i].GetStream()); 
           SW.WriteLine(name + ": " + msg); 
           SW.Flush(); 
           SW = null; 
           } catch(Exception e) { 
               //e = e; 
               string g = (string) TalkServ.handleByConnect[tc[i]]; 
               TalkServ.SendSysMsg("** " + g + " ** HAS LEFT US."); 
               TalkServ.handles.Remove(g); 
               TalkServ.handleByConnect.Remove(tc[i]); 
           } 
       } 
   } 

   public static void SendSysMsg(string msg) { 
       StreamWriter SW; 
       ArrayList ToRemove = new ArrayList(0); 
       N.Sockets.TcpClient[] tc = new N.Sockets.TcpClient[TalkServ.handles.Count];
       TalkServ.handles.Values.CopyTo(tc,0); 
       for(int i=0;i<tc.Length;i++) { 
           try { 
           if(msg.Trim()==""||tc[i]==null) 
               continue; 
           SW = new StreamWriter(tc[i].GetStream()); 
           SW.WriteLine(msg); 
           SW.Flush(); 
           SW = null; 
           } catch(Exception e) { 
               //e44 = e44; 
               TalkServ.handles.Remove(TalkServ.handleByConnect[tc[i]]); 
               TalkServ.handleByConnect.Remove(tc[i]); 
           } 
       } 
   } 
}//end of class TalkServ 

class BackForth { 
   N.Sockets.TcpClient client; 
   System.IO.StreamReader SR; 
   System.IO.StreamWriter SW; 
   string handle; 
    
   public BackForth(System.Net.Sockets.TcpClient c) { 
       client = c; 
       Thread t = new Thread(new ThreadStart(init)); 
       t.Start(); 
   } 
    
   private string GetHandle() { 
       SW.WriteLine("What is your handle? "); 
       SW.Flush(); 
       return SR.ReadLine(); 
   } 
    
   private void run() { 
       try { 
       string l = ""; 
       while(true) { 
           l = SR.ReadLine(); 
           TalkServ.SendToAll(handle,l); 
       } 
       } catch(Exception e44) { Console.WriteLine(e44); } 
   } 
    
   private void init() { 
       SR = new System.IO.StreamReader(client.GetStream()); 
       SW = new System.IO.StreamWriter(client.GetStream()); 
       SW.WriteLine("WELCOME TO TalkServ! Be Nice!"); 
       //SW.WriteLine("What is your handle? "); 
       //SW.Flush(); 
       handle = GetHandle(); 
       while(TalkServ.handles.Contains(handle)) { 
           SW.WriteLine("ERR - Handle already exists!"); 
           handle = GetHandle(); 
       } 
       TalkServ.handles.Add(handle,client); 
       TalkServ.handleByConnect.Add(client,handle); 
       TalkServ.SendSysMsg("** " + handle + " ** HAS JOINED US."); 
       SW.WriteLine("Now Talking.....\r\n-------------------------------"); 
       SW.Flush(); 
       Thread t = new Thread(new ThreadStart(run)); 
       t.Start(); 
   } 
}