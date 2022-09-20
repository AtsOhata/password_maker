using System.Collections.Generic;
using System.IO;
namespace PasswordMaker
{
    class FileUtility
    {
        /// <summary>Read text from the file and return as List&lt;string&gt;</summary>
        /// <param name="FilePath">File path</param>
        /// <returns>Text of the file</returns>
        static public List<string> ReadFileAsList(string FilePath)
        {
            List<string> result = new();
            using (StreamReader sr = new(FilePath))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    result.Add(line);
                }
            }
            return result;
        }
    }
}
