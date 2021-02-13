using System;

namespace Playlist_Task
{
    class Track
    {
        private int TrackID { get; set; }
        
        public Track(int x)       
        {            
            TrackID = x;
        }

        public void PlayTrack() //Basic void function to visualize work flow of program
        {
            Console.WriteLine("Playing track " + TrackID +"."); 
        }        
    }
}
