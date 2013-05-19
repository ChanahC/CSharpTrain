using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;


   public class SimpleEditorForm : Form
   {
      private string fileName = "Untitled";

      private string[] lines;
      private int linesPrinted;

      public SimpleEditorForm()
      {
         InitializeComponent();

         if (fileName != null)
         {
            this.fileName = "fileName";
            OpenFile();
         }        

      }

      private void OpenFile()
      {
         try
         {
            textBoxEdit.Clear();
            textBoxEdit.Text = File.ReadAllText(fileName);
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Simple Editor",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }
      private void OnFileNew(object sender, EventArgs e)
      {
         fileName = "Untitled";
         SetFormTitle();
         textBoxEdit.Clear();

      }

      private void OnFileOpen(object sender, EventArgs e)
      {
         if (dlgOpenFile.ShowDialog() == DialogResult.OK)
         {
            fileName = dlgOpenFile.FileName;
            SetFormTitle();
            OpenFile();
         }

      }

      private void SaveFile()
      {
         try
         {
            File.WriteAllText(fileName, textBoxEdit.Text);
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Simple Editor",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void OnFileSave(object sender, EventArgs e)
      {
         if (fileName == "Untitled")
         {
            OnFileSaveAs(sender, e);
         }
         else
         {
            SaveFile();
         }

      }

      private void SetFormTitle()
      {
         FileInfo fileInfo = new FileInfo(fileName);
         Text = fileInfo.Name + " - Simple Editor";
      }

      private void OnFileSaveAs(object sender, EventArgs e)
      {
         if (dlgSaveFile.ShowDialog() == DialogResult.OK)
         {
            fileName = dlgSaveFile.FileName;
            SetFormTitle();
            SaveFile();
         }

      }

      private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
      {
         int x = e.MarginBounds.Left;
         int y = e.MarginBounds.Top;

         while (linesPrinted < lines.Length)
         {
            e.Graphics.DrawString(lines[linesPrinted++],new Font("Arial", 10), Brushes.Black, x, y);
            y += 25;
            if (y >= e.MarginBounds.Bottom)
            {
               e.HasMorePages = true;
               return;
            }
         }
         linesPrinted = 0;
         e.HasMorePages = false;
      }

      private void OnFilePrint(object sender, EventArgs e)
      {
         try
         {
            if (textBoxEdit.SelectedText != "")
            {
               dlgPrint.AllowSelection = true;
            }

            if (dlgPrint.ShowDialog() == DialogResult.OK)
            {
               printDocument.Print();
            }
         }
         catch (InvalidPrinterException ex)
         {
            MessageBox.Show(ex.Message, "Simple Editor",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void OnBeginPrint(object sender, PrintEventArgs e)
      {
         char[] param = { '\n' };

         if (dlgPrint.PrinterSettings.PrintRange == PrintRange.Selection)
         {
            lines = textBoxEdit.SelectedText.Split(param);
         }
         else
         {
            lines = textBoxEdit.Text.Split(param);
         }

         int i = 0;
         char[] trimParam = { '\r' };
         foreach (string s in lines)
         {
            lines[i++] = s.TrimEnd(trimParam);
         }

      }

      private void OnEndPrint(object sender, PrintEventArgs e)
      {
         lines = null;
      }

      private void OnFilePageSetup(object sender, EventArgs e)
      {
         dlgPageSetup.ShowDialog();
      }

      private void OnFilePrintPreview(object sender, EventArgs e)
      {
         dlgPrintPreview.ShowDialog();
      }

      private void InitializeComponent()
      {
         this.textBoxEdit = new System.Windows.Forms.TextBox();
         this.mainMenu = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
         this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.printDocument = new System.Drawing.Printing.PrintDocument();
         this.dlgPageSetup = new System.Windows.Forms.PageSetupDialog();
         this.dlgPrint = new System.Windows.Forms.PrintDialog();
         this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
         this.printPreviewControl = new System.Windows.Forms.PrintPreviewControl();
         this.mainMenu.SuspendLayout();
         this.SuspendLayout();

         this.textBoxEdit.AcceptsReturn = true;
         this.textBoxEdit.AcceptsTab = true;
         this.textBoxEdit.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBoxEdit.Location = new System.Drawing.Point(0, 24);
         this.textBoxEdit.Multiline = true;
         this.textBoxEdit.Name = "textBoxEdit";
         this.textBoxEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBoxEdit.Size = new System.Drawing.Size(546, 203);

         this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
         this.mainMenu.Location = new System.Drawing.Point(0, 0);
         this.mainMenu.Size = new System.Drawing.Size(546, 24);
         this.mainMenu.Text = "menuStrip1";
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         this.newToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.newToolStripMenuItem.Text = "&New";
         this.newToolStripMenuItem.Click += new System.EventHandler(this.OnFileNew);
         // 
         this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.openToolStripMenuItem.Text = "&Open...";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.OnFileOpen);
         // 
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.saveToolStripMenuItem.Text = "&Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnFileSave);
         // 
         this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.saveAsToolStripMenuItem.Text = "Save &As...";
         this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnFileSaveAs);
         // 
         // dlgOpenFile
         // 
         this.dlgOpenFile.Filter = "Text Documents (*.txt)|*.txt|Wrox Documents (*.wroxtext)|*.wroxtext|All Files|*.*";
         // 
         // dlgSaveFile
         // 
         this.dlgSaveFile.FileName = "Untitled";
         this.dlgSaveFile.Filter = "Text Document (*.txt)|*.txt|Wrox Document (*.wroxtext)|*.wroxtext";
         this.dlgSaveFile.FilterIndex = 2;
         // 
         this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
         // 
         this.printToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.printToolStripMenuItem.Text = "&Print...";
         this.printToolStripMenuItem.Click += new System.EventHandler(this.OnFilePrint);
         // 
         // printPreviewToolStripMenuItem
         // 
         this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
         this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.printPreviewToolStripMenuItem.Text = "Print Pre&view...";
         this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.OnFilePrintPreview);
         // 
         // pageSetupToolStripMenuItem
         // 
         this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
         this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.pageSetupToolStripMenuItem.Text = "Page Set&up...";
         this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.OnFilePageSetup);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         // 
         // printDocument
         // 
         this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OnPrintPage);
         this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.OnEndPrint);
         this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.OnBeginPrint);
         // 
         // dlgPageSetup
         // 
         this.dlgPageSetup.Document = this.printDocument;
         this.dlgPageSetup.ShowHelp = true;
         // 
         // dlgPrint
         // 
         this.dlgPrint.Document = this.printDocument;
         this.dlgPrint.UseEXDialog = true;
         // 
         // dlgPrintPreview
         // 
         this.dlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.dlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.dlgPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
         this.dlgPrintPreview.Document = this.printDocument;
         this.dlgPrintPreview.Enabled = true;
         this.dlgPrintPreview.Name = "dlgPrintPreview";
         this.dlgPrintPreview.Visible = false;
         // 
         // printPreviewControl
         // 
         this.printPreviewControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.printPreviewControl.Document = this.printDocument;
         this.printPreviewControl.Location = new System.Drawing.Point(0, 24);
         this.printPreviewControl.Name = "printPreviewControl";
         this.printPreviewControl.Size = new System.Drawing.Size(546, 203);
         this.printPreviewControl.TabIndex = 2;
         this.printPreviewControl.Visible = false;
         // 
         // SimpleEditorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(546, 227);
         this.Controls.Add(this.printPreviewControl);
         this.Controls.Add(this.textBoxEdit);
         this.Controls.Add(this.mainMenu);
         this.MainMenuStrip = this.mainMenu;
         this.Name = "SimpleEditorForm";
         this.Text = "Simple Editor";
         this.mainMenu.ResumeLayout(false);
         this.mainMenu.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      private System.Windows.Forms.TextBox textBoxEdit;
      private System.Windows.Forms.MenuStrip mainMenu;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
      private System.Windows.Forms.OpenFileDialog dlgOpenFile;
      private System.Windows.Forms.SaveFileDialog dlgSaveFile;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Drawing.Printing.PrintDocument printDocument;
      private System.Windows.Forms.PageSetupDialog dlgPageSetup;
      private System.Windows.Forms.PrintDialog dlgPrint;
      private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
      private System.Windows.Forms.PrintPreviewControl printPreviewControl;
      [STAThread]
      static void Main(string[] args)
      {
         
         Application.Run(new SimpleEditorForm());
      }
   }