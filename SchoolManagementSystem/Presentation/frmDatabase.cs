﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Class;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem.Presentation
{
    public partial class frmDatabase : Form
    {
        DatabaseManager databaseManager = new DatabaseManager();
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void dbBackup()
        {
            //string constring = "server=localhost;user=root;pwd=qwerty;database=test;";
            //string file = "C:\\backup.sql";
            //using (MySqlConnection conn = new MySqlConnection(constring))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand())
            //    {
            //        using (MySqlBackup mb = new MySqlBackup(cmd))
            //        {
            //            cmd.Connection = conn;
            //            conn.Open();
            //            mb.ImportFromFile(file);
            //            conn.Close();
            //        }
            //    }
            //}
        }

        private void btnDBBackup_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.Trim();
            if (String.IsNullOrEmpty(txtPath.Text.Trim()))
            {
                MessageBox.Show("Please select path");
                return;
            }
            try
            {
                databaseManager.FilePath = path;
                databaseManager.DatabaseBackup();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                // On demande l'endroit de la sauvegarde à l'utilisateur
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // On affecte le chemin de l'utilisateur et on utilise le fichier pour la sauvegarde
                        //databaseManager.FilePath = folderBrowserDialog.SelectedPath + "\\sas_db.sql";
                        txtPath.Text = folderBrowserDialog.SelectedPath + "\\sas_db.sql";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.Trim();
            if (String.IsNullOrEmpty(txtPath.Text.Trim()))
            {
                MessageBox.Show("Please select path");
                return;
            }
            try
            {
                databaseManager.FilePath = path;
                databaseManager.DatabaseRestore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
