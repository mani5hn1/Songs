using System;

namespace Song
{
    public class SongDetails
    {
        private string songName;
        private string artist;
        private int copiesSold;

        public SongDetails(string songName, string artist, int copiesSold)
        {
            this.songName = songName;
            this.artist = artist;
            this.copiesSold = copiesSold;
        }

        public string GetArtist()
        {
            return artist;
        }

        public string GetDetails()
        {
            return string.Format("Name: {0}\t Artist: {1}\t Copies Sold: {2}", songName, artist, copiesSold);

        }

        public string GetCertification()
        {
            if (copiesSold < 200000)
            {
                return null;
            }
            else if (copiesSold < 400000)
            {
                return "Silver";
            }
            else if (copiesSold < 600000)
            {
                return "Gold";
            }

            else if (copiesSold >= 600000)
            {
                return "Platinum";
            }

            return null;

        }
    }
}
