using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//This contains all the event handlers for a form window
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
        Console.WriteLine("Activated");
    }

    private void Form1_AutoSizeChanged(object sender, EventArgs e)
    {
        Console.WriteLine("Autosizechanged");
       
    }

    private void Form1_AutoValidateChanged(object sender, EventArgs e)
    {
        Console.WriteLine("AutoValidateChanged");
    }

    private void Form1_BackColorChanged(object sender, EventArgs e)
    {
        Console.WriteLine("BackColorChanged");
    }

    private void Form1_BackgroundImageChanged(object sender, EventArgs e)
    {
        Console.WriteLine("BackgroundImageChanged");

    }

    private void Form1_BackgroundImageLayoutChanged(object sender, EventArgs e)
    {
        Console.WriteLine("BackgroundImageLayoutChanged");
    }

    private void Form1_BindingContextChanged(object sender, EventArgs e)
    {
        Console.WriteLine("BindingContextChanged");
    }

    private void Form1_CausesValidationChanged(object sender, EventArgs e)
    {
        Console.WriteLine("CausesValidationChanged");
    }

    private void Form1_ChangeUICues(object sender, UICuesEventArgs e)
    {
        Console.WriteLine("ChangeUICues");
    }

    private void Form1_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Click");
    }

    private void Form1_ContextMenuStripChanged(object sender, EventArgs e)
    {
        Console.WriteLine("ContextMenuStripChanged");
    }

    private void Form1_ControlAdded(object sender, ControlEventArgs e)
    {
        Console.WriteLine("ControlAdded");
    }

    private void Form1_ControlRemoved(object sender, ControlEventArgs e)
    {
        Console.WriteLine("ControlRemoved");
    }

    private void Form1_CursorChanged(object sender, EventArgs e)
    {
        Console.WriteLine("CursorChanged");
    }

    private void Form1_Deactivate(object sender, EventArgs e)
    {
        Console.WriteLine("Deactivate");
    }

    private void Form1_DockChanged(object sender, EventArgs e)
    {
        Console.WriteLine("DockChanged");

    }

    private void Form1_DoubleClick(object sender, EventArgs e)
    {
        Console.WriteLine("DoubleClick");
    }

    private void Form1_DragDrop(object sender, DragEventArgs e)
    {
        Console.WriteLine("DragDrop");
     
    }

    private void Form1_DragEnter(object sender, DragEventArgs e)
    {
        Console.WriteLine("DragEnter");
    }

    private void Form1_DragLeave(object sender, EventArgs e)
    {
        Console.WriteLine("DragLeave");
    }

    private void Form1_DragOver(object sender, DragEventArgs e)
    {
        Console.WriteLine("DragOver");
    }

    private void Form1_EnabledChanged(object sender, EventArgs e)
    {
        Console.WriteLine("EnabledChanged");
    }

    private void Form1_Enter(object sender, EventArgs e)
    {
        Console.WriteLine("Enter");
    }

    private void Form1_FontChanged(object sender, EventArgs e)
    {
        Console.WriteLine("FontChanged");
    }

    private void Form1_ForeColorChanged(object sender, EventArgs e)
    {
        Console.WriteLine("ForeColorChanged");
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Console.WriteLine("FormClosed");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Console.WriteLine("FormClosing");
    }

    private void Form1_GiveFeedback(object sender, GiveFeedbackEventArgs e)
    {
        Console.WriteLine("GiveFeedback");
    }

    private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
    {
        Console.WriteLine("HelpButtonClicked");
    }

    private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
    {
        Console.WriteLine("HelpRequested");
    }

    private void Form1_ImeModeChanged(object sender, EventArgs e)
    {
        Console.WriteLine("ImeModeChanged");
    }

    private void Form1_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
    {
        Console.WriteLine("InputLanguageChanged");
    }

    private void Form1_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
    {
        Console.WriteLine("InputLanguageChanging");
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        Console.WriteLine("KeyDown");
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
        Console.WriteLine("KeyPress");
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
        Console.WriteLine("KeyUp");
    }

    private void Form1_Layout(object sender, LayoutEventArgs e)
    {
        Console.WriteLine("Layout");
    }

    private void Form1_Leave(object sender, EventArgs e)
    {
        Console.WriteLine("Leave");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Console.WriteLine("Load");
    }

    private void Form1_LocationChanged(object sender, EventArgs e)
    {
        Console.WriteLine("LocationChanged");
    }

    private void Form1_MarginChanged(object sender, EventArgs e)
    {
        Console.WriteLine("MarginChanged");
    }

    private void Form1_MaximizedBoundsChanged(object sender, EventArgs e)
    {
        Console.WriteLine("MaximizedBoundsChanged");
    }

    private void Form1_MaximumSizeChanged(object sender, EventArgs e)
    {
        Console.WriteLine("MAximumSizeChanged");
    }

    private void Form1_MdiChildActivate(object sender, EventArgs e)
    {
        Console.WriteLine("MdiChildActivate");
    }

    private void Form1_MenuComplete(object sender, EventArgs e)
    {
        Console.WriteLine("MenuComplete");
    }

    private void Form1_MenuStart(object sender, EventArgs e)
    {
        Console.WriteLine("MenuStart");
    }

    private void Form1_MinimumSizeChanged(object sender, EventArgs e)
    {
        Console.WriteLine("MinimumSizeChanged");
    }

    private void Form1_MouseCaptureChanged(object sender, EventArgs e)
    {
        Console.WriteLine("MouseCaptureChanged");
    }

    private void Form1_MouseClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("MouseClick");
    }

    private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        Console.WriteLine("MouseDoubleClick");
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        Console.WriteLine("MouseDown");
    }

    private void Form1_MouseEnter(object sender, EventArgs e)
    {
        Console.WriteLine("MouseEnter");
    }

    private void Form1_MouseHover(object sender, EventArgs e)
    {
        Console.WriteLine("MouseHover");
    }

    private void Form1_MouseLeave(object sender, EventArgs e)
    {
        Console.WriteLine("MouseLeave");
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        Console.WriteLine("MouseMove");
    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        Console.WriteLine("MouseUp");
    }

    private void Form1_Move(object sender, EventArgs e)
    {
        Console.WriteLine("Move");
    }

    private void Form1_PaddingChanged(object sender, EventArgs e)
    {
        Console.WriteLine("PaddingChanged");
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        Console.WriteLine("Paint");
    }

    private void Form1_ParentChanged(object sender, EventArgs e)
    {
        Console.WriteLine("ParentChanged");
    }

    private void Form1_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
    {
        Console.WriteLine("QueryAccessibilityHelp");
    }

    private void Form1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
    {
        Console.WriteLine("QueryContinueDrag");
    }

    private void Form1_RegionChanged(object sender, EventArgs e)
    {
        Console.WriteLine("RegionChanged");
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
        Console.WriteLine("Resize");
    }

    private void Form1_ResizeBegin(object sender, EventArgs e)
    {
        Console.WriteLine("ResizeBegin");
    }

    private void Form1_ResizeEnd(object sender, EventArgs e)
    {
        Console.WriteLine("ResizeEnd");
    }

    private void Form1_RightToLeftChanged(object sender, EventArgs e)
    {
        Console.WriteLine("RightToLeftChanged");
    }

    private void Form1_RightToLeftLayoutChanged(object sender, EventArgs e)
    {
        Console.WriteLine("RightToLeftLayoutChanged");
    }

    private void Form1_Scroll(object sender, ScrollEventArgs e)
    {
        Console.WriteLine("Scroll");

    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        Console.WriteLine("Shown");
    }

    private void Form1_SizeChanged(object sender, EventArgs e)
    {
        Console.WriteLine("SizeChanged");
    }

    private void Form1_StyleChanged(object sender, EventArgs e)
    {
        Console.WriteLine("StyleChanged");
    }

    private void Form1_SystemColorsChanged(object sender, EventArgs e)
    {
        Console.WriteLine("SystemColorsChanged");
    }

    private void Form1_TextChanged(object sender, EventArgs e)
    {
        Console.WriteLine("TextChanged");
    }

    private void Form1_Validated(object sender, EventArgs e)
    {
        Console.WriteLine("Validated");
    }

    private void Form1_Validating(object sender, CancelEventArgs e)
    {
        Console.WriteLine("Validating");
    }

    private void Form1_VisibleChanged(object sender, EventArgs e)
    {
        Console.WriteLine("VisibleChanged");
    }
}
partial class Form1
{
    private void InitializeComponent()
    {
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(87, 79);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 0;
        this.button1.Text = "button1";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(292, 266);
        this.Controls.Add(this.button1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.CursorChanged += new System.EventHandler(this.Form1_CursorChanged);
        this.RightToLeftLayoutChanged += new System.EventHandler(this.Form1_RightToLeftLayoutChanged);
        this.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.Form1_QueryContinueDrag);
        this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
        this.Load += new System.EventHandler(this.Form1_Load);
        this.BackgroundImageLayoutChanged += new System.EventHandler(this.Form1_BackgroundImageLayoutChanged);
        this.RightToLeftChanged += new System.EventHandler(this.Form1_RightToLeftChanged);
        this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
        this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Form1_InputLanguageChanged);
        this.Validating += new System.ComponentModel.CancelEventHandler(this.Form1_Validating);
        this.BackgroundImageChanged += new System.EventHandler(this.Form1_BackgroundImageChanged);
        this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
        this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
        this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Form1_ControlAdded);
        this.FontChanged += new System.EventHandler(this.Form1_FontChanged);
        this.MaximizedBoundsChanged += new System.EventHandler(this.Form1_MaximizedBoundsChanged);
        this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
        this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
        this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
        this.BindingContextChanged += new System.EventHandler(this.Form1_BindingContextChanged);
        this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
        this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
        this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
        this.ContextMenuStripChanged += new System.EventHandler(this.Form1_ContextMenuStripChanged);
        this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
        this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
        this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
        this.Validated += new System.EventHandler(this.Form1_Validated);
        this.ParentChanged += new System.EventHandler(this.Form1_ParentChanged);
        this.Resize += new System.EventHandler(this.Form1_Resize);
        this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Form1_ControlRemoved);
        this.Shown += new System.EventHandler(this.Form1_Shown);
        this.AutoValidateChanged += new System.EventHandler(this.Form1_AutoValidateChanged);
        this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
        this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
        this.Activated += new System.EventHandler(this.Form1_Activated);
        this.Enter += new System.EventHandler(this.Form1_Enter);
        this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
        this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
        this.StyleChanged += new System.EventHandler(this.Form1_StyleChanged);
        this.ForeColorChanged += new System.EventHandler(this.Form1_ForeColorChanged);
        this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
        this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
        this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
        this.Leave += new System.EventHandler(this.Form1_Leave);
        this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
        this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
        this.Move += new System.EventHandler(this.Form1_Move);
        this.MouseCaptureChanged += new System.EventHandler(this.Form1_MouseCaptureChanged);
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
        this.PaddingChanged += new System.EventHandler(this.Form1_PaddingChanged);
        this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
        this.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.Form1_ChangeUICues);
        this.DockChanged += new System.EventHandler(this.Form1_DockChanged);
        this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.Form1_GiveFeedback);
        this.ImeModeChanged += new System.EventHandler(this.Form1_ImeModeChanged);
        this.Click += new System.EventHandler(this.Form1_Click);
        this.SystemColorsChanged += new System.EventHandler(this.Form1_SystemColorsChanged);
        this.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.Form1_QueryAccessibilityHelp);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        this.RegionChanged += new System.EventHandler(this.Form1_RegionChanged);
        this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
        this.MarginChanged += new System.EventHandler(this.Form1_MarginChanged);
        this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
        this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
        this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
        this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        this.BackColorChanged += new System.EventHandler(this.Form1_BackColorChanged);
        this.InputLanguageChanging += new System.Windows.Forms.InputLanguageChangingEventHandler(this.Form1_InputLanguageChanging);
        this.MenuStart += new System.EventHandler(this.Form1_MenuStart);
        this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
        this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
        this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
        this.CausesValidationChanged += new System.EventHandler(this.Form1_CausesValidationChanged);
        this.MenuComplete += new System.EventHandler(this.Form1_MenuComplete);
        this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
        this.ResumeLayout(false);

    }

    private System.Windows.Forms.Button button1;
}
public class FormEventAll
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
        MessageBox.Show("Click OK to finish");
    }
}