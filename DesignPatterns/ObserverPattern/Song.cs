using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    //Just a class
    public class Song
    {
        public string Artist
        {
            get; private set;
        }
        public string SongName
        {
            get; private set;
        }
        public double Time
        {
            get; private set;
        }

        public Song(string artist, string songName, double time)
        {
            Artist = artist;
            SongName = songName;
            Time = time;
        }


    }
}
