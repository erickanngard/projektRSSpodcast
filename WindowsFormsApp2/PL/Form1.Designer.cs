﻿namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownFrekvens = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPodcast = new System.Windows.Forms.ComboBox();
            this.episodeListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPodcast = new System.Windows.Forms.Button();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.episodDesc = new System.Windows.Forms.Label();
            this.EditPodcast = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.deletePodcast = new System.Windows.Forms.Button();
            this.cBCat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxPodcastCat = new System.Windows.Forms.ListBox();
            this.timerIntervall = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.countLable = new System.Windows.Forms.Label();
            this.countDown = new System.Windows.Forms.Timer(this.components);
            this.deleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrekvens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(11, 24);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(198, 20);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 61);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Namn";
            // 
            // numericUpDownFrekvens
            // 
            this.numericUpDownFrekvens.Location = new System.Drawing.Point(11, 142);
            this.numericUpDownFrekvens.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownFrekvens.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.numericUpDownFrekvens.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownFrekvens.Name = "numericUpDownFrekvens";
            this.numericUpDownFrekvens.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownFrekvens.TabIndex = 4;
            this.numericUpDownFrekvens.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownFrekvens.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uppdateringsintervall sekunder";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.comboBoxPodcast.Location = new System.Drawing.Point(347, 38);
            this.comboBoxPodcast.Name = "comboBoxPodcast";
            this.comboBoxPodcast.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPodcast.TabIndex = 6;
            this.comboBoxPodcast.SelectedIndexChanged += new System.EventHandler(this.comboBoxPodcast_SelectedIndexChanged);
            this.comboBoxPodcast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxPodcast_MouseClick);
            // 
            // episodeListBox
            // 
            this.episodeListBox.FormattingEnabled = true;
            this.episodeListBox.Location = new System.Drawing.Point(347, 83);
            this.episodeListBox.Name = "episodeListBox";
            this.episodeListBox.Size = new System.Drawing.Size(284, 134);
            this.episodeListBox.TabIndex = 7;
            this.episodeListBox.SelectedIndexChanged += new System.EventHandler(this.episodeListBox_SelectedIndexChanged);
            this.episodeListBox.DoubleClick += new System.EventHandler(this.episodeListBox_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mina Podcasts";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Avsnitt";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonPodcast
            // 
            this.buttonPodcast.Location = new System.Drawing.Point(11, 167);
            this.buttonPodcast.Name = "buttonPodcast";
            this.buttonPodcast.Size = new System.Drawing.Size(75, 23);
            this.buttonPodcast.TabIndex = 10;
            this.buttonPodcast.Text = "Lägg till podcast";
            this.buttonPodcast.UseVisualStyleBackColor = true;
            this.buttonPodcast.Click += new System.EventHandler(this.buttonPodcast_Click);
            // 
            // textBoxCat
            // 
            this.textBoxCat.Location = new System.Drawing.Point(11, 99);
            this.textBoxCat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(198, 20);
            this.textBoxCat.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category";
            // 
            // episodeLabel
            // 
            this.episodeLabel.AutoSize = true;
            this.episodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLabel.Location = new System.Drawing.Point(346, 220);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Size = new System.Drawing.Size(117, 24);
            this.episodeLabel.TabIndex = 13;
            this.episodeLabel.Text = "Avsnitt Titel";
            // 
            // episodDesc
            // 
            this.episodDesc.AutoSize = true;
            this.episodDesc.Location = new System.Drawing.Point(347, 248);
            this.episodDesc.Name = "episodDesc";
            this.episodDesc.Size = new System.Drawing.Size(60, 13);
            this.episodDesc.TabIndex = 14;
            this.episodDesc.Text = "Description";
            // 
            // EditPodcast
            // 
            this.EditPodcast.Location = new System.Drawing.Point(134, 167);
            this.EditPodcast.Name = "EditPodcast";
            this.EditPodcast.Size = new System.Drawing.Size(75, 23);
            this.EditPodcast.TabIndex = 15;
            this.EditPodcast.Text = "Ändra";
            this.EditPodcast.UseVisualStyleBackColor = true;
            this.EditPodcast.Click += new System.EventHandler(this.EditPodcast_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(347, 369);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(284, 44);
            this.axWindowsMediaPlayer1.TabIndex = 16;
            // 
            // deletePodcast
            // 
            this.deletePodcast.Location = new System.Drawing.Point(556, 36);
            this.deletePodcast.Name = "deletePodcast";
            this.deletePodcast.Size = new System.Drawing.Size(75, 23);
            this.deletePodcast.TabIndex = 17;
            this.deletePodcast.Text = "Ta bort";
            this.deletePodcast.UseVisualStyleBackColor = true;
            this.deletePodcast.Click += new System.EventHandler(this.deletePodcast_Click);
            // 
            // cBCat
            // 
            this.cBCat.FormattingEnabled = true;
            this.cBCat.Location = new System.Drawing.Point(11, 244);
            this.cBCat.Name = "cBCat";
            this.cBCat.Size = new System.Drawing.Size(198, 21);
            this.cBCat.TabIndex = 18;
            this.cBCat.SelectedIndexChanged += new System.EventHandler(this.cBCat_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Visa podcast från categroi";
            // 
            // listBoxPodcastCat
            // 
            this.listBoxPodcastCat.FormattingEnabled = true;
            this.listBoxPodcastCat.Location = new System.Drawing.Point(11, 272);
            this.listBoxPodcastCat.Name = "listBoxPodcastCat";
            this.listBoxPodcastCat.Size = new System.Drawing.Size(198, 134);
            this.listBoxPodcastCat.TabIndex = 20;
            this.listBoxPodcastCat.SelectedIndexChanged += new System.EventHandler(this.listBoxPodcastCat_SelectedIndexChanged);
            this.listBoxPodcastCat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPodcastCat_MouseDoubleClick);
            // 
            // timerIntervall
            // 
            this.timerIntervall.Enabled = true;
            this.timerIntervall.Tick += new System.EventHandler(this.timerTick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Avsnitt uppdateras om:";
            // 
            // countLable
            // 
            this.countLable.AutoSize = true;
            this.countLable.Location = new System.Drawing.Point(545, 67);
            this.countLable.Name = "countLable";
            this.countLable.Size = new System.Drawing.Size(0, 13);
            this.countLable.TabIndex = 22;
            // 
            // countDown
            // 
            this.countDown.Enabled = true;
            this.countDown.Tick += new System.EventHandler(this.countDown_Tick);
            // 
            // deleteCategory
            // 
            this.deleteCategory.Location = new System.Drawing.Point(215, 242);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(125, 23);
            this.deleteCategory.TabIndex = 23;
            this.deleteCategory.Text = "Ta bort vald categori";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 425);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.countLable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxPodcastCat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBCat);
            this.Controls.Add(this.deletePodcast);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.EditPodcast);
            this.Controls.Add(this.episodDesc);
            this.Controls.Add(this.episodeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.buttonPodcast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.episodeListBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
        private System.Windows.Forms.ListBox episodeListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPodcast;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.Label episodDesc;
        private System.Windows.Forms.Button EditPodcast;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button deletePodcast;
        private System.Windows.Forms.ComboBox cBCat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxPodcastCat;
        private System.Windows.Forms.Timer timerIntervall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label countLable;
        private System.Windows.Forms.Timer countDown;
        private System.Windows.Forms.Button deleteCategory;
    }
}

