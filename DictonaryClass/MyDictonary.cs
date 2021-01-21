using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryClass
{
    class MyDictonary<T1,T2>
    {
        //key ve value adında 2 array tanımlayıp dictionary listimizin key ve valuesini alıcağız.
        T1[] keys;
        T2[] values;
        // constructor yapısı ile arraylerimizi Mydictionary her newlendiğinide newleyeceğiz.
        public MyDictonary()
        {
            keys = new T1[0];
            values = new T2[0];
        }
        //gelen key ve valueyi dictionary yapılarını arraylerimize ekleyeceğiz
        //bu sayede dictionary yapısının mantığını ele almış olacağız.
        public void Add(T1 key ,T2 value)
        {
            T1[] keyData = keys;
            T2[] valueData = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];
            for (int i = 0; i < keyData.Length; i++)
            {
                keys[i] = keyData[i];
            }
            for (int i = 0; i < valueData.Length; i++)
            {
                values[i] = valueData[i];
            }
            keys[keys.Length - 1] = key;

            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return keys.Length; }
        }

        public T1[] Keys
        {
            get { return keys; }
        }
        public T2[] Values
        {
            get { return values; }
        }


    }
}
