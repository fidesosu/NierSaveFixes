using System;
using System.IO;

namespace FileOverwriteApp
{
    public static class FileManager
    {
        public static void BackupUnofficialFile(string sourceFilePath)
        {
            // Get the directory and file name of the UNOFFICIAL save file
            string sourceFileDirectory = Path.GetDirectoryName(sourceFilePath);
            string sourceFileName = Path.GetFileNameWithoutExtension(sourceFilePath);
            string sourceFileExtension = Path.GetExtension(sourceFilePath);

            // Form the path for the backup file in the same directory with _backup suffix
            string backupFileName = $"{sourceFileName}_backup{sourceFileExtension}";
            string backupFilePath = Path.Combine(sourceFileDirectory, backupFileName);

            try
            {
                // Copy the UNOFFICIAL save file to the backup location
                File.Copy(sourceFilePath, backupFilePath, true);

                Console.WriteLine("Backup successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Backup failed: {ex.Message}");
            }
        }
        public static void OverwriteFiles(string sourceFilePath, string overwriteFilePath)
        {
            try
            {
                using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Write))
                using (FileStream overwriteStream = new FileStream(overwriteFilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[16];
                    int bytesRead = overwriteStream.Read(buffer, 0, buffer.Length);

                    if (bytesRead < 16)
                    {
                        Console.WriteLine("The overwrite file is too small.");
                        return;
                    }

                    sourceStream.Seek(0, SeekOrigin.Begin);
                    sourceStream.Write(buffer, 0, buffer.Length);

                    Console.WriteLine("Overwrite successful.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Other file-related functions can be added here
    }
}
