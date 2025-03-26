namespace tpmodul7_kelompok_4;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa21104009 dataMahasiswa = new DataMahasiswa21104009();
        dataMahasiswa.ReadJSON();
        
        KuliahMahasiswa21104009 kuliahMahasiswa = new KuliahMahasiswa21104009();
        kuliahMahasiswa.ReadJSON();
    }
}