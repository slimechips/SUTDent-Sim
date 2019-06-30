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
        public class StringIntSeDict : SerializableDictionary<string, int> { }

        namespace Internal
        {
            [CustomPropertyDrawer(typeof(StringIntSeDict))]
            public class StringIntSeDictDrawer : DictionaryDrawer<string, int> { }
        }
    }
    
}

