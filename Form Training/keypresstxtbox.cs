using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

class Form1 : Form {
    public Form1() {
        InitializeComponent();
        this.buttonOK.Enabled = false;

        this.textBoxAddress.Tag = false;
        this.textBoxAge.Tag = false;
        this.textBoxName.Tag = false;

        this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
        this.textBoxAddress.Validating += new
               System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
        this.textBoxAge.Validating += new
               System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
        this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
        this.textBoxAddress.TextChanged += new
                                        System.EventHandler(this.textBox_TextChanged);
        this.textBoxAge.TextChanged += new System.EventHandler(this.textBox_TextChanged);
    }

    private void buttonOK_Click(object sender, EventArgs e) {
        this.textBoxOutput.Text = "clicked";
    }

    private void buttonHelp_Click(object sender, EventArgs e) {
        this.textBoxOutput.Text = "text";
    }

    private void textBoxEmpty_Validating(object sender,
                                    System.ComponentModel.CancelEventArgs e) {
        TextBox tb = (TextBox)sender;
        if (tb.Text.Length == 0) {
            tb.BackColor = Color.Red;
            tb.Tag = false;
        } else {
            tb.BackColor = System.Drawing.SystemColors.Window;
            tb.Tag = true;
        }
        ValidateOK();
    }

    private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e) {
        if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            e.Handled = true; // Remove the character
    }

    private void textBox_TextChanged(object sender, System.EventArgs e) {
        TextBox tb = (TextBox)sender;

        if (tb.Text.Length == 0) {
            tb.Tag = false;
            tb.BackColor = Color.Red;
        } else {
            tb.Tag = true;
            tb.BackColor = SystemColors.Window;
        }
        ValidateOK();
    }

    private void ValidateOK() {
        this.buttonOK.Enabled = ((bool)(this.textBoxAddress.Tag) &&
                                (bool)(this.textBoxAge.Tag) &&
                                (bool)(this.textBoxName.Tag));
    }

    private void InitializeComponent() {
        this.labelName = new System.Windows.Forms.Label();
        this.labelAddress = new System.Windows.Forms.Label();
        this.textBoxName = new System.Windows.Forms.TextBox();
        this.textBoxAddress = new System.Windows.Forms.TextBox();
        this.labelOutput = new System.Windows.Forms.Label();
        this.buttonOK = new System.Windows.Forms.Button();
        this.buttonHelp = new System.Windows.Forms.Button();
        this.labelAge = new System.Windows.Forms.Label();
        this.textBoxAge = new System.Windows.Forms.TextBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.radioButtonMale = new System.Windows.Forms.RadioButton();
        this.radioButtonFemale = new System.Windows.Forms.RadioButton();
        this.checkBoxProgrammer = new System.Windows.Forms.CheckBox();
        this.textBoxOutput = new System.Windows.Forms.TextBox();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();

        this.labelName.AutoSize = true;
        this.labelName.Location = new System.Drawing.Point(13, 16);
        this.labelName.Name = "labelName";
        this.labelName.Size = new System.Drawing.Size(34, 14);
        this.labelName.TabIndex = 0;
        this.labelName.Text = "Name";

        this.labelAddress.AutoSize = true;
        this.labelAddress.Location = new System.Drawing.Point(13, 43);
        this.labelAddress.Name = "labelAddress";
        this.labelAddress.Size = new System.Drawing.Size(46, 14);
        this.labelAddress.TabIndex = 1;
        this.labelAddress.Text = "Address";

        this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.textBoxName.Location = new System.Drawing.Point(106, 13);
        this.textBoxName.Name = "textBoxName";
        this.textBoxName.Size = new System.Drawing.Size(225, 20);
        this.textBoxName.TabIndex = 2;

        this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.textBoxAddress.AutoSize = false;
        this.textBoxAddress.Location = new System.Drawing.Point(106, 40);
        this.textBoxAddress.Multiline = true;
        this.textBoxAddress.Name = "textBoxAddress";
        this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBoxAddress.Size = new System.Drawing.Size(225, 80);
        this.textBoxAddress.TabIndex = 3;

        this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.labelOutput.AutoSize = true;
        this.labelOutput.Location = new System.Drawing.Point(13, 233);
        this.labelOutput.Name = "labelOutput";
        this.labelOutput.Size = new System.Drawing.Size(38, 14);
        this.labelOutput.TabIndex = 6;
        this.labelOutput.Text = "Output";

        this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.buttonOK.Location = new System.Drawing.Point(338, 13);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.TabIndex = 8;
        this.buttonOK.Text = "OK";
        this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);

        this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.buttonHelp.CausesValidation = false;
        this.buttonHelp.Location = new System.Drawing.Point(338, 43);
        this.buttonHelp.Name = "buttonHelp";
        this.buttonHelp.TabIndex = 9;
        this.buttonHelp.Text = "Help";
        this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

        this.labelAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.labelAge.AutoSize = true;
        this.labelAge.Location = new System.Drawing.Point(13, 212);
        this.labelAge.Name = "labelAge";
        this.labelAge.Size = new System.Drawing.Size(24, 14);
        this.labelAge.TabIndex = 10;
        this.labelAge.Text = "Age";

        this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.textBoxAge.Location = new System.Drawing.Point(106, 209);
        this.textBoxAge.MaxLength = 3;
        this.textBoxAge.Name = "textBoxAge";
        this.textBoxAge.TabIndex = 11;
        this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);

        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox1.Controls.Add(this.radioButtonMale);
        this.groupBox1.Controls.Add(this.radioButtonFemale);
        this.groupBox1.Location = new System.Drawing.Point(13, 152);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(318, 50);
        this.groupBox1.TabIndex = 12;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Sex";

        this.radioButtonMale.AutoSize = true;
        this.radioButtonMale.Location = new System.Drawing.Point(182, 20);
        this.radioButtonMale.Name = "radioButtonMale";
        this.radioButtonMale.Size = new System.Drawing.Size(44, 17);
        this.radioButtonMale.TabIndex = 1;
        this.radioButtonMale.Text = "Male";

        this.radioButtonFemale.AutoSize = true;
        this.radioButtonFemale.Checked = true;
        this.radioButtonFemale.Location = new System.Drawing.Point(44, 20);
        this.radioButtonFemale.Name = "radioButtonFemale";
        this.radioButtonFemale.Size = new System.Drawing.Size(55, 17);
        this.radioButtonFemale.TabIndex = 0;
        this.radioButtonFemale.Text = "Female";

        this.checkBoxProgrammer.AutoSize = true;
        this.checkBoxProgrammer.Checked = true;
        this.checkBoxProgrammer.CheckState = System.Windows.Forms.CheckState.Checked;
        this.checkBoxProgrammer.Location = new System.Drawing.Point(13, 128);
        this.checkBoxProgrammer.Name = "checkBoxProgrammer";
        this.checkBoxProgrammer.Size = new System.Drawing.Size(78, 17);
        this.checkBoxProgrammer.TabIndex = 13;
        this.checkBoxProgrammer.Text = "Programmer";

        this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.textBoxOutput.AutoSize = false;
        this.textBoxOutput.Location = new System.Drawing.Point(13, 254);
        this.textBoxOutput.Multiline = true;
        this.textBoxOutput.Name = "textBoxOutput";
        this.textBoxOutput.ReadOnly = true;
        this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBoxOutput.Size = new System.Drawing.Size(318, 116);
        this.textBoxOutput.TabIndex = 14;

        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(422, 382);
        this.Controls.Add(this.textBoxOutput);
        this.Controls.Add(this.checkBoxProgrammer);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.textBoxAge);
        this.Controls.Add(this.labelAge);
        this.Controls.Add(this.buttonHelp);
        this.Controls.Add(this.buttonOK);
        this.Controls.Add(this.labelOutput);
        this.Controls.Add(this.textBoxAddress);
        this.Controls.Add(this.textBoxName);
        this.Controls.Add(this.labelAddress);
        this.Controls.Add(this.labelName);
        this.MinimumSize = new System.Drawing.Size(430, 328);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }



    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelAddress;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.TextBox textBoxAddress;
    private System.Windows.Forms.Label labelOutput;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonHelp;
    private System.Windows.Forms.Label labelAge;
    private System.Windows.Forms.TextBox textBoxAge;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButtonFemale;
    private System.Windows.Forms.RadioButton radioButtonMale;
    private System.Windows.Forms.CheckBox checkBoxProgrammer;
    private System.Windows.Forms.TextBox textBoxOutput;

    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }

}