using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Logics;

namespace WinFormsApp1
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wavemanager.currentwave = (int)comboBox1.SelectedItem;
        }

        private void Newgame_Click(object sender, EventArgs e)
        {
            Wavemanager.currentwave = 1;
            comboBox1.SelectedItem = 1;
            new Playform().Show();

        }

        private void Play_Click(object sender, EventArgs e)
        {
            new Playform().Show();
            //نیاز داره تا با دیتابیس مقدار کارنت ویو رو ست کنم 
        }

        private void WaveSelector_Click(object sender, EventArgs e)
        {
            new Playform().Show();
            Wavemanager.EnemyRemainingToSpawn = Wavemanager.allwave[Wavemanager.currentwave - 1].Count;
        }
    }
}
