using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5_1302200016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // menampilkan program atau informasi SayaTubeVideo
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muhamad Iqbal F");
            video.IncreasePlayCount(6540);
            video.PrintVideoDetails();

            // Percobaan Judul Video di set Null
            video.SetJudul(null);

            // Percobaan IncreasePlayCount di set ke 10.000.000
            video.IncreasePlayCount(10000001);
            video.PrintVideoDetails();

            // Percobaan IncreasePlayCount ketika di set melebihi batas maksimal
            for (int i = 0; i < 220; i++)
            {
                video.IncreasePlayCount(9999999);
            }
            video.PrintVideoDetails();
        }
    }
}
