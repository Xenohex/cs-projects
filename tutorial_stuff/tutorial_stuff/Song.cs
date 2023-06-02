using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginnerTutorials
{
    internal class Song     // Lesson 26 - static class attributes
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }

        public int getSongCount() { return songCount; } // allows you to get the static songCount value from every object

        public int SongCount    // this way also still works for objects if you wanted to go the normal getter/setter route
        {
            get { return songCount; }   
        }
    }
}
