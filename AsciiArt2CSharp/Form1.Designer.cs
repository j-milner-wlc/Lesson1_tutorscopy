namespace AsciiArt2CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOriginalAsciiArt = new System.Windows.Forms.GroupBox();
            this.textBoxOrigAsciiArt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGeneratedCSharpCode = new System.Windows.Forms.TextBox();
            this.groupBoxOriginalAsciiArt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOriginalAsciiArt
            // 
            this.groupBoxOriginalAsciiArt.Controls.Add(this.button1);
            this.groupBoxOriginalAsciiArt.Controls.Add(this.comboBox1);
            this.groupBoxOriginalAsciiArt.Controls.Add(this.textBoxOrigAsciiArt);
            this.groupBoxOriginalAsciiArt.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOriginalAsciiArt.Name = "groupBoxOriginalAsciiArt";
            this.groupBoxOriginalAsciiArt.Size = new System.Drawing.Size(600, 291);
            this.groupBoxOriginalAsciiArt.TabIndex = 0;
            this.groupBoxOriginalAsciiArt.TabStop = false;
            this.groupBoxOriginalAsciiArt.Text = "Copy and Paste Original Ascii Art Here";
            // 
            // textBoxOrigAsciiArt
            // 
            this.textBoxOrigAsciiArt.AcceptsReturn = true;
            this.textBoxOrigAsciiArt.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxOrigAsciiArt.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrigAsciiArt.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxOrigAsciiArt.Location = new System.Drawing.Point(7, 20);
            this.textBoxOrigAsciiArt.Multiline = true;
            this.textBoxOrigAsciiArt.Name = "textBoxOrigAsciiArt";
            this.textBoxOrigAsciiArt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOrigAsciiArt.Size = new System.Drawing.Size(585, 234);
            this.textBoxOrigAsciiArt.TabIndex = 0;
            this.textBoxOrigAsciiArt.Text = "12345678901234567890123456789012345678901234567890123456789012345678901234567890";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Choose Colour"});
            this.comboBox1.Location = new System.Drawing.Point(7, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate C# Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGeneratedCSharpCode);
            this.groupBox1.Location = new System.Drawing.Point(13, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generated C# Code";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // textBoxGeneratedCSharpCode
            // 
            this.textBoxGeneratedCSharpCode.HideSelection = false;
            this.textBoxGeneratedCSharpCode.Location = new System.Drawing.Point(7, 19);
            this.textBoxGeneratedCSharpCode.Multiline = true;
            this.textBoxGeneratedCSharpCode.Name = "textBoxGeneratedCSharpCode";
            this.textBoxGeneratedCSharpCode.ReadOnly = true;
            this.textBoxGeneratedCSharpCode.Size = new System.Drawing.Size(579, 197);
            this.textBoxGeneratedCSharpCode.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOriginalAsciiArt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOriginalAsciiArt.ResumeLayout(false);
            this.groupBoxOriginalAsciiArt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOriginalAsciiArt;
        private System.Windows.Forms.TextBox textBoxOrigAsciiArt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxGeneratedCSharpCode;
    }
}

