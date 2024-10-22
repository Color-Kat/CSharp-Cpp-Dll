using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class ArraySum
    {

        private float[] array;
        public float result;

        DLLWrapper dllSum = new DLLWrapper();

        public void GenerateRandomArray(int length)
        {
            array = new float[length];

            Random random = new Random();

            for(var i = 0; i < array.LongLength; i++) {
                array[i] = (float) random.Next(0, 10);
            }
        }

        public string CSharpSum()
        {
            if (array == null) return @"Array is not generated";

            Stopwatch timer = new Stopwatch();
            timer.Start();

            result = 0;

            for (var i = 0; i < array.LongLength; i++)
            {
                result = result + array[i];
            }

            timer.Stop();

            return string.Format("Sum: {0}\nTime: {1}", result, timer.Elapsed);
        } 

        public string CppSum()
        {
            if (array == null) return @"Array is not generated";

            Stopwatch timer = new Stopwatch();
            timer.Start();

            result = dllSum.SumCpp(array);

            timer.Stop();

            return string.Format("Sum: {0}\nTime: {1}", result, timer.Elapsed);
        }

        public string XMMSum()
        {
            if (array == null) return @"Array is not generated";

            Stopwatch timer = new Stopwatch();
            timer.Start();

            result = dllSum.SumXMM(array);
            timer.Stop();

            return string.Format("Sum: {0}\nTime: {1}", result, timer.Elapsed);
        }
    }
}
