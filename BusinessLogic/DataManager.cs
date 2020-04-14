using BusinessLogic.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DataManager
    {
        string fileNameSave = "Workers.json";
        string directorySave = "./Data/";
        string savePath;
        string directoryBackup = "./Backup/";

        public DataManager() 
        {
            savePath = directorySave + fileNameSave;
        }

        public DataManager(string dataPath)
        {
            this.savePath = dataPath;
        }

        public async Task Save(List<Person> people)
        {
            string json = JsonConvert.SerializeObject(people);
            CheckAndCreateDirectory(directorySave);
            using (StreamWriter sw = new StreamWriter(savePath, false))
            {
                await sw.WriteAsync(json);
            }
        }

        public async Task<List<Person>> Load()
        {
            List<Person> people = new List<Person>();
            if (File.Exists(savePath))
            {
                using (StreamReader sr = new StreamReader(savePath))
                {
                    string json = await sr.ReadToEndAsync();
                    people = JsonConvert.DeserializeObject<List<Person>>(json);
                }
            }
            return people;
        }

        public async Task<List<Person>> Load(string path)
        {
            List<Person> people = new List<Person>();
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string json = await sr.ReadToEndAsync();
                    people = JsonConvert.DeserializeObject<List<Person>>(json);
                }
            }
            Save(people);
            return people;
        }

        public async Task Backup()
        {
            string backupPath = directoryBackup + DateTime.Now.ToString("dd_MM_yyyy hh_mm_ss") + ".json";
            CheckAndCreateDirectory(directorySave);
            CheckAndCreateDirectory(directoryBackup);
            if (!File.Exists(savePath))
            {
                return;
            }
            using (StreamReader sr = new StreamReader(savePath))
            {
                string json = await sr.ReadToEndAsync();
                using (StreamWriter sw = new StreamWriter(backupPath, false))
                {
                    await sw.WriteAsync(json);
                }
            }
        }

        public void Export(string path, string stringToExport)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(stringToExport);
            }
        }

        private void CheckAndCreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
