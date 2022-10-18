using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class ctrl : MonoBehaviour
{
    private UIDocument _document;
    private VisualElement _RootElement;
    private Label _label;
    private Button _button;
    private TextField _textField;
    

    // Start is called before the first frame update
    void Start()
    {
        _document = GetComponent<UIDocument>();
        _RootElement = _document.rootVisualElement;

        _label = _RootElement.Q<Label>("mylabel");
        _button = _RootElement.Q<Button>("mybutton");
        _textField = _RootElement.Q<TextField>("input-message");
        _button.RegisterCallback<ClickEvent>(evt =>
        {
     
            if (_textField.value.Equals("29469044"))
                _label.text = "密碼對了";
            else
                _label.text = "密碼錯了";
        });
        
    }

    
}
