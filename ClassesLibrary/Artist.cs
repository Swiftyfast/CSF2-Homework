using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields

        //props
        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //ctor
        public Artist(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        public Artist() { }

        //methods

        public override string ToString()
        {
            string myString = Title + ": a " + Genre + " album:\n";

            foreach (Song item in Tracks)
            {
                myString = myString + item.Title + "\n";

            }
            return myString;
        }

    }
}
