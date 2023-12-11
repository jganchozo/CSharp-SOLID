namespace Solution
{
    public class FileSaver
    {
        public void SaveToFile(string directoryPath, string fileName, IOuputFile report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.GenerateOutput());
        }
    }
}
