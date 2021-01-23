using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionayList
{
    public class MyDictionary<TKey, TValue>
    {
        

        TKey[] _keys; 
        TValue[] _values; 
        TKey[] tempKey = new TKey[0]; 
        TValue[] tempValue = new TValue[0]; 
        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempKey = _keys; 
            _keys = new TKey[_keys.Length + 1];

            tempValue = _values;
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++) 
            {
                _keys[i] = tempKey[i];
                _values[i] = tempValue[i];

            }

            _keys[_keys.Length - 1] = key; 
            _values[_values.Length - 1] = value; 

        }

        public void GetAll()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine(" Key :  {0}  | Value :   {1}", _keys[i], _values[i]);
            }
        }

    }
}