using System;

namespace Songs
{
    public class Song
    {
        private string songName;
        private string artist;
        private int copiesSold;
       
        public Song(string songName, string artist, int copiesSold)
        {
            this.songName = songName;
            this.artist = artist;
            this.copiesSold = copiesSold;
        }

        public string GetsongName()
        {
            return songName;
        }

        public int GetCopiesSold()
        {
            return copiesSold;
        }
        public string GetArtist()
        {
            return artist;
        }

        public string GetDetails()
        {
            return $"Name: {songName} Artist: {artist} Copies Sold: {copiesSold}";
        }

        public string GetCertification()
        {
            if (copiesSold < 200000) return null;
          
            if (copiesSold < 400000)return "Silver";
          
            if (copiesSold < 600000) return "Gold";
           
            return "Platinum";
        }
    }
}
