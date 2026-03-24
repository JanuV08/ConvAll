namespace ConvAll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            pnlVaha = new Panel();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            pnlVzdalenost = new Panel();
            label1 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            pnlVaha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            pnlVzdalenost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vzdálenost", "Váha" });
            comboBox1.Location = new Point(332, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pnlVaha
            // 
            pnlVaha.Controls.Add(comboBox3);
            pnlVaha.Controls.Add(comboBox2);
            pnlVaha.Controls.Add(label2);
            pnlVaha.Controls.Add(numericUpDown2);
            pnlVaha.Controls.Add(numericUpDown1);
            pnlVaha.Location = new Point(537, 205);
            pnlVaha.Name = "pnlVaha";
            pnlVaha.Size = new Size(200, 102);
            pnlVaha.TabIndex = 1;
            pnlVaha.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "t", "kg", "g", "mg" });
            comboBox3.Location = new Point(150, 63);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(33, 23);
            comboBox3.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "t", "kg", "g", "mg" });
            comboBox2.Location = new Point(150, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(33, 23);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 8);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Váha";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(13, 64);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 26);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // pnlVzdalenost
            // 
            pnlVzdalenost.Controls.Add(label1);
            pnlVzdalenost.Controls.Add(numericUpDown3);
            pnlVzdalenost.Controls.Add(numericUpDown4);
            pnlVzdalenost.Location = new Point(320, 205);
            pnlVzdalenost.Name = "pnlVzdalenost";
            pnlVzdalenost.Size = new Size(200, 102);
            pnlVzdalenost.TabIndex = 3;
            pnlVzdalenost.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Vzdálenost";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(13, 64);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 1;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(12, 26);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlVaha);
            Controls.Add(comboBox1);
            Controls.Add(pnlVzdalenost);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlVaha.ResumeLayout(false);
            pnlVaha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            pnlVzdalenost.ResumeLayout(false);
            pnlVzdalenost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Panel pnlVaha;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Panel pnlVzdalenost;
        private Label label1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
    }
}
