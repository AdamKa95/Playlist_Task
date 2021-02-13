using System;
using System.Collections.Generic;

namespace Playlist_Task
{
    class Playlist
    {
        List<Track> listOfTracks = new List<Track>(); //Create list of tracks
        private int sizeOfPlaylist;

        public Playlist(int size) //Constructor
        {
            sizeOfPlaylist = size;
            for (int i = 0; i < size; i++)
            {
                listOfTracks.Add(new Track(i)); //ID of track is start index in listOfTracks
            }
        }

        public void Play_Playlist() 
        {
            Console.WriteLine("Starting playlist.");
            int maxRandomNumber = sizeOfPlaylist; //maxRandomNumber cannot be larget than sizeOfPlaylist
            int randomNumber;
            Random random = new Random();
            while (listOfTracks.Count > 0)
            {
                randomNumber = random.Next(maxRandomNumber); //generating random number that is smaller than sizeOfPlaylist
                listOfTracks[randomNumber].PlayTrack();                 
                listOfTracks.RemoveAt(randomNumber); //removing track after playing it
                maxRandomNumber--; //decreasing maxRandomNumber so it isn't larger than current sizeOfPlaylist
            }
            Console.WriteLine("End of playlist.");
        }
    }
}
