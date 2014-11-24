namespace BCAMO
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
            this.convertfrom = new System.Windows.Forms.MenuStrip();
            this.convertFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.convertto = new System.Windows.Forms.MenuStrip();
            this.convertIntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.octalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hexadecimalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.convertbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.convertfrom.SuspendLayout();
            this.convertto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // convertfrom
            // 
            this.convertfrom.Dock = System.Windows.Forms.DockStyle.None;
            this.convertfrom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertFromToolStripMenuItem});
            this.convertfrom.Location = new System.Drawing.Point(9, 32);
            this.convertfrom.Name = "convertfrom";
            this.convertfrom.Size = new System.Drawing.Size(109, 24);
            this.convertfrom.TabIndex = 0;
            this.convertfrom.Text = "menuStrip1";
            // 
            // convertFromToolStripMenuItem
            // 
            this.convertFromToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.octalToolStripMenuItem,
            this.decimalToolStripMenuItem,
            this.hexadecimalToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.convertFromToolStripMenuItem.Name = "convertFromToolStripMenuItem";
            this.convertFromToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.convertFromToolStripMenuItem.Text = "Convert From : ";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // octalToolStripMenuItem
            // 
            this.octalToolStripMenuItem.Name = "octalToolStripMenuItem";
            this.octalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.octalToolStripMenuItem.Text = "Octal";
            this.octalToolStripMenuItem.Click += new System.EventHandler(this.octalToolStripMenuItem_Click);
            // 
            // decimalToolStripMenuItem
            // 
            this.decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
            this.decimalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decimalToolStripMenuItem.Text = "Decimal";
            this.decimalToolStripMenuItem.Click += new System.EventHandler(this.decimalToolStripMenuItem_Click);
            // 
            // hexadecimalToolStripMenuItem
            // 
            this.hexadecimalToolStripMenuItem.Name = "hexadecimalToolStripMenuItem";
            this.hexadecimalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hexadecimalToolStripMenuItem.Text = "Hexadecimal";
            this.hexadecimalToolStripMenuItem.Click += new System.EventHandler(this.hexadecimalToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 1;
            // 
            // convertto
            // 
            this.convertto.Dock = System.Windows.Forms.DockStyle.None;
            this.convertto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertIntoToolStripMenuItem});
            this.convertto.Location = new System.Drawing.Point(9, 59);
            this.convertto.Name = "convertto";
            this.convertto.Size = new System.Drawing.Size(102, 24);
            this.convertto.TabIndex = 2;
            this.convertto.Text = "menuStrip1";
            // 
            // convertIntoToolStripMenuItem
            // 
            this.convertIntoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem1,
            this.octalToolStripMenuItem1,
            this.decimalToolStripMenuItem1,
            this.hexadecimalToolStripMenuItem1,
            this.otherToolStripMenuItem1});
            this.convertIntoToolStripMenuItem.Name = "convertIntoToolStripMenuItem";
            this.convertIntoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.convertIntoToolStripMenuItem.Text = "Convert Into : ";
            // 
            // binaryToolStripMenuItem1
            // 
            this.binaryToolStripMenuItem1.Name = "binaryToolStripMenuItem1";
            this.binaryToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.binaryToolStripMenuItem1.Text = "Binary";
            this.binaryToolStripMenuItem1.Click += new System.EventHandler(this.binaryToolStripMenuItem1_Click);
            // 
            // octalToolStripMenuItem1
            // 
            this.octalToolStripMenuItem1.Name = "octalToolStripMenuItem1";
            this.octalToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.octalToolStripMenuItem1.Text = "Octal";
            this.octalToolStripMenuItem1.Click += new System.EventHandler(this.octalToolStripMenuItem1_Click);
            // 
            // decimalToolStripMenuItem1
            // 
            this.decimalToolStripMenuItem1.Name = "decimalToolStripMenuItem1";
            this.decimalToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.decimalToolStripMenuItem1.Text = "Decimal";
            this.decimalToolStripMenuItem1.Click += new System.EventHandler(this.decimalToolStripMenuItem1_Click);
            // 
            // hexadecimalToolStripMenuItem1
            // 
            this.hexadecimalToolStripMenuItem1.Name = "hexadecimalToolStripMenuItem1";
            this.hexadecimalToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.hexadecimalToolStripMenuItem1.Text = "Hexadecimal";
            this.hexadecimalToolStripMenuItem1.Click += new System.EventHandler(this.hexadecimalToolStripMenuItem1_Click);
            // 
            // otherToolStripMenuItem1
            // 
            this.otherToolStripMenuItem1.Name = "otherToolStripMenuItem1";
            this.otherToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem1.Text = "Other";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 20);
            this.textBox2.TabIndex = 3;
            // 
            // convertbutton
            // 
            this.convertbutton.Location = new System.Drawing.Point(447, 59);
            this.convertbutton.Name = "convertbutton";
            this.convertbutton.Size = new System.Drawing.Size(75, 23);
            this.convertbutton.TabIndex = 4;
            this.convertbutton.Text = "Convert!";
            this.convertbutton.UseVisualStyleBackColor = true;
            this.convertbutton.Click += new System.EventHandler(this.convertbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BCAMO.Properties.Resources.Double_Arrow__transparent_;
            this.pictureBox1.Location = new System.Drawing.Point(419, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.convertbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convertfrom);
            this.Controls.Add(this.convertto);
            this.MainMenuStrip = this.convertfrom;
            this.Name = "Form1";
            this.Text = "Form1";
            this.convertfrom.ResumeLayout(false);
            this.convertfrom.PerformLayout();
            this.convertto.ResumeLayout(false);
            this.convertto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip convertfrom;
        private System.Windows.Forms.ToolStripMenuItem convertFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexadecimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip convertto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem convertIntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem octalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hexadecimalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem1;
        private System.Windows.Forms.Button convertbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

