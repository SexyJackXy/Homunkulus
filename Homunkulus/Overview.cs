using System.Diagnostics;
using System.Text.RegularExpressions;
using ClosedXML.Excel;

namespace Homunkulus
{
    public partial class Overview : Form
    {
        List<string> folderlist = new List<string>();

        public Overview()
        {
            InitializeComponent();
        }
        public static string elapsedTime { get; set; }
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }
            try
            {
                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch
            {

            }
        }
        private void src_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = fbd.SelectedPath;
                var regex = new Regex(@"\s");

                if (String.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("You can not add nothing");
                }
                else
                {
                    if (regex.IsMatch(folder))
                    {
                        string short_path = folder.Remove(0, 1);
                        source_rtb.Text += short_path + "\n";
                        source_rtb.SelectAll();
                        source_rtb.SelectionAlignment = HorizontalAlignment.Left;
                        source_rtb.DeselectAll();
                        folderlist.Add(short_path);
                    }
                    else
                    {
                        source_rtb.Text += folder + "\n";
                        source_rtb.SelectAll();
                        source_rtb.SelectionAlignment = HorizontalAlignment.Left;
                        source_rtb.DeselectAll();
                        folderlist.Add(folder);
                    }
                }
            }
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();  
            stopwatch.Start();

            source_rtb = null;

            DateTime datetime = DateTime.Today;

            string destpath = Destination_txt.Text;
            string date = datetime.ToString("dd/MM/yyyy");
            string dest = destpath + date;
            string shrt;

            Directory.CreateDirectory(dest);

            if (folderlist.Count > 0)
            {
                for(int i = 0; i < folderlist.Count; i++)
                {
                    string sourceDirectory = folderlist.ElementAt(i);
                    shrt = sourceDirectory.Substring(sourceDirectory.LastIndexOf("\\") + 1);
                    string subfolder = destpath + "/Backup " + date + "/" + shrt;
                    string targetDirectory = subfolder;

                    MessageBox.Show(sourceDirectory, targetDirectory);

                    if (Directory.Exists(sourceDirectory))
                    {
                        Directory.CreateDirectory(subfolder);
                        Copy(sourceDirectory, targetDirectory);
                    }
                }
            }

            stopwatch.Stop();                       //Stop der Stopuhr
            TimeSpan ts = stopwatch.Elapsed;        //Zeitspanne der Stopuhr in eine Variable umwandeln
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds / 10);

            //source_rtb.Text += Environment.NewLine + "Backup Finished";
        }
        private void add_data_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string Fullpath = ofd.FileName;
                string Filename = ofd.SafeFileName;
                string folder = Fullpath.Replace(Filename, "");
                var regex = new Regex(@"\s");

                if (String.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("You can not add nothing");
                }
                else
                {
                    if (regex.IsMatch(folder))
                    {
                        string short_path = folder.Remove(0, 1);
                        source_rtb.Text += short_path + "\n";
                        source_rtb.SelectAll();
                        source_rtb.SelectionAlignment = HorizontalAlignment.Left;
                        source_rtb.DeselectAll();
                        folderlist.Add(short_path);
                    }
                    else
                    {
                        source_rtb.Text += folder + "\n";
                        source_rtb.SelectAll();
                        source_rtb.SelectionAlignment = HorizontalAlignment.Left;
                        source_rtb.DeselectAll();
                        folderlist.Add(folder);
                    }

                }
            }
        }
        private void dest_folder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = fbd.SelectedPath;
                var regex = new Regex(@"\s");

                if (String.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("You can not add nothing");
                }
                else
                {
                    if (regex.IsMatch(folder))
                    {
                        Destination_txt.Text = folder;
                    }
                    else
                    {
                        Destination_txt.Text = folder;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Today;

            int row = 1;
            string date = datetime.ToString("dd/MM/yyyy");
            string path = @"Resources\database.xlsx";
            string content;
            string destination = Destination_txt.Text;
            string lines = source_rtb.Lines.Count().ToString();
            int numberlines = Convert.ToInt32(lines) - 1;

            IXLWorkbook wb = new XLWorkbook(path); 
            IXLWorksheet ws = wb.Worksheet(1);

            ws.Cell(row, 1).Value = date;
            
            if (string.IsNullOrEmpty(destination))
            {
                ws.Cell(row, 2).Value = " - ";
            }
            else
            {
                ws.Cell(row, 2).Value = destination;
            }

            content = source_rtb.Text.Trim();
            ws.Cell(row, 3).Value = content ;

            wb.SaveAs(path);

            MessageBox.Show("Backup Saved");
        }
    }
}