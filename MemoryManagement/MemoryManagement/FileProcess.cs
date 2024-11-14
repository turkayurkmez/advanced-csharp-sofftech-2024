using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class FileProcess : IDisposable
    {
        private FileStream stream;
        public FileProcess()
        {
            stream = new FileStream("sample.txt", FileMode.OpenOrCreate);

        }

        public void Dispose()
        {
            stream.Dispose();
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        public void WriteToFile(byte[] textArray)
        {
            stream.Write(textArray);
            //stream.Close();
        }

        public void Zipped(string path)
        {
            using (FileStream compressed = File.Create(path))
            using (GZipStream zipping = new GZipStream(compressed, CompressionLevel.SmallestSize))
            stream.CopyTo(zipping);



        }

    }
}
