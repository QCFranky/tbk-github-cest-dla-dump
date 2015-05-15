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
using System.Runtime.InteropServices;

namespace ZETP.Interface
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region "Events"
        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void TsMainBtnOpenFile_Click(object sender, EventArgs e)
        {
           ReadFile(OpenFile());
        }

        private void TsMainBtnCloseFile_Click(object sender, EventArgs e)
        {
            DesactivateMainForm();
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// Show an OpenFileDialog to let the user choose a class file. (*.cs)
        /// </summary>
        /// <returns> System.IO.Stream stream : null value if invalid </returns>
        private Stream OpenFile()
        {
            Stream stream = null;

            OfdMain.InitialDirectory = "c:\\";
            OfdMain.Filter = "class files (*.cs)|*.cs";
            OfdMain.FilterIndex = 2;
            OfdMain.RestoreDirectory = true;

            if (OfdMain.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = OfdMain.OpenFile()) != null)
                        ActivateMainForm();
                    else
                        MessageBox.Show("Error: Invalid File!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return stream;
        }

        private void ReadFile(Stream stream)
        {
            //******* To Complete... (si le fichier est invalide, recoit un stream null) ********
            if (stream != null)
            {
                
            }
        }

        /// <summary>
        /// Set the main form to Active by enabling the concerned child.
        /// </summary>
        private void ActivateMainForm()
        {
            TbxSelectedFile.Text = OfdMain.FileName;
            TsMainBtnCloseFile.Enabled = true;
            TsMainBtnOpenFile.Enabled = false;
            DgvConstructors.BackgroundColor = Color.White;
            DgvMethods.BackgroundColor = Color.White;
        }

        /// <summary>
        /// Set the main form to Inactive by disabling the concerned child.
        /// </summary>
        private void DesactivateMainForm()
        {
            TbxSelectedFile.Text = "No selected file";
            TsMainBtnCloseFile.Enabled = false;
            TsMainBtnOpenFile.Enabled = true;
            DgvConstructors.BackgroundColor = Color.LightGray;
            DgvMethods.BackgroundColor = Color.LightGray;
        }
        #endregion       
    }
}
