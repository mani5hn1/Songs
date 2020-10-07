using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {

           Song[] songs = new Song[2];
            
            for ( int i = 0; i < songs.Length; i++)
            {
                songs[i] = InputSongDetails();
            }
           
            Console.WriteLine("Enter Artist Name or hit enter for all");
            string artistReqd = Console.ReadLine().Trim().ToUpper();
            int totalCopiesSold = 0, count = 0;
            foreach(Song s in songs)
            {   
                if( s.GetArtist().ToUpper().Equals(artistReqd) || artistReqd == "" )
                {
                    Console.WriteLine( s.GetDetails());
                    totalCopiesSold += s.GetCopiesSold();
                    count++;
                    string cert = s.GetCertification();
                    
                   Console.WriteLine(cert != null ? cert : "No cert");
                }
            }
            Console.WriteLine($"{totalCopiesSold} {count}");
            Console.WriteLine(totalCopiesSold/count);
            }

        static Song InputSongDetails()
        {
            Console.WriteLine("Name a Song");
            string songName = Console.ReadLine();

            Console.WriteLine("Name the Artist");
            string artist = Console.ReadLine();

            Console.WriteLine("Number of copies sold");
           
            int copiesSold; 
            while (!int.TryParse(Console.ReadLine(), out copiesSold) || copiesSold < 0) {
                Console.WriteLine("Please Enter a Sensible number");
                
            }
            return new Song(songName, artist, copiesSold);
        }
    }
}
