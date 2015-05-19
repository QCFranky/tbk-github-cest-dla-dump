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
    partial class FormMain : Form
    {
        private FormMainModel model;
        private FormMainController controller;
        public FormMain()
        {
            model = new FormMainModel();
            controller = new FormMainController(model);
            controller.getAllClass();
            InitializeComponent();
        }

        #region "Events"
        private void FormMain_Load(object sender, EventArgs e)
        {
            WriteOutputConsole("Application opened");
            
            foreach (Type aClass in model.ASSEMBLY.GetTypes())
            {
                if (aClass.IsClass && aClass.IsPublic && !aClass.IsAbstract)
                {
                    CbxClass.Items.Add(aClass.Name);
                    WriteOutputConsole(aClass.Name);
                }
            }

            controller.analyseClass(CbxClass.SelectedText);

            if (LbxConstructors.Items.Count != 0)
                BtnCreateObject.Enabled = true;
        }

        private void BtnCreateObject_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: a verifier si la methode callMethode marche pour es constructeur aussi
                //TODO: manque les parametres
                //controller.callMethod()
                WriteOutputConsole("Object Created");

                if (LbxMethods.Items.Count != 0)
                    BtnCallMethod.Enabled = true;
            }
            catch (Exception ex)
            {
                WriteOutputConsole(ex.Message);
            }
        }

        private void BtnCallMethod_Click(object sender, EventArgs e)
        {
            try
            {   
                //TODO: manque les parametres
                //controller.callMethod()
                WriteOutputConsole("Method Called");
            }
            catch (Exception ex)
            {
                WriteOutputConsole(ex.Message);
            }
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// Display a message in the output console.
        /// </summary>
        /// <param name="p"> string to display in the output console </param>
        private void WriteOutputConsole(string p)
        {
            TbxOutpoutConsole.AppendText(Environment.NewLine + "<" + DateTime.Now + "> : " + p);
        }
        #endregion
    }
}
