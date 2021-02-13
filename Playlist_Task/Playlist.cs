using System;
using System.Collections.Generic;

namespace Playlist_Task
{
    class Playlist
    {
        List<Track> ListOfTracks { get; set; } //Create list of tracks
        private int SizeOfPlaylist { get; set; }

        public Playlist(int size) 
        {
            ListOfTracks = new List<Track>();
            SizeOfPlaylist = size;
            for (int i = 0; i < size; i++)
            {
                ListOfTracks.Add(new Track(i)); //ID of track is start index in listOfTracks
            }
        }

        public void PlayPlaylist() 
        {
            Console.WriteLine("Starting playlist.");
            int maxRandomNumber = SizeOfPlaylist; //maxRandomNumber cannot be larget than sizeOfPlaylist            
            Random random = new Random();
            while (ListOfTracks.Count > 0)
            {
                int randomNumber = random.Next(maxRandomNumber); //generating random number that is smaller than sizeOfPlaylist
                ListOfTracks[randomNumber].PlayTrack();                 
                ListOfTracks.RemoveAt(randomNumber); //removing track after playing it
                maxRandomNumber--; //decreasing maxRandomNumber so it isn't larger than current sizeOfPlaylist
            }
            Console.WriteLine("End of playlist.");
        }
    }
}
