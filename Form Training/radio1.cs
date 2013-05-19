using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public partial class Form1 : Form
{
    string ticketClass;
    
    public Form1()
    {
        InitializeComponent();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(ticketClass);
    }
    //this function is the function which executes when a radio button is pressed.
    private void TicketTypeChanged(object sender, EventArgs e)
    {
        RadioButton button = (RadioButton)sender; //This is taking the button radio button which sent the message
        if (button.Checked)
            ticketClass = button.Text; //Sets the ticket button's text and sets it to ticketClass
    }
    
    private void InitializeComponent(){
        this.label1 = new Label();
        this.economyRadio = new RadioButton();
        this.premiumRadio = new RadioButton();
        this.businessRadio = new RadioButton();
        this.upperRadio = new RadioButton();
        this.firstRadio = new RadioButton();
        this.okButton = new Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(168, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Choose the cabin class you require";
        // 
        // economyRadio
        // 
        this.economyRadio.AutoSize = true;
        this.economyRadio.Location = new System.Drawing.Point(46, 44);
        this.economyRadio.Name = "economyRadio";
        this.economyRadio.Size = new System.Drawing.Size(65, 17);
        this.economyRadio.TabIndex = 1;
        this.economyRadio.Text = "Economy";
        this.economyRadio.CheckedChanged += new System.EventHandler(this.TicketTypeChanged); //CheckedChanged is activate when the radiobutton is selected... like on the checkbox
        // 
        // premiumRadio
        // 
        this.premiumRadio.AutoSize = true;
        this.premiumRadio.Location = new System.Drawing.Point(46, 68);
        this.premiumRadio.Name = "premiumRadio";
        this.premiumRadio.Size = new System.Drawing.Size(108, 17);
        this.premiumRadio.TabIndex = 2;
        this.premiumRadio.Text = "Premium Economy";
        this.premiumRadio.CheckedChanged += new System.EventHandler(this.TicketTypeChanged);
        // 
        // businessRadio
        // 
        this.businessRadio.AutoSize = true;
        this.businessRadio.Location = new System.Drawing.Point(46, 92);
        this.businessRadio.Name = "businessRadio";
        this.businessRadio.Size = new System.Drawing.Size(90, 17);
        this.businessRadio.TabIndex = 3;
        this.businessRadio.Text = "Business class";
        this.businessRadio.CheckedChanged += new System.EventHandler(this.TicketTypeChanged);
        // 
        // upperRadio
        // 
        this.upperRadio.AutoSize = true;
        this.upperRadio.Location = new System.Drawing.Point(46, 115);
        this.upperRadio.Name = "upperRadio";
        this.upperRadio.Size = new System.Drawing.Size(123, 17);
        this.upperRadio.TabIndex = 4;
        this.upperRadio.Text = "Upper Business Class";
        this.upperRadio.CheckedChanged += new System.EventHandler(this.TicketTypeChanged);
        // 
        // firstRadio
        // 
        this.firstRadio.AutoSize = true;
        this.firstRadio.Location = new System.Drawing.Point(46, 139);
        this.firstRadio.Name = "firstRadio";
        this.firstRadio.Size = new System.Drawing.Size(67, 17);
        this.firstRadio.TabIndex = 5;
        this.firstRadio.Text = "First class";
        this.firstRadio.CheckedChanged += new System.EventHandler(this.TicketTypeChanged);
        // 
        // okButton
        // 
        this.okButton.Location = new System.Drawing.Point(212, 194);
        this.okButton.Name = "okButton";
        this.okButton.Size = new System.Drawing.Size(75, 23);
        this.okButton.TabIndex = 6;
        this.okButton.Text = "OK";
        this.okButton.Click += new System.EventHandler(this.okButton_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(299, 229);
        this.Controls.Add(this.okButton);
        this.Controls.Add(this.firstRadio);
        this.Controls.Add(this.upperRadio);
        this.Controls.Add(this.businessRadio);
        this.Controls.Add(this.premiumRadio);
        this.Controls.Add(this.economyRadio);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Flight Booker";
        this.ResumeLayout(false);
        this.PerformLayout();    
    }
    private Label label1;
    private RadioButton economyRadio;
    private RadioButton premiumRadio;
    private RadioButton businessRadio;
    private RadioButton upperRadio;
    private RadioButton firstRadio;
    private Button okButton;
}
/* When using VS.... the partial class Form1 contains the contents of InitializeComponents and the Windows Forms components
partial class Form1
{
    private void InitializeComponent()
    {
    }

}
*/
public class RadioButtonClickEvent
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}