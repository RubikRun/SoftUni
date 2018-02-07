using System;
using System.IO;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = "copyMe.png";
            string destinationFilePath = "copyMe - Copy.png";

            using (var sourceFile = new FileStream(sourceFilePath, FileMode.Open))
            {
                using (var destinationFile = new FileStream(destinationFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        var readBytesCount = sourceFile.Read(buffer, 0, buffer.Length);
                        if (readBytesCount == 0)
                        {
                            break;
                        }
                        destinationFile.Write(buffer, 0, readBytesCount);
                    }
                }
            }
        }
    }
}
