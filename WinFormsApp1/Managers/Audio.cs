using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Media;
using System.Numerics;
using System.Text;

namespace WinFormsApp1.Managers
{
    public interface Idispose
    {
        bool dispose();
    }
    public enum type
    {
        sound = 1,
        audio = 2
    }
    internal class Sound : Idispose
    {
        private type type;
        private bool loop = true;
        public type Type { get { return type; } }
        private string path;
        internal AudioFileReader reader;
        internal WaveOutEvent sound;
        public Sound(string path)
        {
            type = type.sound;
            loop = false;
            this.path = path;
            reader = new AudioFileReader(path);
            sound = new WaveOutEvent();
            sound.Init(reader); 
            sound.PlaybackStopped += (s, e) =>
            {
                if (loop)
                {
                    reader.CurrentTime = TimeSpan.Zero;
                    sound.Play();
                }
            };
        }
        public bool dispose()
        {
            sound.Dispose();
            reader.Dispose();
            return true;
        }
        public void loopsituation(bool sit)
        {
            this.loop = sit;
        }
        public void Play()
        {
            sound.Play();
        }
        public void Stop()
        {
            sound.Stop(); 
        }
    
    
    }
    internal class Music : Idispose
    {
        private type type;
        bool loop = true;
        public type Type { get { return type; } }
        private string path;
        internal AudioFileReader reader;
        internal WaveOutEvent audio;
        public Music(string path)
        {
            type = type.audio;
            this.path = path;
            reader = new AudioFileReader(path);
            audio = new WaveOutEvent();
            audio.Init(reader);
            sound.PlaybackStopped += (s, e) =>
            {
                if (loop)
                {
                    reader.CurrentTime = TimeSpan.Zero;
                    sound.Play();
                }
            };
            //یادگیری ایونت چیست و چگونه کار میکند به همراه کتابخانه naudio 
        }
        public bool dispose()
        {
            audio.Dispose();
            reader.Dispose();
            return true;
        }
        public void Play()
        {
            audio.Play();
        }
        public void Stop()
        {
            audio.Stop();
        }

    }


    internal class Audio
    {
        public static bool Playsound(Sound player)
        {
            player.Play();
            return true;
        }
        public static bool Volumesound(Sound player,float volume)
        {
            try
            {
                player.sound.Volume = volume;
                return true;
            }
            catch
            {
                return false;
            }      
        }
        public static bool Playmusic(Music music)
        {
            music.Play();
            return true;
        }
        public static bool Stopmusic(Music music)
        {
            music.Stop();
            return true;
        }
        public static bool Volumemusic(Music music,float volume)
        {
            music.audio.Volume = volume;
            return true;
        }
        
    }

}

