using Newtonsoft.Json;

// Definisi kelas untuk merepresentasikan mata kuliah
public class Course
{
    public string Code { get; set; }
    public string Name { get; set; }
}

// Kelas untuk membaca JSON
public class CoursesData
{
    public List<Course> Courses { get; set; }
}

// Kelas utama sesuai dengan format yang diminta
public class KuliahMahasiswa21104009
{
    public void ReadJSON()
    {
        string filePath = "/Users/doanta/Documents/Dev/KPL/tpmodul7_kelompok_4/tp7_2_21104009.json"; 
        
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            CoursesData data = JsonConvert.DeserializeObject<CoursesData>(jsonData);
            
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < data.Courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {data.Courses[i].Code} - {data.Courses[i].Name}");
            }
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan.");
        }
    }
    
}