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
        private const FormMainModel model = new FormMainModel();
        private FormMainController controller; 
        public FormMain()
        {
            controller = new FormMainController(model);
            InitializeComponent();
        }

        #region "Events"
        private void FormMain_Load(object sender, EventArgs e)
        {
            WriteOutputConsole("Application opened");
        }
        private void TsMainBtnOpenFile_Click(object sender, EventArgs e)
        {
           ReadFile(OpenFile());

           if (DgvConstructors.RowCount != 0)
               BtnCreateObject.Enabled = true;
        }

        private void TsMainBtnCloseFile_Click(object sender, EventArgs e)
        {
            DesactivateMainForm();
        }

        private void BtnCreateObject_Click(object sender, EventArgs e)
        {
            //TODO: Call the selected constructor...

            WriteOutputConsole("Object Created");

            if (DgvMethods.RowCount != 0)
                BtnCallMethod.Enabled = true;
        }

        private void BtnCallMethod_Click(object sender, EventArgs e)
        {
            //TODO: Call the selected method...

            WriteOutputConsole("Method Called");
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

            OfdMain.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OfdMain.Filter = "class files (*.cs)|*.cs";
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"> .cs file stream </param>
        private void ReadFile(Stream stream)
        {
            //TODO: Read the file (receive a null stream if the file is invalid)
            if (stream != null)
            {
                
            }
        }

        /// <summary>
        /// Display a message in the output console.
        /// </summary>
        /// <param name="p"> string to display in the output console </param>
        private void WriteOutputConsole(string p)
        {
            TbxOutpoutConsole.AppendText(Environment.NewLine + "<" + DateTime.Now + "> : " + p);
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

            WriteOutputConsole("Class file opened");
        }

        /// <summary>
        /// Set the main form to Inactive by disabling the concerned child.
        /// </summary>
        private void DesactivateMainForm()
        {
            TbxSelectedFile.Text = "No selected file";
            TbxClassName.Text = String.Empty;
            TsMainBtnCloseFile.Enabled = false;
            TsMainBtnOpenFile.Enabled = true;
            DgvConstructors.BackgroundColor = Color.LightGray;
            DgvMethods.BackgroundColor = Color.LightGray;
            BtnCreateObject.Enabled = false;
            BtnCallMethod.Enabled = false;
                
            WriteOutputConsole("Class file closed");
        }
        #endregion       
    }
}
