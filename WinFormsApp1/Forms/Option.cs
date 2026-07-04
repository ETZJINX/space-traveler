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
        public Option()
        {
            InitializeComponent();
            label3.Text = music.Value.ToString() + "%";
            label2.Text = soundeffect.Value.ToString() + "%";
        }

        private void soundeffect_Scroll(object sender, EventArgs e)
        {
            float Output = (float)soundeffect.Value;
            Output /= 100f;
            Audio.Volumesound(player, Output);
            label2.Text = soundeffect.Value.ToString() + "%";


        }

        private void music_Scroll(object sender, EventArgs e)
        {
            float Output = (float)music.Value;
            Output /= 100f;
            Audio.Volumemusic(musicsound, Output);
            label3.Text = music.Value.ToString() + "%";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Audio.Volumesound(player, 0f);
                label2.Text = soundeffect.Value.ToString() + "%";
                return;
            }
            else
            {
                float Output = (float)soundeffect.Value;
                Output /= 100f;
                Audio.Volumesound(player, Output);
                label2.Text = soundeffect.Value.ToString() + "%";
                return;
            }
        }

        private void MuteMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (MuteMusic.Checked)
            {
                Audio.Volumemusic(musicsound, 0f);
                label3.Text = music.Value.ToString() + "%";
                return;
            }
            else
            {
                float Output = (float)music.Value;
                Output /= 100f;
                Audio.Volumesound(musicsound, Output);
                label3.Text = music.Value.ToString() + "%";
                return;
            }
        }
    }
}
