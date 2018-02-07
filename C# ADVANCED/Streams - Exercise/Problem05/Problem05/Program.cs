using System;
using System.Collections.Generic;
using System.IO;

namespace Problem05
{
    class Program
    {
        static void Slice(string sourceFilePath, string destinationPath, int parts)
        {
            string extension = new FileInfo(sourceFilePath).Extension;
            long sourceFileSize = new FileInfo(sourceFilePath).Length;
            long sizePerPart = (long)Math.Ceiling((decimal)sourceFileSize / parts);
            long buffersPerPart = (long)Math.Ceiling((decimal)sizePerPart / 4096);

            byte[] buffer = new byte[4096];
            using (var sourceFile = new FileStream(sourceFilePath, FileMode.Open))
            {
                for (int partsCounter = 0; partsCounter < parts; partsCounter++)
                {
                    using (var destinationFile = new FileStream(destinationPath + @"\Part-" + partsCounter + extension, FileMode.Create))
                    {
                        for (int buffersCounter = 0; buffersCounter < buffersPerPart; buffersCounter++)
                        {
                            int bytesReadCount = sourceFile.Read(buffer, 0, buffer.Length);
                            if (bytesReadCount == 0) return;
                            destinationFile.Write(buffer, 0, bytesReadCount);
                        }
                    }
                }
            }
        }

        static void Assemble(List<string> filePaths, string destinationDirectory)
        {
            if (filePaths.Count == 0) return;

            byte[] buffer = new byte[4096];
            using (var destinationFile = new FileStream(destinationDirectory + @"\assembled" + new FileInfo(filePaths[0]).Extension, FileMode.Create))
            {
                foreach (string filePath in filePaths)
                {
                    using (var sourceFile = new FileStream(filePath, FileMode.Open))
                    {
                        while (true)
                        {
                            int bytesRead = sourceFile.Read(buffer, 0, buffer.Length);
                            if (bytesRead == 0) break;
                            destinationFile.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
