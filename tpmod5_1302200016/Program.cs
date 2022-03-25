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
        }
    }
}
