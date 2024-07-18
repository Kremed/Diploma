namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] fileContent;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    //fileContent = File.ReadAllText(filePath);
                    fileContent = File.ReadAllLines(filePath);
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedLine = fileContent[0];

            string[] lineInformation = new string[10];

            lineInformation[0] = selectedLine.Substring(0,5);
            lineInformation[1] = selectedLine.Substring(5,10);
            lineInformation[2] = selectedLine.Substring(10, 10);
            lineInformation[2] = selectedLine.Substring(10, 10);
            lineInformation[2] = selectedLine.Substring(10, 10);
            lineInformation[2] = selectedLine.Substring(10, 10);
        }
    }
}
