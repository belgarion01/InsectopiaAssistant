using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace InsectopiaHelper
{
    public static class SaveUtility
    {
        public static string ApplicationPath => System.AppDomain.CurrentDomain.BaseDirectory;
        public static string SAVE_CHARACTER_FOLDER_PATH => Path.Combine(APPLICATION_SAVE_PATH,  "SavedCharacters");
        public static string APPLICATION_SAVE_PATH => Path.Combine(ApplicationPath, "UserSave");

        public static void SaveCharacter(Intre intre)
        {
            string json = JsonConvert.SerializeObject(intre, Formatting.Indented);

            if (!Directory.Exists(SAVE_CHARACTER_FOLDER_PATH))
            {
                Directory.CreateDirectory(SAVE_CHARACTER_FOLDER_PATH);
            }

            File.WriteAllText(Path.Combine(SAVE_CHARACTER_FOLDER_PATH, $"{intre.ID}.json"), json);
        }

        public static List<Intre> LoadCharacters()
        {
            if (!Directory.Exists(SAVE_CHARACTER_FOLDER_PATH))
            {
                Directory.CreateDirectory(SAVE_CHARACTER_FOLDER_PATH);
            }

            List<Intre> loadedCharacters = new List<Intre>();
            string[] files = Directory.GetFiles(SAVE_CHARACTER_FOLDER_PATH, "*.json");

            foreach (string file in files)
            {
                Intre loadedCharacter = JsonConvert.DeserializeObject<Intre>(File.ReadAllText(file));
                loadedCharacters.Add(loadedCharacter);
            }

            return loadedCharacters;
        }

        public static bool DeleteCharacter(Intre intre)
        {
            string characterSavePath = GetCharacterSavePath(intre);

            if (File.Exists(characterSavePath))
            {
                File.Delete(characterSavePath);
                return true;
            }

            return false;
        }

        private static string GetCharacterSavePath(Intre intre)
        {
            return Path.Combine(SAVE_CHARACTER_FOLDER_PATH, $"{intre.ID}.json");
        }
    }
}
