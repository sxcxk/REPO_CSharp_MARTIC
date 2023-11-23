using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Construction.Service.Core
{
   public class FileList
    {
        public FileList()
        {

        }

        public List<string> GetDirectory(string rootdir, bool subFolders)
        {
            List<string> directory = new List<string>();
            try
            {
                string[] files = System.IO.Directory.GetFiles(@rootdir);
                string[] folders = System.IO.Directory.GetDirectories(@rootdir);

                for (int i = 0; i < files.Length; i++)
                {
                    directory.Add(files[i].ToString());
                }

                if (subFolders == true)
                {
                    for (int i = 0; i < folders.Length; i++)
                    {
                        directory.AddRange(GetDirectory(folders[i], subFolders));
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return directory;
        }
    }
}
