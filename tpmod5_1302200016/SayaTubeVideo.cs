using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5_1302200016
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        // Mendeklarasikan Constructor dengan parameter "title"
        public SayaTubeVideo(string title)
        {
            this.title = title;
            SetJudul(title);
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
        }

        // Menambahkan Rules untuk judul/title
        public void SetJudul(string title)
        {
            if (title == null) return;
            if (title.Length > 100) return;

            this.title = title;
        }

        // Menambahkan playCount dengan parameter "tambah" dan menambahkan limit playcount
        public void IncreasePlayCount(int tambah)
        {
            this.playCount += tambah;
            if (tambah > 10000000) return;

            try
            {
                this.playCount = checked(this.playCount + tambah);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // menambahkan informasi video (ID, Judul, Putar)
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id + ", Judul: " + title + ", Putar : " + playCount);
        }

    }
}
