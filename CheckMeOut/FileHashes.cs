using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMeOut
{
    public class FileHashInfo
    {
        public string filename { get; set; }
        public string filepath { get; set; }

        public bool foundHash { get { return Form1.md5Hashes.ContainsKey(md5) || Form1.sha1Hashes.ContainsKey(sha1); } }
        public string md5 { get; set; }
        public bool md5Found { get { return Form1.md5Hashes.ContainsKey(md5); } }
        public string sha1 { get; set; }
        public bool sha1Found { get { return Form1.sha1Hashes.ContainsKey(sha1); } }
    }
}
