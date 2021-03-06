﻿using System;
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
            String text = CbxClass.SelectedText;
            if (text != null && !text.Equals(""))
            {
                controller.analyseClass(text);
            }

            if (LbxConstructors.Items.Count != 0)
                BtnCreateObject.Enabled = true;
        }

        private void BtnCreateObject_Click(object sender, EventArgs e)
        {
            try
            {
                FormParameters zeForm = new FormParameters(model.CURRENT_CLASS.GetConstructors()[LbxConstructors.SelectedIndex].GetParameters());

                if (zeForm.ShowDialog(this) == DialogResult.OK)
                {
                    controller.callConstructor(LbxConstructors.SelectedIndex, zeForm.getValues());
                    WriteOutputConsole("Object Created");

                    if (LbxMethods.Items.Count != 0)
                        BtnCallMethod.Enabled = true;
                }
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
                FormParameters zeForm = new FormParameters(model.CURRENT_CLASS.GetMethods()[LbxMethods.SelectedIndex].GetParameters());

                if (zeForm.ShowDialog(this) == DialogResult.OK)
                {
                    WriteOutputConsole(controller.callMethod(LbxMethods.SelectedIndex, zeForm.getValues()).ToString());
                    WriteOutputConsole("Method Called");
                }
            }
            catch (Exception ex)
            {
                WriteOutputConsole(ex.Message);
            }
        }

        private void CbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = CbxClass.SelectedItem.ToString();
            if (text != null && !text.Equals(""))
            {
                controller.analyseClass(text);
            }

            LbxConstructors.Items.AddRange(model.CLASS_CONSTRUCTORS.ToArray());
            LbxMethods.Items.AddRange(model.CLASS_METHODS.ToArray());

            if (LbxConstructors.Items.Count != 0)
                BtnCreateObject.Enabled = true;
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
