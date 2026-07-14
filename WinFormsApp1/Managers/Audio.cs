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
    public class Sound : Idispose
    {
        public static List<Sound> sounds = new List<Sound>();
        public static bool IsAllMuted = false;
        private Audiotype type;
        private bool loop ;
        public Audiotype Type { get { return type; } }
        private string path;
        internal AudioFileReader reader1;
        internal WaveOutEvent sound;
        public WaveOutEvent Sound1 { get { return sound; } }
        public Sound(string path)
        {
            type = Audiotype.sound;
            loop = false;
            this.path = path;
            reader1 = new AudioFileReader(path);
            sound = new WaveOutEvent();
            sound.Init(reader1); 
            sound.PlaybackStopped += (s, e) =>
            {
                if (loop)
                {
                    reader1.CurrentTime = TimeSpan.Zero;
                    sound.Play();
                }
            };
            sounds.Add(this);
        }
        public bool dispose()
        {
            loop = false;
            sound.Dispose();
            reader1.Dispose();
            return true;
        }
        public void loopsituation(bool sit)
        {
            this.loop = sit;
        }
        public void Play()
        {
            reader1.CurrentTime = TimeSpan.Zero;
            sound.Play();
        }
        public void Stop()
        {
            sound.Stop(); 
        }
    
    
    }
    public class Music : Idispose
    {
        public static List<Music> musics = new List<Music>();
        public static bool IsAllMuted = false;
        private Audiotype type;
        private bool loop ;
        public Audiotype Type { get { return type; } }
        private string path;
        
            
        internal AudioFileReader reader;
        internal WaveOutEvent audio;
        public WaveOutEvent Audio1 { get { return audio; } }
        public Music(string path)
        {
            type = Audiotype.audio;
            loop = true;
            this.path = path;
            //MessageBox.Show(File.Exists(path).ToString() + "\n" + path);
            //jyddv nhnl
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
            musics.Add(this);
        }
        public bool dispose()
        {
            loop = false;
            audio.Dispose();
            reader.Dispose();
            return true;
        }
        public void Play()
        {
            loop = true;
            reader.CurrentTime = TimeSpan.Zero;
            audio.Play();
        }
        public void Stop()
        {
            loop = false;
            audio.Stop();
        }

    }


    public class Audio
    {
        public static Sound clicksound = new Sound("Assets/Audio/click3.wav");
        public static Sound buy = new Sound("Assets/Audio/buy.wav");
        public static Sound sell = new Sound("Assets/Audio/sell.wav");
        public static Sound explosion = new Sound("Assets/Audio/explosion.wav");
        public static Sound shoot = new Sound("Assets/Audio/shoot.wav");
        public static Sound destruction = new Sound("Assets/Audio/destruction.wav");
        public static Music backmusic = new Music("Assets/Audio/music/backmusic.mp3");
        public static Music theme = new Music("Assets/Audio/music/playmusic.mp3");
        public static Music boss = new Music("Assets/Audio/music/bossmusic.mp3");
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
                    //player.sound.Volume = volume;
                    player.reader1.Volume = volume;
                    
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
                //music.audio.Volume = volume;
                music.reader.Volume = volume;
               
                return true;
            }
            else
            {
                Console.WriteLine("wrong input for volume");
                return false;
            }
        }
        public static void disposeall()
        {
            clicksound.dispose();
            buy.dispose();
            sell.dispose();
            explosion.dispose();
            shoot.dispose();
            destruction.dispose();
            backmusic.dispose();
            theme.dispose();
            boss.dispose();
        }
    }

}

