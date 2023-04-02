using System.IO;
using System.Text.RegularExpressions;

public class FileStreamHandler
{
    public void AppendText(string filePath, string text)
    {
        using (var stream = new StreamWriter(filePath, true))
        {
            stream.Write(text);
        }
    }

    public void CopyFile(string sourceFilePath, string destinationFilePath)
    {
        using (var sourceStream = new FileStream(sourceFilePath, FileMode.Open))
        using (var destinationStream = new FileStream(destinationFilePath, FileMode.Create))
        {
            sourceStream.CopyTo(destinationStream);
        }
    }

    public string ReadText(string filePath)
    {
        using (var stream = new StreamReader(filePath))
        {
            return stream.ReadToEnd();
        }
    }

    public void RemoveRows(string filePath, string pattern)
    {
        var tempFilePath = Path.GetTempFileName();
        using (var sourceStream = new FileStream(filePath, FileMode.Open))
        using (var destinationStream = new FileStream(tempFilePath, FileMode.Create))
        using (var reader = new StreamReader(sourceStream))
        using (var writer = new StreamWriter(destinationStream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (!string.IsNullOrEmpty(line) && !Regex.IsMatch(line, pattern))
                {
                    writer.WriteLine(line);
                }
            }
        }
        File.Delete(filePath);
        File.Move(tempFilePath, filePath);
    }

    public void WriteText(string filePath, string text)
    {
        using (var stream = new StreamWriter(filePath, false))
        {
            stream.Write(text);
        }
    }
}