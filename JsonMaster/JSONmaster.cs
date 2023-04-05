using System.Text.Json;

namespace MyLib.JSONFile
{
    public class JSON
    {
        static JsonSerializerOptions default_option = new JsonSerializerOptions { WriteIndented = true };
        public static bool Save<T>(T object_to_save, string directory, string file_name)
        {
            try
            {
                if(!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                string file_path = $"{directory}\\{file_name}.json";
                string json_string = JsonSerializer.Serialize(object_to_save, default_option);
                using StreamWriter sw = new StreamWriter(file_path);
                sw.WriteLine(json_string);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Algo deu errado ao salvar o arquivo: \"{file_name}.json\" no caminho especificado. ({directory})");
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static T Load<T>(string full_path) {
            try
            {
                using FileStream stream = File.Open(full_path, FileMode.Open);
                return JsonSerializer.Deserialize<T>(stream, default_option);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Algo deu errado ao carregar o arquivo: \"{full_path}\".");
                throw ex;
            }
            
        }
    }
}
