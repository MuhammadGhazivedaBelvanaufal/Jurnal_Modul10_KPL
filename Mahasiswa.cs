namespace Jurnal10_1302220011_KPL
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string Nim { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }
        

        public Mahasiswa(string nama, string nim, List<string> course, int year)
        {
            Name = nama;
            Nim = nim;
            Course = course;
            Year = year;
            
        }

    }
}
