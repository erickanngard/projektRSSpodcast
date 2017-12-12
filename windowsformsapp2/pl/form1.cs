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
        int counter = new int();

        private PodcastController pc = null;

        List<Episode> listOfEpisodesPodcast = new List<Episode>();


        public Form1()
        {
            InitializeComponent();
            pc = new PodcastController();
            refreshData();
            episodeListBox.MultiColumn = false;
            timerIntervall.Interval = 5000;
            countDown.Interval = 1000;
            episodeListBox.DataSource = listOfEpisodesPodcast;
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
            int intervall = Convert.ToInt32(numericUpDownFrekvens.Value);
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
                pc.createPodcast(title, url ,category, intervall, 0);// 0 för att den skapar ett nytt objekt
                MessageBox.Show("Sucsess Title=" + title + " Category=" + category + " Url=" + url + " Intervall=" + intervall);
            }
            else
            {
                MessageBox.Show("Saknar värde i något av fälten.");
            }

            refreshData();
        }

        private async void comboBoxPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Podcast p = (Podcast)comboBoxPodcast.SelectedValue;
            //textBoxName.Text = p.title;

            //if ( p.category == "0") {
            //    textBoxCat.Text = "";
            //}
            //else {
            //    textBoxCat.Text = p.category;
            //}
            //textBoxUrl.Text = p.url;
            //numericUpDownFrekvens.Value = p.interval;
            //timerIntervalEdit(p.interval);
            //counter = p.interval;
            //countLable.Text = p.interval.ToString();

            //setEpisodeList(await pc.downloadXml(p.url));
        }

        private void refreshData()
        {
            comboBoxPodcast.DisplayMember = "title";
            comboBoxPodcast.DataSource = pc.LoadLocalPodcasts();
            cBCat.DataSource = pc.LoadCategory();
            
        }

        private void setEpisodeList(List<Episode> list, Podcast p)
        {
            episodeListBox.DisplayMember = "title";
            int ett = listOfEpisodesPodcast.Count();
            listOfEpisodesPodcast.Clear();
            int två = listOfEpisodesPodcast.Count();
            foreach (Episode e in list)
            {
                if (e.pod == p)
                { 
                    listOfEpisodesPodcast.Add(e);
                }
            }
            //episodeListBox.DataSource = list;
        }

        private void refreshEpisodeList()
        {
            episodeListBox.DataSource = null;
            episodeListBox.DataSource = listOfEpisodesPodcast;
            episodeListBox.DisplayMember = "title";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void episodeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Episode ep = (Episode)episodeListBox.SelectedValue;
            //episodDesc.Text = ep.description;
            //episodeLabel.Text = ep.title;
        }

        private void episodeListBox_DoubleClick(object sender, EventArgs e)
        {
            Episode ep = (Episode)episodeListBox.SelectedValue;
            axWindowsMediaPlayer1.URL = ep.link;
            ep.isRead = true;
            ep.title = "✔Har spelats upp!  " + ep.title;
            Podcast p = (Podcast)comboBoxPodcast.SelectedValue;
            MessageBox.Show(ep.title, p.id.ToString()); // glöm ej ta bort
            episodDesc.Text = ep.description;
            episodeLabel.Text = ep.title;
            refreshEpisodeList();
        }

        private void EditPodcast_Click(object sender, EventArgs e)
        {
            String title = textBoxName.Text;
            String url = textBoxUrl.Text;
            String category = textBoxCat.Text;
            if (textBoxCat.Text == "") {
                category = "0";
            }
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

        private  void listBoxPodcastCat_SelectedIndexChanged(object sender, EventArgs e) // den va async
        {
            //Podcast p = (Podcast)listBoxPodcastCat.SelectedValue;
            //setEpisodeList(await pc.downloadXml(p.url));
            //timerIntervalEdit(p.interval);
            //counter = p.interval;
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
            XmlGenerator xmlG = new XmlGenerator();
            xmlG.deletePodcast(p);
            refreshData();
        }

        private void timerIntervalEdit(int i) {
            timerIntervall.Interval = i*1000;
        }
        private void timerTick(object sender, EventArgs e)
        {
            refreshData();
        }
   
        private void countDown_Tick(object sender, EventArgs e)
        {
            if (countLable.Text != "")
            {
                int i = Int32.Parse(countLable.Text) - 1;
                if (i == 0)
                {
                    i = this.counter;
                }
                countLable.Text = i.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cat = (string)cBCat.SelectedValue;

            XmlGenerator xmlG = new XmlGenerator();

            xmlG.DeleteCategory(cat);
            MessageBox.Show( cat+" är nu borttagen.");
            refreshData();
        }

        private async void listBoxPodcastCat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Podcast p = (Podcast)listBoxPodcastCat.SelectedValue;
            setEpisodeList(await pc.downloadXml(p.url, p), p);
            timerIntervalEdit(p.interval);
            counter = p.interval;
        }

        private async void comboBoxPodcast_MouseClick(object sender, MouseEventArgs e)
        {
            Podcast p = (Podcast)comboBoxPodcast.SelectedValue;
            textBoxName.Text = p.title;

            if (p.category == "0")
            {
                textBoxCat.Text = "";
            }
            else
            {
                textBoxCat.Text = p.category;
            }
            textBoxUrl.Text = p.url;
            numericUpDownFrekvens.Value = p.interval;
            timerIntervalEdit(p.interval);
            counter = p.interval;
            countLable.Text = p.interval.ToString();
            setEpisodeList(await pc.downloadXml(p.url, p), p);
            refreshEpisodeList();
        }
    }
}