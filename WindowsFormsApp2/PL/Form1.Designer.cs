namespace WindowsFormsApp2
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFrekvens = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPodcast = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPodcast = new System.Windows.Forms.Button();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrekvens)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(11, 66);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(441, 20);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 115);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Namn";
            // 
            // numericUpDownFrekvens
            // 
            this.numericUpDownFrekvens.Location = new System.Drawing.Point(11, 169);
            this.numericUpDownFrekvens.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownFrekvens.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownFrekvens.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrekvens.Name = "numericUpDownFrekvens";
            this.numericUpDownFrekvens.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownFrekvens.TabIndex = 4;
            this.numericUpDownFrekvens.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrekvens.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uppdateringsintervall (antal gånger per vecka)";
            // 
            // comboBoxPodcast
            // 
            this.comboBoxPodcast.FormattingEnabled = true;
            this.comboBoxPodcast.Items.AddRange(new object[] {
            "hej",
            "nnej",
            "sadf",
            "saf",
            "dfdf"});
            this.comboBoxPodcast.Location = new System.Drawing.Point(510, 66);
            this.comboBoxPodcast.Name = "comboBoxPodcast";
            this.comboBoxPodcast.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPodcast.TabIndex = 6;
            this.comboBoxPodcast.SelectedIndexChanged += new System.EventHandler(this.comboBoxPodcast_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(510, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 225);
            this.listBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Podcast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Avsnitt";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonPodcast
            // 
            this.buttonPodcast.Location = new System.Drawing.Point(377, 162);
            this.buttonPodcast.Name = "buttonPodcast";
            this.buttonPodcast.Size = new System.Drawing.Size(75, 23);
            this.buttonPodcast.TabIndex = 10;
            this.buttonPodcast.Text = "Lägg till podcast";
            this.buttonPodcast.UseVisualStyleBackColor = true;
            this.buttonPodcast.Click += new System.EventHandler(this.buttonPodcast_Click);
            // 
            // textBoxCat
            // 
            this.textBoxCat.Location = new System.Drawing.Point(261, 115);
            this.textBoxCat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(191, 20);
            this.textBoxCat.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.buttonPodcast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxPodcast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownFrekvens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrekvens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFrekvens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPodcast;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPodcast;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.Label label6;
    }
}

