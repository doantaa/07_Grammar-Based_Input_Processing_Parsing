using System.Text.Json;
namespace jurnal_modul7_21104009;

// Class yang merepresentasikan definisi glosarium
public class GlossDef
{
    public string Para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}

// Class yang merepresentasikan entri glosarium
public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public string GlossSee { get; set; }
}

// Class yang merepresentasikan daftar entri glosarium
public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

// Class yang merepresentasikan bagian glosarium
public class GlossDiv
{
    public string Title { get; set; }
    public GlossList GlossList { get; set; }
}

// Class yang merepresentasikan struktur utama glosarium
public class Glossary
{
    public string Title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

// Class root untuk glosarium dalam JSON
public class GlossaryRoot
{
    public Glossary Glossary { get; set; }
}

// Class utama untuk membaca dan menampilkan data glosarium dari file JSON
class GlossaryItem21104009
{
    // Metode untuk membaca data JSON dari file dan menampilkan informasi glosarium
    public void ReadJSON(string filePath)
    {
        try
        {
            // Membaca isi file JSON
            string jsonContent = File.ReadAllText(filePath);
            
            // Melakukan deserialisasi JSON ke dalam objek GlossaryRoot
            GlossaryRoot glossaryRoot = JsonSerializer.Deserialize<GlossaryRoot>(jsonContent, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            // Mendapatkan entri glosarium
            var glossEntry = glossaryRoot?.Glossary?.GlossDiv?.GlossList?.GlossEntry;
            
            // Menampilkan data hasil deserialisasi ke console jika entri ditemukan
            if (glossEntry != null)
            {
                Console.WriteLine("=== GlossEntry Details ===");
                Console.WriteLine($"ID: {glossEntry.ID}");
                Console.WriteLine($"SortAs: {glossEntry.SortAs}");
                Console.WriteLine($"GlossTerm: {glossEntry.GlossTerm}");
                Console.WriteLine($"Acronym: {glossEntry.Acronym}");
                Console.WriteLine($"Abbrev: {glossEntry.Abbrev}");
                Console.WriteLine($"GlossDef: {glossEntry.GlossDef.Para}");
                Console.WriteLine($"GlossSee: {glossEntry.GlossSee}");
            }
            else
            {
                Console.WriteLine("Error: GlossEntry tidak ditemukan dalam JSON.");
            }
        }
        catch (Exception ex)
        {
            // Menangani kesalahan saat membaca atau memproses file JSON
            Console.WriteLine($"Error reading JSON: {ex.Message}");
        }
    }
}
