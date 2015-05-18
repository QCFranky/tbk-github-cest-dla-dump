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
            MethodInfo[] classInfo = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            model.CLASS_NAME = className;

            foreach (MethodInfo info in classInfo)
                if (info.IsConstructor)
                    model.CLASS_CONSTRUCTORS.Add(info.Name);
                else
                    model.CLASS_METHODS.Add(info.Name);
        }

        public void getAllClass()
        {
            model.ASSEMBLY = typeof(Program).Assembly;
        }

        public Type getClassFromName(String className)
        {
            foreach (Type aClass in model.ASSEMBLY.GetTypes())
                if (aClass.Name.Equals(className))
                    return aClass;
            return null;
        }

        public void callMethod(String methodName, Object[] param)
        {
            Type aClass = model.CURRENT_CLASS;
            if (aClass == null)
                throw new Exception("No class has been selected.");
            MethodInfo aMethod = aClass.GetMethod(methodName);
            if (aMethod == null)
                throw new Exception("No method of that name was found.");
            object result = null;
            ParameterInfo[] parameters = aMethod.GetParameters();
            object classInstance = Activator.CreateInstance(aClass, null);
            if (parameters.Length == 0)
                result = aMethod.Invoke(classInstance, null);
            else
                result = aMethod.Invoke(aMethod, param);
        }
    }
}
