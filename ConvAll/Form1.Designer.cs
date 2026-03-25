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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            pnlVaha = new Panel();
            textVystupVah = new TextBox();
            comVahVstup = new ComboBox();
            comVahVystup = new ComboBox();
            label2 = new Label();
            numVaha = new NumericUpDown();
            pnlVzdalenost = new Panel();
            textVystupVzda = new TextBox();
            numVzda = new NumericUpDown();
            comVzdaVstup = new ComboBox();
            comVzdaVystup = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            ukoncitToolStripMenuItem = new ToolStripMenuItem();
            pnlVaha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVaha).BeginInit();
            pnlVzdalenost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVzda).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Váha", "Vzdálenost" });
            comboBox1.Location = new Point(153, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pnlVaha
            // 
            pnlVaha.Anchor = AnchorStyles.None;
            pnlVaha.BackColor = Color.SteelBlue;
            pnlVaha.Controls.Add(textVystupVah);
            pnlVaha.Controls.Add(comVahVstup);
            pnlVaha.Controls.Add(comVahVystup);
            pnlVaha.Controls.Add(label2);
            pnlVaha.Controls.Add(numVaha);
            pnlVaha.Location = new Point(50, 306);
            pnlVaha.Name = "pnlVaha";
            pnlVaha.Size = new Size(300, 100);
            pnlVaha.TabIndex = 1;
            pnlVaha.Visible = false;
            // 
            // textVystupVah
            // 
            textVystupVah.Location = new Point(10, 60);
            textVystupVah.Name = "textVystupVah";
            textVystupVah.ReadOnly = true;
            textVystupVah.Size = new Size(150, 23);
            textVystupVah.TabIndex = 6;
            // 
            // comVahVstup
            // 
            comVahVstup.FormattingEnabled = true;
            comVahVstup.Items.AddRange(new object[] { "kilogram (kg)", "gram (g)", "libra (lb)", "tuna (t)", "dekagram (dag)", "miligram (mg)", "metrický cent (q)", "unce (oz)" });
            comVahVstup.Location = new Point(180, 25);
            comVahVstup.Name = "comVahVstup";
            comVahVstup.Size = new Size(115, 23);
            comVahVstup.TabIndex = 4;
            comVahVstup.TextChanged += numVaha_ValueChanged;
            // 
            // comVahVystup
            // 
            comVahVystup.FormattingEnabled = true;
            comVahVystup.Items.AddRange(new object[] { "kilogram (kg)", "gram (g)", "libra (lb)", "tuna (t)", "dekagram (dag)", "miligram (mg)", "metrický cent (q)", "unce (oz)" });
            comVahVystup.Location = new Point(180, 60);
            comVahVystup.Name = "comVahVystup";
            comVahVystup.Size = new Size(115, 23);
            comVahVystup.TabIndex = 3;
            comVahVystup.TextChanged += numVaha_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 7);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Váha";
            // 
            // numVaha
            // 
            numVaha.DecimalPlaces = 2;
            numVaha.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numVaha.Location = new Point(10, 25);
            numVaha.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numVaha.Name = "numVaha";
            numVaha.Size = new Size(150, 23);
            numVaha.TabIndex = 0;
            numVaha.ValueChanged += numVaha_ValueChanged;
            // 
            // pnlVzdalenost
            // 
            pnlVzdalenost.Anchor = AnchorStyles.None;
            pnlVzdalenost.BackColor = Color.SteelBlue;
            pnlVzdalenost.Controls.Add(textVystupVzda);
            pnlVzdalenost.Controls.Add(numVzda);
            pnlVzdalenost.Controls.Add(comVzdaVstup);
            pnlVzdalenost.Controls.Add(comVzdaVystup);
            pnlVzdalenost.Controls.Add(label1);
            pnlVzdalenost.Location = new Point(50, 200);
            pnlVzdalenost.Name = "pnlVzdalenost";
            pnlVzdalenost.Size = new Size(300, 100);
            pnlVzdalenost.TabIndex = 3;
            pnlVzdalenost.Visible = false;
            // 
            // textVystupVzda
            // 
            textVystupVzda.Location = new Point(10, 60);
            textVystupVzda.Name = "textVystupVzda";
            textVystupVzda.ReadOnly = true;
            textVystupVzda.Size = new Size(150, 23);
            textVystupVzda.TabIndex = 7;
            // 
            // numVzda
            // 
            numVzda.DecimalPlaces = 2;
            numVzda.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numVzda.Location = new Point(10, 25);
            numVzda.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numVzda.Name = "numVzda";
            numVzda.Size = new Size(150, 23);
            numVzda.TabIndex = 7;
            numVzda.ValueChanged += numVzda_ValueChanged;
            // 
            // comVzdaVstup
            // 
            comVzdaVstup.FormattingEnabled = true;
            comVzdaVstup.Items.AddRange(new object[] { "metr (m)", "centimetr (cm)", "palec (in)", "milimetr (mm)", "stopa (ft)", "decimetr (dm)", "kilometr (km)", "míle (mi)", "yard (yd)" });
            comVzdaVstup.Location = new Point(180, 25);
            comVzdaVstup.Name = "comVzdaVstup";
            comVzdaVstup.Size = new Size(115, 23);
            comVzdaVstup.TabIndex = 7;
            comVzdaVstup.TextChanged += numVzda_ValueChanged;
            // 
            // comVzdaVystup
            // 
            comVzdaVystup.FormattingEnabled = true;
            comVzdaVystup.Items.AddRange(new object[] { "metr (m)", "centimetr (cm)", "palec (in)", "milimetr (mm)", "stopa (ft)", "decimetr (dm)", "kilometr (km)", "míle (mi)", "yard (yd)" });
            comVzdaVystup.Location = new Point(180, 60);
            comVzdaVystup.Name = "comVzdaVystup";
            comVzdaVystup.Size = new Size(115, 23);
            comVzdaVystup.TabIndex = 8;
            comVzdaVystup.TextChanged += numVzda_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Vzdálenost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 38F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(75, 41);
            label3.Name = "label3";
            label3.Size = new Size(245, 60);
            label3.TabIndex = 4;
            label3.Text = "ConvAll";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(153, 132);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 5;
            label4.Text = "Vyberte moznost";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ukoncitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(116, 26);
            // 
            // ukoncitToolStripMenuItem
            // 
            ukoncitToolStripMenuItem.Name = "ukoncitToolStripMenuItem";
            ukoncitToolStripMenuItem.Size = new Size(115, 22);
            ukoncitToolStripMenuItem.Text = "Ukoncit";
            ukoncitToolStripMenuItem.Click += ukoncitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pnlVaha);
            Controls.Add(comboBox1);
            Controls.Add(pnlVzdalenost);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            pnlVaha.ResumeLayout(false);
            pnlVaha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVaha).EndInit();
            pnlVzdalenost.ResumeLayout(false);
            pnlVzdalenost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVzda).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Panel pnlVaha;
        private NumericUpDown numVaha;
        private Label label2;
        private Panel pnlVzdalenost;
        private Label label1;
        private ComboBox comVahVstup;
        private ComboBox comVahVystup;
        private TextBox textVystupVah;
        private TextBox textVystupVzda;
        private NumericUpDown numVzda;
        private ComboBox comVzdaVystup;
        private ComboBox comVzdaVstup;
        private Label label3;
        private Label label4;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ukoncitToolStripMenuItem;
    }
}
