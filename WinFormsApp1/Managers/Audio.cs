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
    public enum Audiotype
    {
        sound = 1,
        audio = 2
    }
    internal class Sound : Idispose
    {
        private Audiotype type;
        private bool loop = true;
        public Audiotype Type { get { return type; } }
        private string path;
        internal AudioFileReader reader;
        internal WaveOutEvent sound;
        public Sound(string path)
        {
            type = Audiotype.sound;
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
        private Audiotype type;
        bool loop = true;
        public Audiotype Type { get { return type; } }
        private string path;
        internal AudioFileReader reader;
        internal WaveOutEvent audio;
        public Music(string path)
        {
            type = Audiotype.audio;
            this.path = path;
            reader = new AudioFileReader(path);
            audio = new WaveOutEvent();
            audio.Init(reader);
            audio.PlaybackStopped += (s, e) =>
            {
                if (loop)
                {
                    reader.CurrentTime = TimeSpan.Zero;
                    audio.Play();
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
                if (volume <= 1 && volume >= 0)
                {
                    player.sound.Volume = volume;
                    return true;
                }
                else
                {
                    Console.WriteLine("wrong input for volume");
                    return false;
                }
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
            if (volume <= 1 && volume >= 0)
            {
                music.audio.Volume = volume;
                return true;
            }
            else
            {
                Console.WriteLine("wrong input for volume");
                return false;
            }
        }
        
    }

}

