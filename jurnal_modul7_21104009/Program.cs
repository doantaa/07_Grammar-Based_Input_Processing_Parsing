using jurnal_modul7_21104009;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa21104009 dataMahasiswa = new DataMahasiswa21104009();
        dataMahasiswa.ReadJSON("/Users/doanta/Documents/Dev/KPL/KPL_DOANTA-ALOYCIUS-GINTING_21104009_SE-06-01/07_Grammar-Based_Input_Processing_Parsing/jurnal_modul7_21104009/jurnal7_1_21104009");
        
        TeamMembers21104009 teamMembers = new TeamMembers21104009();
        teamMembers.ReadJSON("/Users/doanta/Documents/Dev/KPL/KPL_DOANTA-ALOYCIUS-GINTING_21104009_SE-06-01/07_Grammar-Based_Input_Processing_Parsing/jurnal_modul7_21104009/jurnal7_2_2104009");
        
        GlossaryItem21104009 glossaryItems = new GlossaryItem21104009();
        glossaryItems.ReadJSON(
            "/Users/doanta/Documents/Dev/KPL/KPL_DOANTA-ALOYCIUS-GINTING_21104009_SE-06-01/07_Grammar-Based_Input_Processing_Parsing/jurnal_modul7_21104009/jurnal7_3_21104009");
    }
}