using System;
using System.Collections.Generic;
using System.Text;


namespace ArrayAddition
{
    class ArrayCalculator
    {
        public int addAll(List<int> numbers)
        {
            int num = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                num += numbers[i];
            }
            return num;
        }

        public int addEven(List<int> numbers)
        {
            int eresult = 0;
            for (int i = 0; i < numbers.Count; i += 2)
            {
                eresult += numbers[i];
            }
            return eresult;
        }
        public int addOdd(List<int> numbers)
        {
            int oresult = 0;
            for (int i = 1; i < numbers.Count; i += 2)
            {
                oresult += numbers[i];
            }
            return oresult;
        }
    }
}
