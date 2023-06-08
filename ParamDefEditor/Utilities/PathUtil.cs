﻿using System;
using SoulsFormats;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Utilities
{
    internal static class PathUtil
    {
        /// <summary>
        /// A string representing the path to the folder the program is running from.
        /// </summary>
        public static string EnvFolderPath = $"{Environment.CurrentDirectory}/";

        /// <summary>
        /// A string representing the path to a generic resource folder named "res" inside of the directory the program is running from.
        /// </summary>
        public static string ResFolderPath = $"{Environment.CurrentDirectory}/res/";

        /// <summary>
        /// A string representing the path to a generic resource folder named "Resource" inside of the directory the program is running from.
        /// </summary>
        public static string ResourceFolderPath = $"{Environment.CurrentDirectory}/Resource/";

        /// <summary>
        /// A string representing the path to a generic resource folder named "Resources" inside of the directory the program is running from.
        /// </summary>
        public static string ResourcesFolderPath = $"{Environment.CurrentDirectory}/Resources/";

        /// <summary>
        /// A string representing the path to a generic stacktrace log file named "stacktrace.log" inside of the directory the program is running from.
        /// </summary>
        public static string StackTraceLog = $"{Environment.CurrentDirectory}/stacktrace.log";

        /// <summary>
        /// A string representing the path to a generic log file named "log.log" inside of the directory the program is running from.
        /// </summary>
        public static string Log = $"{Environment.CurrentDirectory}/log.log";

        /// <summary>
        /// A string representing the path to a generic log file named "log.txt" inside of the directory the program is running from.
        /// </summary>
        public static string LogTxt = $"{Environment.CurrentDirectory}/log.txt";

        /// <summary>
        /// The default initial directory used if none are specified.
        /// </summary>
        public static string DefaultInitialDirectory = "C:\\Users";

        /// <summary>
        /// The default file filter used if none are specified.
        /// </summary>
        public static string DefaultFilter = "All files (*)|*";

        /// <summary>
        /// Get a single file from a user.
        /// </summary>
        /// <param name="initialDirectory">A string representing the path the dialog box should open in.</param>
        /// <param name="title">A string containing the title to display in the dialog box.</param>
        /// <param name="filter">What filetypes should be shown in the "Files of type" filter.</param>
        /// <returns>A string representing the path to a file a user selects.</returns>
        public static string GetFilePath(string initialDirectory = null, string title = null, string filter = null)
        {
            OpenFileDialog filePathDialog = new OpenFileDialog()
            {
                InitialDirectory = initialDirectory ?? DefaultInitialDirectory,
                Title = title ?? "Select a file to open.",
                Filter = filter ?? DefaultFilter,
            };

            return filePathDialog.ShowDialog() == DialogResult.OK ? filePathDialog.FileName : null;
        }

        /// <summary>
        /// Get a save path from a user.
        /// </summary>
        /// <param name="initialDirectory">A string representing the path the dialog box should open in.</param>
        /// <param name="title">A string containing the title to display in the dialog box.</param>
        /// <param name="filter">What filetypes should be shown in the "Save as file type" filter.</param>
        /// <returns>A string representing the save path a user selects.</returns>
        public static string GetSavePath(string initialDirectory = null, string title = null, string filter = null)
        {
            SaveFileDialog saveDialog = new SaveFileDialog()
            {
                InitialDirectory = initialDirectory ?? DefaultInitialDirectory,
                Title = title ?? "Select a location to save to.",
                Filter = filter ?? DefaultFilter
            };

            return saveDialog.ShowDialog() == DialogResult.OK ? saveDialog.FileName : null;
        }

        /// <summary>
        /// Get a single folder from a user.
        /// </summary>
        /// <param name="initialDirectory">A string representing the path the dialog box should open in.</param>
        /// <param name="title">A string containing the title to display in the dialog box.</param>
        /// <returns>A string representing the path to a folder a user selects.</returns>
        public static string GetFolderPath(string initialDirectory = null, string title = null)
        {
            CommonOpenFileDialog folderPathDialog = new CommonOpenFileDialog()
            {
                InitialDirectory = initialDirectory ?? DefaultInitialDirectory,
                Title = title ?? "Select a folder.",
                IsFolderPicker = true,
            };

            return folderPathDialog.ShowDialog() == CommonFileDialogResult.Ok ? folderPathDialog.FileName : null;
        }

        /// <summary>
        /// Get multiple files from a user.
        /// </summary>
        /// <param name="initialDirectory">A string representing the path the dialog box should open in.</param>
        /// <param name="title">A string containing the title to display in the dialog box.</param>
        /// <param name="filter">What filetypes should be shown in the "Files of type" filter.</param>
        /// <returns>A string array representing the paths to files a user selects.</returns>
        public static string[] GetFilePaths(string initialDirectory = null, string title = null, string filter = null)
        {
            OpenFileDialog filePathDialog = new OpenFileDialog()
            {
                InitialDirectory = initialDirectory ?? DefaultInitialDirectory,
                Title = title ?? "Select a file to open.",
                Filter = filter ?? DefaultFilter,
                Multiselect = true
            };

            return filePathDialog.ShowDialog() == DialogResult.OK ? filePathDialog.FileNames.ToArray() : null;
        }

        /// <summary>
        /// Backup a file or folder on a path if it exists by adding .bak to its extension.
        /// </summary>
        /// <param name="path">A string representing the path to a file to backup.</param>
        public static void Backup(string path)
        {
            if (File.Exists(path) && !File.Exists($"{path}.bak"))
                File.Move(path, $"{path}.bak");

            else if (Directory.Exists(path) && !Directory.Exists($"{path}-bak"))
                Directory.Move(path, $"{path}-bak");
        }

        /// <summary>
        /// Restore a backup from a backup file or folder on a path if it exists by overwriting the current version of the file or folder with the backup.
        /// </summary>
        /// <param name="path">A string representing the path to a backup file to restore.</param>
        public static void Restore(string path)
        {
            if (File.Exists(path))
                File.Move(path, Path.GetFileNameWithoutExtension(path));

            else if (Directory.Exists(path))
                Directory.Move(path, path.Remove(path.Length - 4));
        }

        /// <summary>
        /// Delete a file on the specified path if it exists.
        /// </summary>
        /// <param name="path"></param>
        public static void Delete(string path)
        {
            if (File.Exists(path)) File.Delete(path);
        }

        /// <summary>
        /// Copies a file if it exists and the new file does not yet exist to the specified path as a new file.
        /// </summary>
        /// <param name="path">A string representing the path to a file to copy.</param>
        /// <param name="newPath">A string representing the path to copy the selected file to.</param>
        public static void CopyFile(string path, string newPath, bool overwrite)
        {
            if (File.Exists(path) && !File.Exists(newPath))
            {
                File.Copy(path, newPath);
            }
            else if (File.Exists(path) && File.Exists(newPath) && overwrite)
            {
                File.Delete(newPath);
                File.Copy(path, newPath);
            }
        }

        /// <summary>
        /// Clones a file on a path if it exists and deletes or backups the original.
        /// </summary>
        /// <param name="path">A string representing the path to a file to clone.</param>
        /// <param name="backup">Whether or not to retain the original with .bak added to its extension.</param>
        public static void Clone(string path, bool backup)
        {
            byte[] fileBytes = File.ReadAllBytes(path);

            if (backup)
                Backup(path);

            if (File.Exists(path))
                File.Delete(path);

            File.WriteAllBytes(path, fileBytes);
        }

        /// <summary>
        /// Clones files on paths if they exist and deletes or backups the originals.
        /// </summary>
        /// <param name="paths">A string array representing the paths to files to clone.</param>
        /// <param name="backup">Whether or not to retain the original with .bak added to its extension.</param>
        public static void Clone(string[] paths, bool backup)
        {
            foreach (string path in paths)
            {
                Clone(path, backup);
            }
        }

        /// <summary>
        /// Writes a file overwriting if it exists and if specified to do so.
        /// </summary>
        /// <param name="path">A string representing a path to where the file is to be written or overwritten.</param>
        /// <param name="bytes">Bytes to write to the chosen file path.</param>
        /// <param name="overwrite">Whether or not to overwrite file if it already exists.</param>
        public static void Write(string path, byte[] bytes, bool overwrite = false)
        {
            if (!File.Exists(path))
                File.WriteAllBytes(path, bytes);

            else if (overwrite)
                File.WriteAllBytes(path, bytes);
        }

        /// <summary>
        /// Copy a directory and all of its files and subdirectories.
        /// </summary>
        /// <param name="path">A string representing a path to the folder to copy.</param>
        /// <param name="newPath">A string representing a path to copy the selected folder to.</param>
        /// <param name="overwrite">Whether or not to delete folder if it already exists.</param>
        public static void CopyDirectory(string path, string newPath, bool overwrite = false)
        {
            if (!Directory.Exists(path))
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    //Get the path of the new directory
                    var newDirectory = Path.Combine(newPath, Path.GetFileName(directory));
                    //Create the directory if it doesn't already exist
                    Directory.CreateDirectory(newDirectory);
                    //Recursively copy the directory
                    CopyDirectory(directory, newDirectory);
                }

                foreach (var file in Directory.GetFiles(path))
                {
                    File.Copy(file, Path.Combine(newPath, Path.GetFileName(file)));
                }
            }
            else if (Directory.Exists(path) && overwrite)
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    //Get the path of the new directory
                    string newDirectory = Path.Combine(newPath, Path.GetFileName(directory));
                    // Delete, then copy directory.
                    Directory.Delete(path);
                    Directory.CreateDirectory(newDirectory);
                    //Recursively copy the directory
                    CopyDirectory(directory, newDirectory);
                }

                foreach (var file in Directory.GetFiles(path))
                {
                    File.Copy(file, Path.Combine(newPath, Path.GetFileName(file)));
                }
            }
        }
    }
}
