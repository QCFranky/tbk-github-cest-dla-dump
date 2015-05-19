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
            if (classType != null)
            {
                model.clearData();
                ConstructorInfo[] constructorsInfo = classType.GetConstructors();
                foreach (ConstructorInfo info in constructorsInfo)
                    model.CLASS_CONSTRUCTORS.Add(info.ToString().Replace(info.Name, className).Remove(0,5));

                MethodInfo[] classInfo = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (MethodInfo info in classInfo)
                    model.CLASS_METHODS.Add(info.ToString());
            }
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

        public void callConstructor(int index, Object[] param)
        {
            Type aClass = model.CURRENT_CLASS;
            if (aClass == null)
                throw new Exception("No class has been selected.");
            ConstructorInfo[] constructors = aClass.GetConstructors();
            if (index >= 0 && index < constructors.Length)
            {
                ConstructorInfo aConstructor = constructors[index];
                if (aConstructor == null)
                    throw new Exception("Unable to call the constructor.");

                Object result = null;
                ParameterInfo[] parameters = aConstructor.GetParameters();
                object classInstance = Activator.CreateInstance(aClass, null);
                if (parameters.Length == 0)
                    result = aConstructor.Invoke(classInstance, null);
                else
                    result = aConstructor.Invoke(aConstructor, param);
            }
            else
            {
                throw new Exception("Invalide Index.");
            }
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
