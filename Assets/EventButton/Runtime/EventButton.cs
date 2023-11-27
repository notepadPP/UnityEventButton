using System;
using UnityEngine;

using UnityEngine.UI;

namespace NotepadPP.EventButton
{
    public class EventButton : Button
	{
        [SerializeField] private string TypeName;
        [SerializeField] private string EnumName;

        private Type type;
        private Enum enumValue;
        protected override void Awake()
        {
            base.Awake();
            if(string.IsNullOrEmpty(TypeName) == false)
                type = Type.GetType(TypeName);
            if (type != null && Enum.TryParse(type, EnumName, out object result))
                enumValue = result as Enum;
            if (enumValue != null)
                onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            // Send Event

        }
    }
}