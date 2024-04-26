using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ProjectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.MyComputer,
                OkRequiresInteraction = true,
                ShowNewFolderButton = true
            })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    label_ProjectFolder.Text = fbd.SelectedPath;
                }
            }
        }

        private string UnTabalize(string line)
        {
            while (line.StartsWith("    "))
            {
                line = line.Substring(4);
            }
            return line;
        }

        private string[] FolderNames;

        private void button_FolderNamesTxt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    label_FolderNamesTxt.Text = ofd.FileName;
                    FolderNames = File.ReadAllLines(ofd.FileName);
                    for (int i = 0; i < FolderNames.Length; i++)
                    {
                        FolderNames[i] = UnTabalize(FolderNames[i]);
                    }
                }
            }
        }

        private enum lineType
        {
            Main_section,
            Sub_section,
            Description
        }

        private lineType DetermineLineType(string line)
        {
            /*
            n_<text>    -> Main section
            n.n_<text>  -> Sub section
            <text>      -> Description
            */

            if (!line.Split(' ')[0].Contains('.') && int.TryParse(line.Split(' ')[0], out int i))
            {
                return lineType.Main_section;
            }

            if (line.Split(' ')[0].Contains('.') && line.Split(' ')[0].Split('.').All(s => int.TryParse(s, out int i)))
            {
                return lineType.Sub_section;
            }

            return lineType.Description;
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(label_ProjectFolder.Text)
                || !File.Exists(label_FolderNamesTxt.Text)
                || string.IsNullOrWhiteSpace(textBox_FileName.Text)
                || string.IsNullOrWhiteSpace(textBox_FileExtension.Text)
                || string.IsNullOrWhiteSpace(textBox_CommentStart.Text)
                || string.IsNullOrWhiteSpace(textBox_CommentEnd.Text))
            {
                MessageBox.Show("Some items are missing!");
            }
            else
            {
                label_Status.Text = "Generating...";

                string currentMainSection = "";

                for (int i = 0; i < FolderNames.Length; i++)
                {
                    string line = FolderNames[i];

                    if (DetermineLineType(line) == lineType.Main_section)
                    {
                        // Set var
                        currentMainSection = line;

                        // Create folder
                        string path = Path.Combine(label_ProjectFolder.Text, currentMainSection);
                        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                    }

                    if (DetermineLineType(line) == lineType.Sub_section)
                    {
                        if (line.ToLower().Contains("text frame"))
                        {
                            ;
                        }

                        // Create folder
                        string path = Path.Combine(label_ProjectFolder.Text, currentMainSection, line);
                        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                        // Collect description lines
                        List<string> descLines = new List<string>();
                        int j = 1;
                        while (i + j < FolderNames.Length && DetermineLineType(FolderNames[i + j]) == lineType.Description)
                        {
                            descLines.Add(FolderNames[i + j]);
                            j++;
                        }

                        // Create file
                        string filePath = Path.Combine(path, textBox_FileName.Text + "." + textBox_FileExtension.Text);
                        List<string> fileLines = new List<string>();
                        fileLines.Add(textBox_CommentStart.Text);
                        fileLines.AddRange(descLines);
                        fileLines.Add(textBox_CommentEnd.Text);
                        fileLines.Add("");
                        if (!string.IsNullOrWhiteSpace(textBox_BoilerPlate.Text))
                        {
                            fileLines.AddRange(textBox_BoilerPlate.Lines);
                            fileLines.Add("");
                        }
                        File.WriteAllLines(filePath, fileLines);
                    }
                }

                label_Status.Text = "Done";
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
