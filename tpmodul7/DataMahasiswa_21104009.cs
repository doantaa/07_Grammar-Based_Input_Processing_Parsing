
using Newtonsoft.Json;

public class Mahasiswa
{
    public Nama Nama { get; set; }
    public int Nim { get; set; }
    public string Fakultas { get; set; }
}

public class Nama
{
    public string Depan { get; set; }
    public string Belakang { get; set; }
}

public class DataMahasiswa21104009
{
    private const string FilePath = "/Users/doanta/Documents/Dev/KPL/tpmodul7_kelompok_4/tp7_1_21104009.json";
        
    public void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText(FilePath);
            Mahasiswa mahasiswa = JsonConvert.DeserializeObject<Mahasiswa>(jsonContent);
            Console.WriteLine($"Nama {mahasiswa.Nama.Depan} {mahasiswa.Nama.Belakang} dengan nim {mahasiswa.Nim} dari fakultas {mahasiswa.Fakultas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi kesalahan: " + ex.Message);
        }
    }
}
    
    