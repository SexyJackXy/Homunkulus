using Homunkulus.Helper;

namespace Homunkulus
{
    internal class manfFile
    {
        public Util util = new Util();

        public void CreateFile(string filePath, string fileName)
        {
            DirectoryInfo dirIfno = new DirectoryInfo(filePath);
            if (!dirIfno.Exists)
            {
                throw new ArgumentException($"The Directory {filePath} doesn't exsists");
            }
            File.Create(Path.Combine(filePath, fileName));
        }
        public void DeleteFile(string filePath) { }
        public void ReadFile(string filePath) { }
        public void StartSection(string path, string sektion)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));
            if (sektion == null)
                throw new ArgumentNullException(nameof(sektion));

            util.UnlockFile(path, util.IsFileLocked(new FileInfo(path)));

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write("[" + sektion + "]");
            }
        }
        public void EndSection()
        {

        }
        public void WriteLine(string line) { }
    }
}
