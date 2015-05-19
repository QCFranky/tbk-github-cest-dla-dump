using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZETP.Interface
{
    class FormMainModel
    {
        private Assembly assembly;
        private Type currentClass = null;

        private List<String> classMethods = new List<String>();
        private List<String> classConstructors = new List<String>();

        public FormMainModel() { }

        public Assembly ASSEMBLY
        {
            get
            {
                return this.assembly;
            }
            set
            {
                if (!value.Equals(this.assembly))
                    this.assembly = value;
            }
        }

        public Type CURRENT_CLASS
        {
            get
            {
                return this.currentClass;
            }
            set
            {
                if (!value.Equals(this.currentClass))
                    this.currentClass = value;
            }
        }

        public List<String> CLASS_METHODS
        {
            get
            {
                return this.classMethods;
            }
            set
            {
                if (!value.Equals(this.classMethods))
                    this.classMethods = value;
            }
        }

        public List<String> CLASS_CONSTRUCTORS
        {
            get
            {
                return this.classConstructors;
            }
            set
            {
                if (!value.Equals(this.classConstructors))
                    this.classConstructors = value;
            }
        }

        public void clearData()
        {
            CLASS_CONSTRUCTORS = new List<string>();
            CLASS_METHODS = new List<string>();
        }
    }
}
