using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAREPOINT_EXTRANET_CATALOG_MAKER
{
    public class Folder
    {
        List<string> pathes = new List<string>();

        public void searchFolders(string startPath)
        {
            try
            {
                foreach (string path in Directory.GetDirectories(startPath))
                {
                    Console.WriteLine(path);
                    pathes.Add(path);
                    searchFolders(path);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        public void makeFolder(String newPath)
        {
            System.IO.Directory.CreateDirectory(newPath);
        }

        public void changeAllNames(String oldName, String newName)
        {
            foreach (string path in pathes)
            {
                if(path.Contains(oldName))
                {
                    string newPath = path.Replace(oldName, newName);
                    makeFolder(newPath);
                }
            }
        }

    }
}
