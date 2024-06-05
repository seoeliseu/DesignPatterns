namespace Flyweight
{
    public class Arquivo
    {
        public string FilePath { get; set; }
        public byte[] FileByte { get; set; }

        public Arquivo(string filePath)
        {
            FilePath = filePath;
            LoadFile();
        }

        private void LoadFile()
        {
            if (File.Exists(FilePath))
            {
                FileByte = File.ReadAllBytes(FilePath);
            }
            else
            {
                throw new FileNotFoundException("The specified file was not found.", FilePath);
            }
        }
    }
}
