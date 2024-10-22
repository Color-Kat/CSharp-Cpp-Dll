using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class DLLWrapper
    {

        public float SumCpp(float[] array)
        {
            return DLLSum(array, array.Length);
        }

        [DllImport("D:/Programming/C#/MyDLL/ArraySum/Debug/CppSum.dll", EntryPoint = "ArraySum", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern float DLLSum(float[] array, int length);

       public float SumXMM(float[] array)
        {
            return DLLSumXMM(array, array.Length);
        }

        [DllImport("D:/Programming/C#/MyDLL/ArraySum/Debug/CppSum.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SumXMM", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern float DLLSumXMM(float[] array, int length);
    }
}
