using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Utils
{
    namespace General
    {
        [Serializable]
        public class StringIntSeDict : SerializableDictionary<string, int> {

            public static implicit operator SerializableDictionary<string, object>(StringIntSeDict dict)
            {
                Dictionary<string, object> objDict = new Dictionary<string, object>();
                foreach (KeyValuePair<string, int> set in dict)
                {
                    objDict.Add(set.Key, set.Value);
                }
                return new SerializableDictionary<string, object>(objDict);
            }

        }

        namespace Internal
        {
            [CustomPropertyDrawer(typeof(StringIntSeDict))]
            public class StringIntSeDictDrawer : DictionaryDrawer<string, int> { }
        }
    }
    
}

