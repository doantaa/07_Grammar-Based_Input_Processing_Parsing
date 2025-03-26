using System.Text.Json;
namespace jurnal_modul7_21104009;

// Class yang merepresentasikan alamat 
public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}

// Class yang merepresentasikan mata kuliah
public class Course
{
    public string Code { get; set; }
    public string Name { get; set; }
}

// Class yang merepresentasikan informasi beserta alamat dan mata kuliahnya
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public Address Address { get; set; }
    public List<Course> Courses { get; set; }
}

// Class utama untuk membaca dan menampilkan data dari file JSON
public class DataMahasiswa21104009
{
    // Metode untuk membaca data JSON dari file dan menampilkan informasi
    public void ReadJSON(string filePath)
    {
        try
        {
            // Membaca isi file JSON
            string jsonContent = File.ReadAllText(filePath);
            
            // Melakukan deserialisasi JSON ke dalam objek Person
            Person person = JsonSerializer.Deserialize<Person>(jsonContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            
            // Menampilkan data hasil deserialisasi ke console
            Console.WriteLine("=== Deserialized JSON Object ===");
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
            Console.WriteLine($"Gender: {person.Gender}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Address: {person.Address.StreetAddress}, {person.Address.City}, {person.Address.State}");
            Console.WriteLine("Courses:");
            foreach (var course in person.Courses)
            {
                Console.WriteLine($"  - {course.Code}: {course.Name}");
            }
        }
        catch (Exception ex)
        {
            // Menangani kesalahan saat membaca atau memproses file JSON
            Console.WriteLine($"Error reading JSON: {ex.Message}");
        }
    }
}