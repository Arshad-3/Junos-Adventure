using UnityEngine;
using TMPro;

public class Keyboard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI username;
    private TouchScreenKeyboard keyboard;

    public void OnGUI()
    {
        GUI.skin.button.fontSize = 36;
        if (GUILayout.Button("Keyboard"))
        {
            username.text = GUI.TextField(new Rect(10, 10, 160, 30), username.text, 20);
            keyboard = TouchScreenKeyboard.Open("Hello", TouchScreenKeyboardType.Default, false, false, false, true);
        }
    }
}
