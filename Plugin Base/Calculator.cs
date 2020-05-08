using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginBase
{
    public class Calculator
    {
        public static void Execute(MethodDef method)
        {
            for (var i = 0; i < method.Body.Instructions.Count; i++)
            {
              //Your code :)
            }

        }
    }
}