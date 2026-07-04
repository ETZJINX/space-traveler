using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Managers;

namespace WinFormsApp1.Forms
{
    public partial class Option : Form
    {
        float Output1;
        float Output2;

        public Option()
        {
            InitializeComponent();
            label3.Text = music.Value.ToString() + "%";
            label2.Text = soundeffect.Value.ToString() + "%";
        }

        private void soundeffect_Scroll(object sender, EventArgs e)
        {
            Output1 = (float)soundeffect.Value;
            Output1 /= 100f;
            label2.Text = soundeffect.Value.ToString() + "%";
        }

        private void music_Scroll(object sender, EventArgs e)
        {
            Output2 = (float)music.Value;
            Output2 /= 100f;
            label3.Text = music.Value.ToString() + "%";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                foreach (var item in Sound.sounds)
                {
                    Audio.Volumesound(item, 0f);
                }
                label2.Text = soundeffect.Value.ToString() + "%";
                return;
            }
            else
            {
                Output1 = (float)soundeffect.Value;
                Output1 /= 100f;
                foreach (var item in Sound.sounds)
                {
                    Audio.Volumesound(item, Output1);
                }
                label2.Text = soundeffect.Value.ToString() + "%";
                return;
            }
        }

        private void MuteMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (MuteMusic.Checked)
            {
                foreach (var item in Music.musics)
                {
                    Audio.Volumemusic(item, 0f);
                }
                label3.Text = music.Value.ToString() + "%";
                return;
            }
            else
            {
                Output2 = (float)music.Value;
                Output2 /= 100f;
                foreach (var item in Music.musics)
                {
                    Audio.Volumemusic(item, Output2);
                }
                label3.Text = music.Value.ToString() + "%";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Sound.sounds)
            {

                Audio.Volumesound(item, Output1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Music.musics)
            {

                Audio.Volumemusic(item, Output2);
            }
        }
    }
}
