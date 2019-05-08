namespace Labirint_Editor
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.MainCustomPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.userControl21 = new Labirint_Editor.UserControl2();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl31 = new Labirint_Editor.UserControl3();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel6.SuspendLayout();
            this.MainCustomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.MainCustomPanel);
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Location = new System.Drawing.Point(12, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(433, 487);
            this.panel6.TabIndex = 0;
            // 
            // MainCustomPanel
            // 
            this.MainCustomPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainCustomPanel.Controls.Add(this.button2);
            this.MainCustomPanel.Controls.Add(this.SaveButton);
            this.MainCustomPanel.Controls.Add(this.userControl21);
            this.MainCustomPanel.Location = new System.Drawing.Point(7, 143);
            this.MainCustomPanel.Name = "MainCustomPanel";
            this.MainCustomPanel.Size = new System.Drawing.Size(416, 341);
            this.MainCustomPanel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("DFPOP1-W9", 15.25F);
            this.button2.Location = new System.Drawing.Point(259, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 83);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.SaveButton.FlatAppearance.BorderSize = 5;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(20, 9);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(174, 92);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Gray;
            this.userControl21.Location = new System.Drawing.Point(20, 126);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(210, 83);
            this.userControl21.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Algerian", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(198, 34);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Biomes Editor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox23);
            this.panel1.Location = new System.Drawing.Point(460, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 487);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.userControl31);
            this.panel2.Location = new System.Drawing.Point(7, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 341);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("DFPOP1-W9", 15.25F);
            this.button3.Location = new System.Drawing.Point(255, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 83);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 92);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.Gray;
            this.userControl31.Location = new System.Drawing.Point(21, 126);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(200, 101);
            this.userControl31.TabIndex = 0;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Algerian", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(3, 14);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(198, 34);
            this.textBox23.TabIndex = 0;
            this.textBox23.Text = "Mobs Editor";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(971, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "Form1";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.MainCustomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BiomesCount;
        private System.Windows.Forms.TextBox BiomesCountText;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel MainCustomPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox23;
        private UserControl2 userControl21;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private UserControl3 userControl31;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

