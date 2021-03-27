using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<TKeys, TValues>
    {
        TKeys[] Keys;
        TValues[] Values;
        public MyDictionary()
        {
            Keys = new TKeys[0];
            Values = new TValues[0];

        }

        public void Add(TKeys Key, TValues Value)
        {
            TKeys[] temporaryKeys = Keys;
            TValues[] temporaryValues = Values;

            Keys = new TKeys[Keys.Length + 1];
            Values = new TValues[Values.Length + 1];

            for (int i = 0; i < temporaryKeys.Length; i++)
            {
                Keys[i] = temporaryKeys[i];
            }

            for (int i = 0; i < temporaryValues.Length; i++)
            {
                Values[i] = temporaryValues[i];
            }

            Keys[Keys.Length - 1] = Key;
            Values[Values.Length - 1] = Value;
        }

        public TValues GetValuesByKeys(TKeys Key)
        {
            int index = Array.IndexOf(Keys, Key);
            return Values[index];
        }

    }
}
