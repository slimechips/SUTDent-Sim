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
        public class DropdownIntSeDict : SerializableDictionary<string, int> { }

        namespace Internal
        {
            [CustomPropertyDrawer(typeof(DropdownIntSeDict))]
            public class DropDownIntSeDictDrawer : DictionaryDrawer<string, int> { }
        }
    }

}

