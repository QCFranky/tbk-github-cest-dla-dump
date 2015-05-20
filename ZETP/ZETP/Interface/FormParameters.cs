using System;
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
    partial class FormParameters : Form
    {
        private List<String> parametersType = new List<String>();
        private List<Object> values = new List<Object>();
        private int ParametersLength;
        private Control[] TbxArray;
        private Control[] LblArray;

        public FormParameters(ParameterInfo[] parameters)
        {
            InitializeComponent();

            TbxArray = new Control[] { TbxParameter1, TbxParameter2, TbxParameter3, TbxParameter4, TbxParameter5 };
            LblArray = new Control[] { LblParameter1, LblParameter2, LblParameter3, LblParameter4, LblParameter5 };

            ParametersLength = parameters.Length;

            foreach (ParameterInfo parameter in parameters)
            {
                parametersType.Add(parameter.ParameterType.Name);
                values.Add(null);
            }
        }

        private void FormConstructorParameters_Load(object sender, EventArgs e)
        {
            if (ParametersLength == 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            for (int i = 0; i < ParametersLength; ++i)
            {
                TbxArray[i].Visible = true;
                LblArray[i].Visible = true;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            ValidateChildren();

            if (string.IsNullOrEmpty(errorProvider.GetError(TbxParameter1)) &&
                string.IsNullOrEmpty(errorProvider.GetError(TbxParameter2)) &&
                string.IsNullOrEmpty(errorProvider.GetError(TbxParameter3)) &&
                string.IsNullOrEmpty(errorProvider.GetError(TbxParameter4)) &&
                string.IsNullOrEmpty(errorProvider.GetError(TbxParameter5)))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TbxParameter_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbx = sender as TextBox;
            String tbxName = tbx.Name;
            int index = Int32.Parse(tbxName.Substring(tbxName.Length - 1)) - 1;

            if (tbx.Visible)
            {
                if (String.IsNullOrEmpty(tbx.Text))
                {
                    errorProvider.SetError(tbx, "Value is mandatory.");
                }
                else if (validateValue(parametersType[index], tbx.Text, index))
                {
                    errorProvider.SetError(tbx, String.Empty);
                }
                else
                {
                    errorProvider.SetError(tbx, "Wrong type.");
                }
            }
        }

        public object[] getValues()
        {
            return this.values.ToArray<object>();
        }

        private bool validateValue(String type, String s, int index)
        {
            try
            {
                switch (type)
                {
                    case "Boolean":     //bool
                        values[index] = Boolean.Parse(s);
                        return true;
                    case "Byte":        //Byte
                        values[index] = Byte.Parse(s);
                        return true;
                    case "DateTime":    //DateTime
                        values[index] = DateTime.Parse(s);
                        return true;
                    case "Int16":       //short
                        values[index] = Int16.Parse(s);
                        return true;
                    case "Int32":       //int
                        values[index] = Int32.Parse(s);
                        return true;
                    case "Int64":       //long
                        values[index] = Int64.Parse(s);
                        return true;
                    case "Single":      //float
                        values[index] = Single.Parse(s);
                        return true;
                    case "String":      //string
                        values[index] = s;
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
