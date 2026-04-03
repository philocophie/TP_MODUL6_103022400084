using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TP_MODUL6_103022400084
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;
        public SayaMusicTrack(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(title != null, "Title tidak boleh null");
            if (title != null)
            {
                Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter");
            }
            Debug.Assert(count <= 10000000, "Input terlalu besar");
            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow");
            }
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
