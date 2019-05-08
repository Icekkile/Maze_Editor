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
            this.SaveButton = new System.Windows.Forms.Button();
            this.userControl21 = new Labirint_Editor.UserControl2();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel6.SuspendLayout();
            this.MainCustomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
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
            this.MainCustomPanel.Controls.Add(this.SaveButton);
            this.MainCustomPanel.Controls.Add(this.userControl21);
            this.MainCustomPanel.Controls.Add(this.trackBar1);
            this.MainCustomPanel.Controls.Add(this.textBox4);
            this.MainCustomPanel.Location = new System.Drawing.Point(7, 143);
            this.MainCustomPanel.Name = "MainCustomPanel";
            this.MainCustomPanel.Size = new System.Drawing.Size(416, 341);
            this.MainCustomPanel.TabIndex = 3;
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
            this.userControl21.Location = new System.Drawing.Point(37, 228);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(210, 83);
            this.userControl21.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.trackBar1.Location = new System.Drawing.Point(37, 140);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(172, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Montserrat", 9.249999F);
            this.textBox4.Location = new System.Drawing.Point(37, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Biomes Count";
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.textBox22);
            this.panel1.Controls.Add(this.textBox23);
            this.panel1.Location = new System.Drawing.Point(460, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 487);
            this.panel1.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(274, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(7, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 341);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.trackBar2.Location = new System.Drawing.Point(7, 92);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(172, 45);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Montserrat", 9.249999F);
            this.textBox22.Location = new System.Drawing.Point(7, 63);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(100, 23);
            this.textBox22.TabIndex = 1;
            this.textBox22.Text = "Mobs Count";
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
            this.MainCustomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BiomesCount;
        private System.Windows.Forms.TextBox BiomesCountText;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel MainCustomPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private UserControl2 userControl21;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

