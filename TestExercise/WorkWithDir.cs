using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using TestExercise.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace TestExercise.Data
{
    class WorkWithDir
    {
        public CancellationTokenSource cts { get; private set; }

        public WorkWithDir() { cts = new CancellationTokenSource(); }


        /// <summary>
        /// Полностью отчищает FileNameList и ProfileList и заполняет их новыми значениями 
        /// </summary>
        /// <param name="fileNameList"></param>
        /// <param name="profiles"></param>
        public void UpdateInfo(List<string> fileNameList, List<Profile> profiles)
        {
            UpdateNameList(fileNameList);
            UpdateProfileList(fileNameList, profiles);
            cts.Dispose();
            cts = new CancellationTokenSource();
        }

        /// <summary>
        /// Добавляет указанный путь в список fileName (без отчищения)
        /// </summary>
        /// <param name="nameList"></param>
        /// <param name="path"></param>
        public void UpdateNameList(List<string> fileNameList, string path)
        {
            if (File.Exists(path))
                fileNameList.Add(path);
        }

        /// <summary>
        /// Полностью отчищает список путей до файлов и добавляет все пути к *.jpg по пути из настроек
        /// </summary>
        /// <param name="fileNameList"></param>
        private void UpdateNameList(List<string> fileNameList)
        {
            try
            {
                fileNameList.Clear();
                Directory.GetFiles(Config.ImageSrcPath).Where(i => Path.GetExtension(i) == ".jpg").
                    ToList().ForEach(i => fileNameList.Add(i));
                fileNameList.Sort(ComparisonStringDateCreation);
                fileNameList.Reverse();
            }
            catch
            {
                cts = new CancellationTokenSource();
                //    File.WriteAllText(Config.logPath, ex.Message + $"\nDate: {DateTime.Now}\n");
            }
        }

        private int ComparisonStringDateCreation(string str1, string str2)
        {
            if (cts.Token.IsCancellationRequested)
                Thread.CurrentThread.Abort();
            return DateTime.Compare(File.GetCreationTime(str1), File.GetCreationTime(str1));
        }

        /// <summary>
        /// Создает новый экземпляр Profile по указаному имени файла и заносит его в ProfileList (без отчищения)
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="profiles"></param>
        public void UpdateProfileList(string fileName, List<Profile> profiles)
        {
            profiles.Add(CutFileName(fileName));
        }

        /// <summary>
        /// Полностью очищает указанный ProfileList, заполняет его новыми Profile и сортирует их по времени создания
        /// </summary>
        /// <param name="fileNameList"></param>
        /// <param name="profiles"></param>
        private void UpdateProfileList(List<string> fileNameList, List<Profile> profiles)
        {
                profiles.Clear();
              //  foreach (string fileName in fileNameList)
                for (int i = 0; i < fileNameList.Count && i < Config.MaxCountItem; i++)
                    profiles.Add(CutFileName(fileNameList[i]));
            //    profiles.Sort(Profile.ComparisonProfileDateCreation);
              //  profiles.Reverse();
        }

        /// <summary>
        /// Обрабатываем путь до файла и создаем новый Profile
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private Profile CutFileName(string fileName)
        {
            string[] str = fileName.Split('_');

            return new Profile(familyName: Path.GetFileName(str[0]),
                               firstName: str[1],
                               secondName: str[2],
                               temperature: float.Parse(str[3].Remove(str[3].Length - 4).Replace('.', ',')),
                               photo: Image.FromFile(fileName),
                               dateCreation: File.GetCreationTime(fileName));
        }
    }
}
