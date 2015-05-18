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
    class FormMainModel : INotifyPropertyChanged
    {
        private Assembly assembly;
        private Type currentClass = null;

        private String className = "";
        private List<String> classMethods = new List<String>();
        private List<String> classConstructors = new List<String>();

        public event PropertyChangedEventHandler PropertyChanged;

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
                {
                    this.assembly = value;
                }
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
                {
                    this.currentClass = value;
                }
            }
        }

        public String CLASS_NAME
        {
            get
            {
                return this.className;
            }
            set
            {
                if (!value.Equals(this.className))
                {
                    this.className = value;
                    NotifyPropertyChanged("classNameChanged");
                }
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
                {
                    this.classMethods = value;
                    NotifyPropertyChanged("classMethodsChanged");
                }
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
                {
                    this.classConstructors = value;
                    NotifyPropertyChanged("classConstructorsChanged");
                }
            }
        }

        public Assembly getAssembly()
        {
            return this.assembly;
        }

        public void setAssembly(Assembly value)
        {
            if(!value.Equals(this.assembly))
            {
                this.assembly = value;
            }
        }

        public Type getCurrentClass()
        {
            return this.currentClass;
        }

        public void setCurrentClass(Type value)
        {
            if (!value.Equals(this.currentClass))
            {
                this.currentClass = value;
            }
        }

        public String getClassName()
        {
            return this.className;
        }

        public void setClassName(String value)
        {
            if (!value.Equals(this.className))
            {
                this.className = value;
                NotifyPropertyChanged("classNameChanged");
            }
        }

        public List<String> getClassMethods()
        {
            return this.classMethods;
        }

        public void setClassMethods(List<String> value)
        {
            if (!value.Equals(this.classMethods))
            {
                this.classMethods = value;
                NotifyPropertyChanged("classMethodsChanged");
            }
        }

        public List<String> getClassConstructors()
        {
            return classConstructors;
        }

        public void setClassConstructors(List<String> value)
        {
            if (!value.Equals(this.classConstructors))
            {
                this.classConstructors = value;
                NotifyPropertyChanged("classConstructorsChanged");
            }
        }
        
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
