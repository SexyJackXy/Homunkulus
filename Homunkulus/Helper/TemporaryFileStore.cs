namespace Homunkulus.Helper
{
    internal class TemporaryFileStore
    {
        public List<FileInfo> OldFiles { get; set; } = new List<FileInfo>();
        public List<string> Direcorty { get; set; }
        public List<string> FileName { get; set; }
        public List<DirectoryInfo> OldBackups { get; set; } = new List<DirectoryInfo>();

        public TemporaryFileStore(string destination)
        {
            Direcorty = new List<string>();
            FileName = new List<string>();

            var today = DateTime.Now;
            var dirList = Directory.GetDirectories(destination, "*.*", SearchOption.TopDirectoryOnly)
                                    .Select(dir => new DirectoryInfo(dir))
                                    .Where(dirInfo => dirInfo.LastWriteTime < today)
                                    .ToList();

            var allOldFiles = new List<FileInfo>();

            foreach (var dir in dirList)
            {
                var filesInDir = Directory.GetFiles(dir.FullName, "*.*", SearchOption.AllDirectories).ToList();
                foreach (var file in filesInDir)
                {
                    var fi = new FileInfo(file);
                    allOldFiles.Add(fi);
                }
            }

            OldBackups = dirList;
            OldFiles = allOldFiles;

            if (OldFiles == null) return; 

            foreach (var file in OldFiles)
            {
                if (file?.Directory == null) continue;

                var fiDir = file.Directory.ToString();
                Console.WriteLine(fiDir);
            }
        }
    }
}
