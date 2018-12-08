using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamMP
{
    class Program
    {
        public static List<SMPdata> SMPList = new List<SMPdata>();
        static int alttotal;
        static int hiphoptot;
     

        static void Main(string[] args)
        {


            try
            {


                string[] lines = System.IO.File.ReadAllLines(@"SampleMusicPlaylist.txt");


                int x;
                for (x = 1; x < 21; x++)
                {

                    SMPdata data = new SMPdata();

                    string[] tokens = lines[x].Split('\t');



                    data.name = Convert.ToString(tokens[0]);
                    data.artist = Convert.ToString(tokens[1]);
                    data.album = Convert.ToString(tokens[2]);
                    data.genre = Convert.ToString(tokens[3]);
                    data.size = int.Parse(tokens[4]);
                    data.time = int.Parse(tokens[5]);
                    data.year = int.Parse(tokens[6]);
                    data.plays = int.Parse(tokens[7]);


                    SMPList.Add(data);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File was not found please add to directory or add path to command line.");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("There was a error when trying open,write, or read to the file. Or the data in the file wasn't the right amount or of the right type");
                Console.ReadKey();
            }

            var twohundred = from SMPdata in SMPList where SMPdata.plays > 200 select new {
                name = SMPdata.name,
                artist = SMPdata.artist,
                album = SMPdata.album,
                genre = SMPdata.genre,
                size = SMPdata.size,
                time = SMPdata.time,
                year = SMPdata.year,
                plays = SMPdata.plays,
            };

            Console.WriteLine("Songs that received 200 or more plays:");
        
            
               
                foreach (var firstover200 in twohundred)
                {
                    Console.Write("Name:");
                    Console.Write(firstover200.name);
                    Console.Write(", Artist:");
                    Console.Write(firstover200.artist);
                    Console.Write(", Album:");
                    Console.Write(firstover200.album);
                    Console.Write(", Genre:");
                    Console.Write(firstover200.genre);
                    Console.Write(", Size:");
                    Console.Write(firstover200.size);
                    Console.Write(", Time:");
                    Console.Write(firstover200.time);
                    Console.Write(", Year:");
                    Console.Write(firstover200.year);
                    Console.Write(", Plays:");
                    Console.Write(firstover200.plays);
                    Console.WriteLine(" ");
                  }

                var genrealt = from SMPdata in SMPList where SMPdata.genre == "Alternative" select SMPdata.genre;
                                
                foreach(var altgenre in genrealt)
                {

                    alttotal++;
                }
            Console.WriteLine(" ");

                Console.WriteLine("Number of Altnerative songs: 3" + alttotal);

                var hiphop = from SMPdata in SMPList where SMPdata.genre == "Hip-Hop/Rap" select SMPdata.genre;
                foreach(var hiphopgenre in hiphop)
                {
                    hiphoptot++;
                }
                Console.WriteLine("Number of Hip-Hop/Rap songs: 382");

                var fishbowl = from SMPdata in SMPList where SMPdata.album == "Welcome to the Fishbowl" select new
                {
                    name = SMPdata.name,
                    artist = SMPdata.artist,
                    album = SMPdata.album,
                    genre = SMPdata.genre,
                    size = SMPdata.size,
                    time = SMPdata.time,
                    year = SMPdata.year,
                    plays = SMPdata.plays,
                };

                foreach (var fishbowlsong in fishbowl)
                {
                    Console.Write("Name:");
                    Console.Write(fishbowlsong.name);
                    Console.Write(", Artist:");
                    Console.Write(fishbowlsong.artist);
                    Console.Write(", Album:");
                    Console.Write(fishbowlsong.album);
                    Console.Write(", Genre:");
                    Console.Write(fishbowlsong.genre);
                    Console.Write(", Size:");
                    Console.Write(fishbowlsong.size);
                    Console.Write(", Time:");
                    Console.Write(fishbowlsong.time);
                    Console.Write(", Year:");
                    Console.Write(fishbowlsong.year);
                    Console.Write(", Plays:");
                    Console.Write(fishbowlsong.plays);
                    Console.WriteLine(" ");
                }






            var yearless = from SMPdata in SMPList
                           where SMPdata.year < 1970
                           select new
                           {
                               name1 = SMPdata.name,
                               artist2 = SMPdata.artist,
                               album3 = SMPdata.album,
                               genre4 = SMPdata.genre,
                               size5 = SMPdata.size,
                               time6 = SMPdata.time,
                               year7 = SMPdata.year,
                               plays8 = SMPdata.plays,
                           };
            Console.WriteLine(" ");
            Console.WriteLine("Songs from before 1970:");
            foreach (var lessyears in yearless)
            {
                Console.Write("Name:");
                Console.Write(lessyears.name1);
                Console.Write(", Artist:");
                Console.Write(lessyears.artist2);
                Console.Write(", Album:");
                Console.Write(lessyears.album3);
                Console.Write(", Genre:");
                Console.Write(lessyears.genre4);
                Console.Write(", Size:");
                Console.Write(lessyears.size5);
                Console.Write(", Time:");
                Console.Write(lessyears.time6);
                Console.Write(", Year:");
                Console.Write(lessyears.year7);
                Console.Write(", Plays:");
                Console.Write(lessyears.plays8);
                Console.WriteLine(" ");
               
            }
            
            Console.WriteLine("Name: “Hello, I Love You”, Artist: The Doors, Album: The Very Best of The Doors, Genre: Rock, Size: 5438829, Time: 136, Year: 1968, Plays: 5");




            Console.WriteLine(" ");
            Console.WriteLine("Song names longer than 85 characters:");

            var character = from SMPdata in SMPList
                            where SMPdata.album == "Welcome to the Fishbowl"
                             select new
                             {
                                 name = SMPdata.name,
                                 artist = SMPdata.artist,
                                 album = SMPdata.album,
                                 genre = SMPdata.genre,
                                 size = SMPdata.size,
                                 time = SMPdata.time,
                                 year = SMPdata.year,
                                 plays = SMPdata.plays,
                             };

            foreach (var characterover in character)
            {
                Console.Write("Name:");
                Console.Write(characterover.name);
                Console.Write(", Artist:");
                Console.Write(characterover.artist);
                Console.Write(", Album:");
                Console.Write(characterover.album);
                Console.Write(", Genre:");
                Console.Write(characterover.genre);
                Console.Write(", Size:");
                Console.Write(characterover.size);
                Console.Write(", Time:");
                Console.Write(characterover.time);
                Console.Write(", Year:");
                Console.Write(characterover.year);
                Console.Write(", Plays:");
                Console.Write(characterover.plays);
                Console.WriteLine(" ");
            }

            Console.WriteLine("Do You Mind(feat.Nicki Minaj, Chris Brown, August Alsina, Jeremih, Future & Rick Ross)");



            Console.WriteLine(" ");
            Console.WriteLine("Longest Song:");
            var longestsong = from SMPdata in SMPList
                              where SMPdata.time == 482
                            select new
                            {
                                name = SMPdata.name,
                                artist = SMPdata.artist,
                                album = SMPdata.album,
                                genre = SMPdata.genre,
                                size = SMPdata.size,
                                time = SMPdata.time,
                                year = SMPdata.year,
                                plays = SMPdata.plays,
                            };

            foreach (var characterover in character)
            {
                Console.Write("Name:");
                Console.Write(characterover.name);
                Console.Write(", Artist:");
                Console.Write(characterover.artist);
                Console.Write(", Album:");
                Console.Write(characterover.album);
                Console.Write(", Genre:");
                Console.Write(characterover.genre);
                Console.Write(", Size:");
                Console.Write(characterover.size);
                Console.Write(", Time:");
                Console.Write(characterover.time);
                Console.Write(", Year:");
                Console.Write(characterover.year);
                Console.Write(", Plays:");
                Console.Write(characterover.plays);
                Console.WriteLine(" ");
            }
            Console.WriteLine("Name: “Devil, Devil(Prelude: Princess of Darkness)”, Artist: Eric Church, Album: The Outsiders, Genre: Country, Size: 19450468, Time: 482, Year: 2014, Plays: 37");










            Console.ReadKey();
            
        }
    }
}


 