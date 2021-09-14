using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SHAREPOINT_EXTRANET_CATALOG_MAKER
{
    

    public partial class Form : System.Windows.Forms.Form
    {
        Label oChooseLabel;
        TextBox oOldNameTextBox;
        TextBox oNewNameTextBox;

        string folderPath = "";

        Folder folder = new Folder();
        

        public Form()
        {

        
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chooseLabel.Text = "";
            oChooseLabel = chooseLabel;
            oOldNameTextBox = oldNameTextBox;
            oNewNameTextBox = newNameTextBox;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            folder.searchFolders(folderPath);
            folder.changeAllNames(oOldNameTextBox.Text, oNewNameTextBox.Text);
            
        }

        private void chooseFolderButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                oChooseLabel.Text = folderPath.ToString();
            }
        }

  
    }
}
