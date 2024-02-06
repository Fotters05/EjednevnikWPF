using System.IO;
using Newtonsoft.Json;

public static class NoteSerializer
{
    public static void Serialize<T>(T obj, string filePath)
    {
        string json = JsonConvert.SerializeObject(obj);
        File.WriteAllText(filePath, json);
    }

    public static T Deserialize<T>(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<T>(json);
    }
}