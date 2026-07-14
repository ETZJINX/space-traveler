using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Logics;
using WinFormsApp1.Managers;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            //if (Playform.music != null)
            //{
            //    Playform.music.Stop();
            //}
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(7);
            comboBox1.Items.Add(8);
            comboBox1.Items.Add(9);
            comboBox1.Items.Add(10);
            comboBox1.SelectedItem = 1;
            FORMMANAGER.setbackground(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wavemanager.currentwave = (int)comboBox1.SelectedItem;
        }

        private void Newgame_Click(object sender, EventArgs e)
        {
            Wavemanager.init();
            Wavemanager.currentwave = 1;
            comboBox1.SelectedItem = 1;
            //new Playform().Show();
            FORMMANAGER.handleform(this, new Playform());
            if (Playform.music != null)
            {
                Playform.music.Stop();
                Audio.backmusic.Play();
            }
            Audio.clicksound.Play();

        }

        private void Play_Click(object sender, EventArgs e)
        {
            Wavemanager.init();
            //new Playform().Show();
            FORMMANAGER.handleform(this, new Playform());
            if (Playform.music != null)
            {
                Playform.music.Stop();
                Audio.backmusic.Play();
            }
            Audio.clicksound.Play();
            //نیاز داره تا با دیتابیس مقدار کارنت ویو رو ست کنم 
        }

        private void WaveSelector_Click(object sender, EventArgs e)
        {
            //new Playform().Show();
           
            Wavemanager.init();
            MessageBox.Show(
$"Selected = {comboBox1.SelectedItem}\n" +
$"Index = {(int)comboBox1.SelectedItem - 1}\n" +
$"WaveCount = {Wavemanager.allwave.Count}");
            Wavemanager.EnemyRemainingToSpawn = Wavemanager.allwave[Wavemanager.currentwave - 1].Count;
            //Wavemanager.currentwave = (int)comboBox1.SelectedItem;
            FORMMANAGER.handleform(this, new Playform());
            
            if (Playform.music != null)
            {
                Playform.music.Stop();
                Audio.backmusic.Play();
            }

            Audio.clicksound.Play();
        }
    }
}
