using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulSample.DesktopApp.Business
{
    public class UploadOjbect
    {
        public string ContentBase64 { get; set; }
        public string FullName { get; set; }

        public UploadOjbect()
        {

        }

        public UploadOjbect(Stream stream, string fileName)
        {
            Byte[] inArray = new Byte[(int)stream.Length];
            stream.Read(inArray, 0, (int)stream.Length);

            ContentBase64 = Convert.ToBase64String(inArray);
            FullName = fileName;
        }

        public UploadOjbect(string fullPathFile, string fileName)
        {
            if (string.IsNullOrEmpty(fullPathFile) || string.IsNullOrEmpty(fileName))
            {
                return;
            }

            using (var sr= new FileStream(fullPathFile,FileMode.Open))
            {
                Byte[] inArray = new Byte[(int)sr.Length];
                sr.Read(inArray, 0, (int)sr.Length);

                ContentBase64 = Convert.ToBase64String(inArray);
            }
            FullName = fileName;
        }

    }
}
