using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

public partial class ComboBoxHolder : Form
{
    public ComboBoxHolder()
    {
        this.SuspendLayout();

        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(292, 266);
        this.Name = "ComboBoxHolder";
        this.Text = "Combo Box Holder";
        this.ResumeLayout(false);


    }
    //overrides the OnLoad function which is basically called when the ComboHolder is called
    protected override void OnLoad(EventArgs e)
    {
        //having the OnLoad of the base function copied
        base.OnLoad(e);
        AutoCompleteComboBox combo = new AutoCompleteComboBox();
        combo.Location = new Point(10, 10);
        //setting the combo box as a control for the form
        this.Controls.Add(combo);
        //adds item to the combo box
        combo.Items.Add("word");
        combo.Items.Add("world");
        combo.Items.Add("wording");
        combo.Items.Add("worse");
        
    }

    [STAThread]
    public static void Main(string[] args)
    {
        Application.Run(new ComboBoxHolder());
    }
}

public class AutoCompleteComboBox : ComboBox
{
    private bool controlKey = false;

    protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
    {
        base.OnKeyPress(e);

        if (e.KeyChar == (int)Keys.Escape)
        {
            this.SelectedIndex = -1;
            this.Text = "";
            controlKey = true;
        } else if (Char.IsControl(e.KeyChar)) {
            controlKey = true;
        } else {
            controlKey = false;
        }
    }
    //Overrides the innate function inside the combobox class which reacts when somethin is typed
    protected override void OnTextChanged(System.EventArgs e)
    {
        base.OnTextChanged(e);

        if (this.Text != "" && !controlKey)
        {
            string matchText = this.Text;
            int match = this.FindString(matchText);

            if (match != -1)
            {
                this.SelectedIndex = match;
                this.SelectionStart = matchText.Length;
                this.SelectionLength = this.Text.Length - this.SelectionStart;
            }
        }
    }
}