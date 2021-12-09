using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    public class Song
    {
        private string fileName;
        private string filePath;

        public Song() { }
        public Song (string fileName, string filePath)
        {
            this.fileName = fileName;
            this.filePath = filePath;
        }
        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }
        public string FilePath
        {
            get
            {
                return this.filePath;
            }
            set
            {
                this.filePath = value;
            }
        }
    }
}
