using System;

namespace Playlist_Task
{
    class Track
    {
        private int trackID; 
        
        public Track(int x) //Constructor        
        {            
            trackID = x;
        }

        public void PlayTrack() //Basic void function to visualize work flow of program
        {
            Console.WriteLine("Playing track " + trackID +"."); 
        }        
    }
}
