using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading;
using System.Text.RegularExpressions;
using static System.Console;

namespace POE1
{
    internal class Program
    {
        private string recordPath;

        static void Main(string[] args)
        {

        }

        public Program()
        {
            // Setup the audio path
            string path_directory = AppDomain.CurrentDomain.BaseDirectory;
            // audio file 
            recordPath = Path.Combine(path_directory, "C:\\Users\\Student\\source\\repos\\Part1_POE\\PTT-20260315-WA0023 (online-audio-converter.com).wav");
        }
          

        public void PlayVoice()
        {
            try
            {
                using (SoundPlayer speechObj = new SoundPlayer(recordPath))
                {
                    speechObj.PlaySync();
                }
            }
            catch (Exception error)
            {
                WriteLine($"Error. Failed to play audio {error.Message}");
            }
        }


    }
}
