using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Path = System.IO.Path;

namespace Flight_Inspection_App.Controls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class FilesComponent : UserControl
    {

        public FilesComponent()
        {
            InitializeComponent();
        }



        private void btnOpenCsvFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    lbCsvFiles.Items.Add(new KeyValuePair<string, string>(filePath, Path.GetFileName(filePath)));
                }
            }
        }
        private void btnOpenDllFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Dll files (*.dll)|*.dll|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    lbDllFiles.Items.Add(new KeyValuePair<string, string>(filePath, Path.GetFileName(filePath)));
                }
            }
        }

    }
}
