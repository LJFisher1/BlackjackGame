using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2_Notes_and_Examples
{
    class Notes
    {
        // There are two ways to pass parameters to methods
        // Pass by Value & Pass by Reference

        // Pass by value = copy
        // You are copying a value from one variable to a new variable (the parameter)
        // Changes made to the parameter in the method DO NOT affect the variable used
        // to call the method

        // Pass by Reference = alias
        // You are creating a new name for the same variable
        // Any changes to the parameter in the method affect the variable used
        // when calling the method

        // Out vs Ref

        // For Pass by Ref the variable you pass must be initialized
            // string name = string.Empty;
            // GetName(ref name);

       // For Out parameters
       // You do NOT need to initialize the variable before calling the method
       // However, the method is REQUIRED to set the variable before returning
       // bool result = int.TryParse(ageInput, out int age);

        // Optional parameters
        // You can make parameters optional
        // Optional parameters means that the code that calls your method does
        // not need to pass a value for the parameter.
        // Optional parameters MUST APPEAR AT THE END of the parameter list.

        // Example:
        // public void MethodWithOptional(int nonoptional, bool isOk = false)
        // Which means you write the code that uses/calls this method, you have the
        // choice of passing in a bool value of true or false, if you don't then
        // it will just accept the default value of false for the bool parameter
    }
}
