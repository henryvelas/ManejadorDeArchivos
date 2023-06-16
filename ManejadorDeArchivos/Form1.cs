using System.Windows.Forms;

namespace ManejadorDeArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateSystemDrives();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void PopulateSystemDrives()
        {
            try
            {
                var drives = Directory.GetLogicalDrives();
                foreach (var item in drives)
                {
                    cboSystemDriver.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cboSystemDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disk = cboSystemDriver.SelectedItem.ToString();
                DriveInfo diskInfo = new DriveInfo(disk);
                var driveDetails = $@"
                                    Drive: {disk} drive:
                                    Total Size: {diskInfo.TotalSize}
                                    Free space available: {diskInfo.AvailableFreeSpace}
                                    Format: {diskInfo.DriveFormat}
                                    Type: {diskInfo.DriveType}
                                    ";

                txtSystemDetails.Text = driveDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDiretory.Text))
                    throw new Exception("Please, enter a path for the directory");

                if (!Directory.Exists(txtNewDiretory.Text))
                {
                    Directory.CreateDirectory(txtNewDiretory.Text);
                    MessageBox.Show("Directory create");
                }
                else
                {
                    MessageBox.Show("Please, enter the full path of the new directory");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateSubDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDiretory.Text))
                    throw new Exception("Make sure you have included a directory path on new Directory");

                if (string.IsNullOrEmpty(txtSubDirectory.Text))
                    throw new Exception("Please, enter the name for the directory");


                if (!Directory.Exists(txtNewDiretory.Text))
                {
                    Directory.CreateDirectory(txtNewDiretory.Text);

                    var directoryPath = txtNewDiretory.Text;
                    var subDirInfo = new DirectoryInfo(directoryPath);

                    subDirInfo.CreateSubdirectory(txtSubDirectory.Text);
                    MessageBox.Show("Sub-Directory create");
                }
                else
                {
                    var directoryPath = txtNewDiretory.Text;
                    var subDirInfo = new DirectoryInfo(directoryPath);

                    subDirInfo.CreateSubdirectory(txtSubDirectory.Text);
                    MessageBox.Show("Sub-Directory create");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowDirectoryFiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDiretory.Text))
                    throw new Exception("Make sure you have included a directory path on New Directory");

                var directory = txtNewDiretory.Text;
                var directoryInfo = new DirectoryInfo(directory);

                if (!directoryInfo.Exists)
                    throw new Exception("Directory doesn't exist");

                var subDirectories = directoryInfo.GetDirectories();
                foreach (var subdir in subDirectories)
                {
                    if (!cboDirectoryFiles.Items.Contains(subdir.Name))
                        cboDirectoryFiles.Items.Add(subdir.Name);

                }

                var files = directoryInfo.GetFiles("*");
                foreach (var file in files)
                {
                    if (!cboDirectoryFiles.Items.Contains(file.Name))
                        cboDirectoryFiles.Items.Add(file.Name);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopyDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSources.Text) || string.IsNullOrEmpty(txtDestination.Text))
                    throw new Exception("No empty fields");

                var sourcesDirectory = new DirectoryInfo(txtSources.Text);
                var sourcesDestination = new DirectoryInfo(txtDestination.Text);

                CopyDirectory(sourcesDirectory, sourcesDestination);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CopyDirectory(DirectoryInfo source, DirectoryInfo destination)
        {
            
            try
            {
                if (!source.Exists)
                    throw new Exception("Sources directory doesn´t exist");

                if (!destination.Exists)
                    destination.Create();

                var files = source.GetFiles();
                foreach (var file in files)
                {
                    file.CopyTo(Path.Combine(destination.FullName, file.Name));
                }

                var directories = source.GetDirectories();
                foreach (var directorie in directories)
                {
                    string destinatione = Path.Combine(destination.FullName, directorie.Name);
                    CopyDirectory(directorie,new DirectoryInfo(destinatione));
                }
                MessageBox.Show("Directory copy success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewFile.Text))
                    throw new Exception("Make sure you have included a directory path on New File");

                if (!File.Exists(txtNewFile.Text))
                {
                    File.Create(txtNewFile.Text);
                    MessageBox.Show("File create");
                }
                else
                {
                    MessageBox.Show("Please enter the full path");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtOpenFile.Text= openFileDialog1.FileName;
                    txtRenameFile.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRenameFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRenameFile.Text))
                    throw new Exception("Make sure you have included a directory path on New File");

                var sources = txtOpenFile.Text;
                var destination = txtRenameFile.Text;

                var sourceFileInfo = new FileInfo(sources);
                if(sourceFileInfo.Exists)
                {
                    sourceFileInfo.MoveTo(destination);
                    MessageBox.Show("The file has been renamed");
                }
                else
                    MessageBox.Show("Error trying to rename the file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOpenFile.Text)) 
                    throw new Exception("File empty");

                if (!File.Exists(txtOpenFile.Text))
                    throw new Exception("File doesn't exist");

                FileStream fs = new FileStream(txtOpenFile.Text, FileMode.Create,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(txtWrite.Text);
                sw.Flush();
                fs.Close();
                MessageBox.Show("Content Written");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOpenFile.Text))
                    throw new Exception("File empty");

                if (!File.Exists(txtOpenFile.Text))
                    throw new Exception("File doesn't exist");

                FileStream fs = new FileStream(txtOpenFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txtRead.Text = sr.ReadToEnd();
                fs.Close();
                MessageBox.Show("Content readed");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOpenFile.Text))
                    throw new Exception("File empty");

                if (!File.Exists(txtOpenFile.Text))
                    throw new Exception("File doesn't exist");

                FileStream fs = new FileStream(txtOpenFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                var content = sr.ReadToEnd();

                int i = content.IndexOf(txtFind.Text.Trim(),0);

                if(i>-1)
                    MessageBox.Show("Content Finded");
                else
                    MessageBox.Show("Content not Finded");

                fs.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOpenFile.Text))
                    throw new Exception("File empty");

                if (!File.Exists(txtOpenFile.Text))
                    throw new Exception("File doesn't exist");

                var path = txtOpenFile.Text;

                var sw = File.AppendText(path);
                sw.WriteLine(txtUpdate.Text);
                sw.Close();

                MessageBox.Show("Content Update");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}