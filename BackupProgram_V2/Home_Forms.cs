using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using ClosedXML.Excel;
using System.Drawing;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Functions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;

namespace BackupProgram_V2
{
    public partial class Home_Forms : Form
    {
        public Home_Forms()
        {
            InitializeComponent();
        }
        List<string> pathList = new List<string>();

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static string elapsedTime { get; set; }

        static void writeToExcel()
        {
            string path = @"History.xlsx";

            IXLWorkbook wb = new XLWorkbook(path);
            IXLWorksheet ws = wb.Worksheet(1);
            DateTime datetime = DateTime.Today;

            string date = datetime.ToString("dd/MM/yyyy");
            int crc = 1;
            int row = 1;
            string time = elapsedTime;

            try
            {
                for (int i = 0; i < crc; i++)
                {
                    if (ws.Cell(row, 1).IsEmpty())
                    {
                        ws.Cell(row, 1).Value = date;
                        ws.Cell(row, 2).Value = time;
                    }
                    else
                    {
                        row++;
                        crc++;
                    }
                }

                wb.SaveAs(path);
            }
            catch
            {
                MessageBox.Show("Excel konnte nicht geöffnet oder gespeichert werden");
            }
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

        private void add_button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string path = textBox1.Text;
            var regex = new Regex(@"\s");

            if (String.IsNullOrEmpty(path))
            {
                MessageBox.Show("Du kannst nicht Null adden");
            }
            else
            {
                if (regex.IsMatch(path))
                {
                    string short_path = path.Remove(0, 1);
                    richTextBox2.Text += short_path + "\n";
                    pathList.Add(short_path);
                }
                else
                {
                    richTextBox2.Text += path + "\n";
                    pathList.Add(path);
                }
            }
            textBox1.Text = " ";
        }

        private void start_button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();  //Erstellung der Stopuhr
            stopwatch.Start();                      //Start der Stopuhr

            richTextBox1.Text = "";                 //Richtextbox einmal Clearen

            //Deklarierung -----------------------------------------------------

            DateTime datetime = DateTime.Today;

            string date = datetime.ToString("dd/MM/yyyy");
            string dest = Destination_tbx.Text + date;
            string shrt = "";

            // Anfang der Arbeit -------------------------------------------------

            Directory.CreateDirectory(dest);

            for (int i = 0; i < pathList.Count; i++)
            {
                string sourceDirectory = pathList.ElementAt(i);
                shrt = sourceDirectory.Substring(sourceDirectory.LastIndexOf("\\") + 1);
                string subfolder = "G:/Backup/Backup " + date + "/" + shrt;
                string targetDirectory = subfolder;

                if (Directory.Exists(sourceDirectory))
                {
                    Directory.CreateDirectory(subfolder);
                    Copy(sourceDirectory, targetDirectory);
                }

            }    //Bearbeitung fuer die Erstellung ders Pfades zum Backup

            stopwatch.Stop();                       //Stop der Stopuhr
            TimeSpan ts = stopwatch.Elapsed;        //Zeitspanne der Stopuhr in eine Variable umwandeln
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds / 10); //Ausgabe der Gestoppten Zeit in eine String

            MessageBox.Show("Fertig");

            writeToExcel();
        }
        private void Write_to_drive_btn_Click(object sender, EventArgs e)
        {
            string save = @"saves\settings\Backup_Saves" + " " + DateTime.Today.ToString("d") + ".txt";

            File.WriteAllText(save,"Destination" + "\n" + Destination_tbx.Text + "\n" + "\n" + "Paths that are copied " + "\n" + "\n" + richTextBox2.Text);
            MessageBox.Show("Settings wurden gespeichert");
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Clear();
            pathList.Clear();
            richTextBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            History_Forms f2 = new History_Forms();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {       
            this.Close();
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings_Forms f4 = new Settings_Forms();
            f4.ShowDialog();
            this.Close();
        }

        private void saves_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saves_Forms f3 = new Saves_Forms();
            f3.ShowDialog();
            this.Close();
        }
    }
}
