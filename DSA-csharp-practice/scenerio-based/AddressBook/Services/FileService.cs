
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Services
{
    public class FileService
    {
        public static void WriteJson(string path, List<ContactPerson> persons)
        {
            string json = JsonSerializer.Serialize(persons);
            File.WriteAllText(path, json);
        }

        public static List<ContactPerson> ReadJson(string path)
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<ContactPerson>>(json);
        }
    }
}
