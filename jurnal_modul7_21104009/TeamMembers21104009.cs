using System.Text.Json;

// Class yang merepresentasikan anggota tim
public class TeamMember
{
    public string NIM { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
}

// Class yang merepresentasikan tim yang berisi daftar anggota
public class Team
{
    public List<TeamMember> Members { get; set; }
}

// Class utama untuk membaca dan menampilkan data anggota tim dari file JSON
class TeamMembers21104009
{
    // Metode untuk membaca data JSON dari file dan menampilkan informasi anggota tim
    public void ReadJSON(string filePath)
    {
        try
        {
            // Membaca isi file JSON
            string jsonContent = File.ReadAllText(filePath);
            
            // Melakukan deserialisasi JSON ke dalam objek Team
            Team team = JsonSerializer.Deserialize<Team>(jsonContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            
            // Menampilkan daftar anggota tim ke console
            Console.WriteLine("Team member list:");
            foreach (var member in team.Members)
            {
                Console.WriteLine($"{member.NIM} {member.FirstName} {member.LastName} ({member.Age} {member.Gender})");
            }
        }
        catch (Exception ex)
        {
            // Menangani kesalahan saat membaca atau memproses file JSON
            Console.WriteLine($"Error reading JSON: {ex.Message}");
        }
    }
}