﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            PodcastController pc = new PodcastController();
            comboBoxPodcast.DataSource = pc.arrayOfPodcast();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPodcast_Click(object sender, EventArgs e)
        {

            String title = textBoxName.Text;
            String url = textBoxUrl.Text;
            String category = textBoxCat.Text;
            int i = Convert.ToInt32(numericUpDownFrekvens.Value);
            int v = 0;
            String[] arrayOfText = { title, url, category };


            Validator val = new Validator();
            foreach(String s in arrayOfText) {
                if ( val.ValidateTextBoxNotEmpty(s) == true) {
                    v++;
                }
            }
            if (v == 3)
            {
                PodcastController pc = new PodcastController();
                pc.createPodcast(title, category, url, i);
                MessageBox.Show("Sucsess Title=" + title + " Category=" + category + " Url=" + url + " Intervall=" + i);
            }
            else
            {
                MessageBox.Show("Saknar värde i något av fälten.");
            }
        }

        private void comboBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            Podcast p = (Podcast)comboBoxPodcast.SelectedValue;
            textBoxName.Text = p.getTitle();
            textBoxCat.Text = p.getCategory();
            textBoxUrl.Text = p.url;
            numericUpDownFrekvens.Value = p.interval;
        }
    }
}