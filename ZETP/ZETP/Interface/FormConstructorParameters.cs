﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZETP.Interface
{
    partial class FormConstructorParameters : Form
    {
        private List<String> parametersType = new List<String>();
        private List<Object> values = new List<Object>();
        public FormConstructorParameters(ParameterInfo[] parameters)
        {
            InitializeComponent();

            foreach (ParameterInfo parameter in parameters)
               parametersType.Add(parameter.ParameterType.Name);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (string.IsNullOrEmpty(errorProvider.GetError(TbxParameter1)))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TbxParameter1_Validating(object sender, CancelEventArgs e)
        {
            //TODO: Vérifier si bon type ...
            if (false)
            {
                errorProvider.SetError(TbxParameter1, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                errorProvider.SetError(TbxParameter1, "Wrong type.");
            }
        }

        private void TbxParameter2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TbxParameter3_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TbxParameter4_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TbxParameter5_Validating(object sender, CancelEventArgs e)
        {

        }

        private bool validateValue(String type,String s)
        {
            try
            {
                switch (type)
                {
                    case "Int32":
                        values.Add(Int32.Parse(s));
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
