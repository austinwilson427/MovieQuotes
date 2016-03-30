using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Net;

namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sound = new SoundPlayer();
            var soundList = new string[3];



            soundList[0] = "http://www.wavsource.com/snds_2016-01-10_6357263721580594/movies/misc/catch-22_help_him.wav";
            soundList[1] = "http://www.wavsource.com/snds_2016-01-10_6357263721580594/movies/caddyshack/all_she_wrote.wav";
            soundList[2] = "http://www.wavsource.com/snds_2016-01-10_6357263721580594/movies/misc/american_pie_band_camp2_y.wav";



            var rnd = new Random();
            int result = rnd.Next(0, 3);

            var player = new SoundPlayer("http://www.wavsource.com/snds_2016-01-10_6357263721580594/movies/misc/catch-22_help_him.wav");
            player.PlaySync();


            /*var player = new SoundPlayer(soundList[result]);
            player.PlaySync();*/

        }
    }
}
