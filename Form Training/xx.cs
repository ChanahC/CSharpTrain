using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public class ChildPrototypeForm : Form {
    public ChildPrototypeForm() {
        InitializeComponent();
    }

    private void ChildPrototypeForm_Click(object sender, EventArgs e) {
        int r, g, b;
        Random ran = new Random();
        r = ran.Next(0, 255);
        g = ran.Next(0, 255);
        b = ran.Next(0, 255);

        Color currColor = Color.FromArgb(r, g, b);
        this.BackColor = currColor;
        this.Text = currColor.ToString();
    }
    private void InitializeComponent() {
        this.Click += new System.EventHandler(this.ChildPrototypeForm_Click);
    }
}

public class MainWindow : Form {
    public MainWindow() {
         InitializeComponent();
    }
    private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.Cascade); }

    private void verticalToolStripMenuItem_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileVertical); }

    private void horizontalToolStripMenuItem_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileHorizontal); }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }
    //inits a MDI on the window
    private void newToolStripMenuItem_Click(object sender, EventArgs e) {
        ChildPrototypeForm newChild = new ChildPrototypeForm();
        newChild.MdiParent = this; //Sets the MDI parent as the current item which is the main window
        newChild.Show(); //shows the MDI window
    }

    private void InitializeComponent() {
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.arrangeWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.windowToolStripMenuItem,
            this.arrangeWindowsToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(440, 24);
        this.menuStrip1.TabIndex = 2;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem1
        // 
        this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
        this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
        this.fileToolStripMenuItem1.Text = "&File";
        // 
        // newToolStripMenuItem
        // 
        this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        this.newToolStripMenuItem.Text = "&New";
        this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
        // 
        // exitToolStripMenuItem
        // 
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Text = "E&xit";
        this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        // 
        // windowToolStripMenuItem
        // 
        this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
        this.windowToolStripMenuItem.Text = "&Window";
        // 
        // arrangeWindowsToolStripMenuItem
        // 
        this.arrangeWindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
        this.arrangeWindowsToolStripMenuItem.Name = "arrangeWindowsToolStripMenuItem";
        this.arrangeWindowsToolStripMenuItem.Text = "&Arrange Windows";
        // 
        // cascadeToolStripMenuItem
        // 
        this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
        this.cascadeToolStripMenuItem.Text = "&Cascade";
        this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
        // 
        // verticalToolStripMenuItem
        // 
        this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
        this.verticalToolStripMenuItem.Text = "&Vertical";
        this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
        // 
        // horizontalToolStripMenuItem
        // 
        this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
        this.horizontalToolStripMenuItem.Text = "&Horizontal";
        this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
        // 
        // MainWindow
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(440, 238);
        this.Controls.Add(this.menuStrip1);
        this.IsMdiContainer = true;
        this.Name = "MainWindow";
        this.Text = "My Mdi Application";
        this.menuStrip1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }



    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem arrangeWindowsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;

    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.Run(new MainWindow());
    }
}