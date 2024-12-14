using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ООП_Курсовая_Шмоленко
{
    public class DataBase
    {
        public static readonly string rash = ".DataBase";
        private List<Medicament> _Medicaments;
        public List<Medicament> GetMedicaments() {  return _Medicaments; }

        public DataBase() 
        {
            _Medicaments = new List<Medicament>();
        }
        public void load(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path), "Path cannot be null or empty.");

            using (TextReader reader = new StreamReader(path))
            {
                string? tmpLine = reader.ReadToEnd(); // Считываем весь файл
                if (string.IsNullOrEmpty(tmpLine))
                    throw new InvalidOperationException("Loaded data is empty.");

                List<Medicament>? Medicaments = JsonSerializer.Deserialize<List<Medicament>>(tmpLine);
                if (Medicaments == null)
                    throw new InvalidOperationException("Failed to deserialize JSON data.");

                _Medicaments = Medicaments;
            }
        }
        public void save(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path), "Path cannot be null or empty.");

            using (TextWriter writer = new StreamWriter(path))
            {
                var MedicamentsJson = JsonSerializer.Serialize(_Medicaments, Context.Default.ListMedicament);
                writer.WriteLine(MedicamentsJson); // Записываем данные в файл
            }
        }


    }

    public record Medicament(
        string _Medicine,
        string _Disease,
        int _Price,
        string _Name,
        int _Quantity
        );

    [JsonSerializable(typeof(List<Medicament>))]
    internal partial class Context : JsonSerializerContext
    {
    }
}
