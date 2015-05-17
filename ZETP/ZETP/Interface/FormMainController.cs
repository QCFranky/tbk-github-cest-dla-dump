using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZETP.Interface
{
    class FormMainController
    {
        private FormMainModel model;
        public FormMainController(FormMainModel model)
        {
            this.model = model;
        }

        public void analyseClass(String className)
        {
            Type classType = getClassFromName(className);
            MethodInfo[] classInfo = classType.GetMethods(BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly); 

            model.CLASS_NAME = className;

            foreach (MethodInfo info in classInfo){
                if(info.IsConstructor){
                    model.CLASS_CONSTRUCTORS.Add(info.Name);
                } else {
                    model.CLASS_METHODS.Add(info.Name);
                }
            }
        }

        public void getAllClass()
        {
            model.ASSEMBLY = typeof(Program).Assembly;
        }

        public Type getClassFromName(String className)
        {
            foreach (Type aClass in model.ASSEMBLY.GetTypes())
            {
                if (aClass.Name.Equals(className))
                {
                    return aClass;
                }
            }
            return null;
        }
    }
}
