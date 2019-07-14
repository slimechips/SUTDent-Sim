using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Utils.Editor
{
    using Internal;
    [Serializable]
    public class SimpleSOButton: SOButton
    {
        public string buttonText { get; private set; }
        public Action ButtonAction;

        public SimpleSOButton (string _buttonText, Action _buttonAction)
        {
            this.buttonText = _buttonText;
            this.ButtonAction = _buttonAction;
        }

        public void OnClick()
        {
            ButtonAction();
        }
    }

    namespace Internal
    {
        public interface SOButton
        {
            void OnClick();
        }

        [CustomPropertyDrawer(typeof(SimpleSOButton))]
        public class SimpleSOButtonDrawer: PropertyDrawer
        {
            private SimpleSOButton _button;
            public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
            {
                CheckInitialise(property);
                if (GUI.Button(position, new GUIContent(_button.buttonText)))
                {
                    _button.OnClick();
                }
            }

            private void CheckInitialise(SerializedProperty property)
            {
                if (_button == default(SimpleSOButton))
                {
                var target = property.serializedObject.targetObject;
                _button = (SimpleSOButton)fieldInfo.GetValue(target);
                }

            }
        }
    }

}
