using System;
using System.Collections.Generic;
using System.Text;
namespace Test_Interface_3
{
    public class MusicFile
    {
        private String title;
        private String artist;
        private int yearOfRelease;
        private int durationInSeconds;
        public MusicFile()
        {
        }
        public MusicFile(String title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }
        public string TITLE
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Music Title");
                }
                else
                {
                    this.title = value;
                }
            }

            get
            {
                return this.title;
            }
        }

        public string ARTIST
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Artist Name");
                }
                else
                {
                    this.artist = value;
                }
            }

            get
            {
                return this.artist;
            }
        }


        public int YEAROFRELEASE
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Year of Relase is Invalid");
                }

                else
                {
                    this.yearOfRelease = value;
                }

            }
            get
            {
                return this.yearOfRelease;
            }
        }
        public int DURATIONINSECONDS
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Song Duration Invalid");
                }

                else
                {
                    this.durationInSeconds = value;
                }

            }
            get
            {
                return this.durationInSeconds;
            }
        }
        public void ShowMUsicDetails()
        {

            Console.WriteLine("*********************\n");
            Console.WriteLine("Details of the song that you have inserted");

            Console.WriteLine("Music Title                : " + title);
            Console.WriteLine("Artist Name                : " + artist);
            Console.WriteLine("Release Year               : " + yearOfRelease);
            Console.WriteLine("Duration                   : " + durationInSeconds);
        }

        static void Main(string[] args)
        {
            
            Phone phone1 = new Phone();
            Console.WriteLine("************************\n");
            Console.WriteLine("Input the songs into your playlist>>\n");

            phone1.MusicFiles[0] = Console.ReadLine();
            phone1.MusicFiles[1] = Console.ReadLine();
            phone1.MusicFiles[2] = Console.ReadLine();
            phone1.MusicFiles[3] = Console.ReadLine();
            phone1.MusicFiles[4] = Console.ReadLine();

            Console.WriteLine("Set volume of your music player (out of 100)\n");
            phone1.setVolume(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter the sequence of the song you want to play: \n");
            phone1.a = Convert.ToInt32(Console.ReadLine());
            phone1.CurrentSong();

            phone1.Switch(true);
            phone1.play(true);

            Console.WriteLine("\nFor next song type n\n");
            phone1.next = Console.ReadLine();
            phone1.playNext();

            Console.WriteLine("\nFor previous song type p\n");
            phone1.pre = Console.ReadLine();
            phone1.playPrevious();

            phone1.SwitcH(true);
            Console.WriteLine("\nRetune the frequency of the radio: \n");
            phone1.retune(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("\nSet volume of your RADIO player (Out of 100)\n");
            phone1.SetVolume(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("In which FM channel you want to change\n");
            phone1.changedchannel = Convert.ToDouble(Console.ReadLine());
            phone1.changeChannel();

            MusicFile c1 = new MusicFile();

            Console.WriteLine("\nEnter e song name to for its following details ");
            Console.WriteLine(">>Enter Music Title: ");
            c1.TITLE = Console.ReadLine();
            Console.Write("Enter Artist Name : ");
            c1.ARTIST = Console.ReadLine();

            Console.Write("Enter Year of Release of the song: ");
            c1.YEAROFRELEASE = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the duration of the song <<In Seconds>>: ");
            c1.DURATIONINSECONDS = Convert.ToInt32(Console.ReadLine());

            c1.ShowMUsicDetails();
        }

    }
}
