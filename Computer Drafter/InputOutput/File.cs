﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_Drafter.InputOutput
{
    public class File
    {
        /// <summary>
        /// Checks if filename ends with the specified extension. Adds the extension if it doesn't.
        /// </summary>
        public static string CheckNameExtensionExists(string fileName, string extension)
        {
            if (!fileName.EndsWith(extension))
            {
                return fileName += extension;
            }
            else
            {
                return fileName;
            }
        }

        /// <summary>
        /// Gets the full filepath chosen.
        /// </summary>
        public static string GetSaveFileName(string initialDirectory, string fileName, string fileFilter)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.InitialDirectory = Path.GetFullPath(initialDirectory);
            //dlg.FileName = Path.GetFileNameWithoutExtension(fileName);
            dlg.FileName = fileName;
            dlg.Filter = fileFilter;

            bool? result = dlg.ShowDialog();

            if (result == true)
                return dlg.FileName;

            return null;
        }

        public static string GetOpenFileName(string initialDirectory, string fileFilter)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = Path.GetFullPath(initialDirectory);
            dlg.FileName = Path.GetFileNameWithoutExtension("Readme");
            dlg.Filter = fileFilter;

            bool? result = dlg.ShowDialog();

            if (result == true)
                return dlg.FileName;

            return null;
        }

        public static string GetFolderName(string initialDirectory, string description)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.RootFolder = Environment.SpecialFolder.MyComputer;
            dlg.Description = description;

            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
                return dlg.SelectedPath;
            else if (result == DialogResult.Cancel)
                return initialDirectory;

            return null;
        }
    }
}
