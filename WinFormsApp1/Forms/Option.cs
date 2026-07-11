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
        float Output1 = 0;
        float Output2 = 0;

        public Option()
        {
            InitializeComponent();
            Showlables();
            showmute();
            Inputmanager.init();
            foreach (var item in Inputmanager.keys)
            {
                forwardbox.Items.Add((Keys)item);
                backwardbox.Items.Add((Keys)item);
                leftbox.Items.Add((Keys)item);
                rightbox.Items.Add((Keys)item);
                shootbox.Items.Add((Keys)item);
            }
            forwardbox.SelectedItem = (Keys)Inputmanager.Moveforward;
            backwardbox.SelectedItem = (Keys)Inputmanager.Movebackward;
            leftbox.SelectedItem = (Keys)Inputmanager.Moveleft;
            rightbox.SelectedItem = (Keys)Inputmanager.Moveright;
            shootbox.SelectedItem = (Keys)Inputmanager.Shoot;
        }
        private void Showlables()
        {
            int s1 = (int)(Music.musics[0].reader.Volume * 100);
            label3.Text = s1.ToString() + "%";
            int s2 = (int)(Sound.sounds[0].reader1.Volume * 100);
            label2.Text = s2.ToString() + "%";
            soundeffect.Value = s2;
            music.Value = s1;
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
        private void showmute()
        {
            if (Sound.IsAllMuted)
            {
                checkBox2.Checked = true;
            }
            if (Music.IsAllMuted)
            {
                MuteMusic.Checked = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Sound.IsAllMuted = true;
                foreach (var item in Sound.sounds)
                {
                    Audio.Volumesound(item, 0f);
                }
                label2.Text = soundeffect.Value.ToString() + "%";
                return;
            }
            else
            {
                Sound.IsAllMuted = false;
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
                Music.IsAllMuted = true;
                foreach (var item in Music.musics)
                {
                    Audio.Volumemusic(item, 0f);
                }
                label3.Text = music.Value.ToString() + "%";
                return;
            }
            else
            {
                Music.IsAllMuted = false;
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

        private void forwardbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inputmanager.Moveforward = (Keys)forwardbox.SelectedItem;
        }

        private void backwardbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inputmanager.Movebackward = (Keys)backwardbox.SelectedItem;
        }

        private void rightbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inputmanager.Moveright = (Keys)rightbox.SelectedItem;
        }

        private void leftbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inputmanager.Moveleft = (Keys)leftbox.SelectedItem;
        }

        private void shootbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inputmanager.Shoot = (Keys)shootbox.SelectedItem;
        }
    }
}
