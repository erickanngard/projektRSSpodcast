using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using WindowsFormsApp2.BL;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private PodcastController pc = null;
        
        public Form1()
        {
            
            InitializeComponent();
            pc = new PodcastController();
            refreshData();
            episodeListBox.MultiColumn = false;
            //comboBoxPodcast.DataSource = pc.arrayOfPodcast();

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
                pc.createPodcast(title, url ,category, i);
                MessageBox.Show("Sucsess Title=" + title + " Category=" + category + " Url=" + url + " Intervall=" + i);
            }
            else
            {
                MessageBox.Show("Saknar värde i något av fälten.");
            }

            refreshData();
        }

        private async void comboBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Podcast p = (Podcast)comboBoxPodcast.SelectedValue;
            textBoxName.Text = p.title;
            textBoxCat.Text = p.category;
            textBoxUrl.Text = p.url;
            numericUpDownFrekvens.Value = p.interval;

            refreshEpisodeList(await pc.downloadXml(p.url));
        }

        private void refreshData()
        {
            comboBoxPodcast.DisplayMember = "title";
            comboBoxPodcast.DataSource = pc.LoadLocalPodcasts();
            cBCat.DataSource = pc.LoadCategory();
            
        }

        private void refreshEpisodeList(List<Episode> list)
        {
            episodeListBox.DisplayMember = "title";
            episodeListBox.DataSource = list;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void episodeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Episode ep = (Episode)episodeListBox.SelectedValue;
            episodDesc.Text = ep.description;
            episodeLabel.Text = ep.title;
           
        }

        private void episodeListBox_DoubleClick(object sender, EventArgs e)
        {
            Episode ep = (Episode)episodeListBox.SelectedValue;
            axWindowsMediaPlayer1.URL = ep.link;
            ep.isRead = true;
        }

        private void EditPodcast_Click(object sender, EventArgs e)
        {
            //får inte den att funka...
            
            String title = textBoxName.Text;
            String url = textBoxUrl.Text;
            String category = textBoxCat.Text;
            int i = Convert.ToInt32(numericUpDownFrekvens.Value);
            int v = 0;
            String[] arrayOfText = { title, url, category};
            Podcast p = (Podcast)comboBoxPodcast.SelectedValue;

            XmlGenerator xmlG = new XmlGenerator();

            Validator val = new Validator();
            foreach (String s in arrayOfText)
            {
                if (val.ValidateTextBoxNotEmpty(s) == true)
                {
                    v++;
                }
            }
            if (v == 3)
            {
                xmlG.EditValuePodcast(p, title, category, url);
                MessageBox.Show("Sucsess Title=" + title + " Category=" + category + " Url=" + url + " Intervall=" + i);
            }
            else
            {
                MessageBox.Show("Saknar värde i något av fälten.");
            }

            refreshData();

        }

        private async void listBoxPodcastCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Podcast p = (Podcast)listBoxPodcastCat.SelectedValue;
            refreshEpisodeList(await pc.downloadXml(p.url));
        }

        private void cBCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = (String)cBCat.SelectedValue;
            List<Podcast> pl = pc.LoadLocalPodcasts();
            List<Podcast> catL = new List<Podcast>();
            
            foreach (Podcast p in pl)
            {
                if (p.category == s)
                {
                    catL.Add(p);
                }
            }
            listBoxPodcastCat.DisplayMember = "title";
            listBoxPodcastCat.DataSource = catL;
        }

        private void deletePodcast_Click(object sender, EventArgs e)
        {
            Podcast p = (Podcast)comboBoxPodcast.SelectedValue;



        }
    }
}