using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Import UnityEngine UI dan TMPro
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    // declare button, TMP_InputField & TMP_Text
    public Button Submit;
    public TMP_InputField Input;
    public TMP_Text UIText;

    void Start()
    {
        // declare listener ketika button di click
        Submit.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // text UI berubah sesuai dengan text input
        UIText.text = Input.text;
        // Font text UI bertambah 1
        UIText.fontSize += 1;
    }
}