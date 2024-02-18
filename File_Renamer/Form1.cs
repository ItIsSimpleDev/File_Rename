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

namespace File_Renamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Single File Renamer

        private string selectedSingleFilePath;

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedSingleFilePath = openFileDialog.FileName;
                    selectedFileInfoLbl.Text = "Selected File: " + openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            

        }

        private void renameItBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSingleFilePath != null && File.Exists(selectedSingleFilePath))
                {
                    string directoryPath = Path.GetDirectoryName(selectedSingleFilePath);
                    string newFileName = fileNameInputTxtBox.Text;
                    string oldFileName = Path.GetFileNameWithoutExtension(selectedSingleFilePath);
                    string extension = Path.GetExtension(selectedSingleFilePath);
                    string newFilePath = Path.Combine(directoryPath, newFileName + extension);
                    string oldFilePath = Path.Combine(directoryPath, oldFileName + extension);
                    File.Move(oldFilePath, newFilePath);
                    MessageBox.Show("File name has been succesfully changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedFileInfoLbl.Text = "Selected File: ";
                    selectedSingleFilePath = string.Empty;
                    fileNameInputTxtBox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please select a file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion





        #region Multi File Renamer
        private string selectedFolderPath;
        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    selectedFolderPath = dialog.SelectedPath;
                    selectedFolderInfoLbl.Text = "Selected Folder: " + selectedFolderPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void renameFolderChildsBtn_Click(object sender, EventArgs e)
        {
            string selectedNameForFiles = allFilesNameTxtBox.Text.Trim();
            string[] files = Directory.GetFiles(selectedFolderPath);
            for (int i = 0; i < files.Length; i++)
            {
                string extension = Path.GetExtension(files[i]);
                string newName = Path.Combine(selectedFolderPath, selectedNameForFiles + (i + 1) + extension);
                try
                {
                    File.Move(files[i], newName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"'{Path.GetFileName(files[i])}' error occured for this file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("All file names has been succesfully changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            allFilesNameTxtBox.Text = string.Empty;
        }


        #endregion





        #region Multi File Renamer (Contains)

        private string selectedFolderPathForReplace;

        private void selectFolderForMultiReplaceBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                selectedFolderPathForReplace = dialog.SelectedPath;
                selectedFolderInfoForMultiReplaceLbl.Text = "Selected Folder: " + selectedFolderPathForReplace;
            }
        }

        private string containsText;
        private string[] files;
        private void setValues()
        {
            containsText = containsFileFinderTxtBox.Text.Trim();
            files = Directory.GetFiles(selectedFolderPathForReplace);
        }

        private void containsFileFinderTxtBox_TextChanged(object sender, EventArgs e)
        {

            if (isValueNullOrEmpty(selectedFolderPathForReplace, "Please select a folder first.")) return;
            setValues();
            int foundFileCount = 0;
            fileFoundLbl.Text = "File Found: " + foundFileCount + "/" + files.Length;
            if (isValueNullOrEmpty(containsText)) return;
            foreach (string file in files)
            {
                try
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName.Contains(containsText))
                        foundFileCount++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            fileFoundLbl.Text = "File Found: " + foundFileCount + "/" + files.Length;
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            if (isValueNullOrEmpty(selectedFolderPathForReplace, "Select a folder first.")) return;
            setValues();
            if (isValueNullOrEmpty(containsText, "Please enter a contains value.")) return;
            int updatedFileCount = 0;
            foreach (string file in files)
            {
                try
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName.Contains(containsText))
                    {
                        updatedFileCount++;
                        string selectedNameForFiles = replaceTxtBox.Text;
                        string createdFileName = fileName.Replace(containsText, selectedNameForFiles);
                        File.Move(file, Path.Combine(selectedFolderPathForReplace, createdFileName));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show(updatedFileCount + " file(s) have been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            replaceTxtBox.Text = string.Empty;
            containsFileFinderTxtBox.Text = string.Empty;
        }

        private bool isValueNullOrEmpty(string value, string warningMessage = "")
        {
            if (string.IsNullOrEmpty(value))
            {
                if(!string.IsNullOrEmpty(warningMessage))
                    MessageBox.Show(warningMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        #endregion

    }

}
