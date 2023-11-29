using UnityEditor;
using UnityEditor.UI;


namespace NotepadPP.Editor
{
    [CustomEditor(typeof(EventButton), true)]
    [CanEditMultipleObjects]
    public class EventButtonEditor : SelectableEditor
    {

        protected override void OnEnable()
        {
            base.OnEnable();
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.Space();

            serializedObject.Update();
            serializedObject.ApplyModifiedProperties();
        }
    }
}