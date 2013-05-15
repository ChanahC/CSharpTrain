using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_MouseEnter(object sender, EventArgs e)
    {
        button1.Text = "The mouse is over me";
    }

    private void button1_MouseLeave(object sender, EventArgs e)
    {
        button1.Text = "The mouse is not over me";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Button clickedButton = sender as Button;
        if (clickedButton != null)
        {
            clickedButton.Text = "I was clicked";
        }
    }
}
partial class Form1
{
    private void InitializeComponent()
    {
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(86, 89);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(172, 86);
        this.button1.TabIndex = 0;
        this.button1.Text = "button1";
        this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave); //for mouse leave
        this.button1.Click += new System.EventHandler(this.button1_Click); // for click
        this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter); //for the mouse enter on the button's area
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(69, 25);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(75, 23);
        this.button2.TabIndex = 1;
        this.button2.Text = "button2";
        // 
        // Form1
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
        this.ClientSize = new System.Drawing.Size(292, 266);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.ResumeLayout(false);

    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
}
public class ButtonMouseEvent
{
    [STAThread]
    static void Main()
    {
        Application.Run(new Form1());
    }
}