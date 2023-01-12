using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEditor;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour{
    
    
    [SerializeField] private GameObject dialogue;
    [SerializeField] [TextArea(3, 5)] private string introduction;
    
    private string _textToDisplay;
    private int _textToDisplayIndex;
    
    private GameObject _dialogueTextBox;
    private GameObject _dialogueNextButton;
    
    private TextMeshProUGUI _dialogueTextBoxComponent;
    
    private int _currentPass;

    private static int PASSES_PER_CHARACTER = 2;
    
    private void Start(){
        DisplayDialogue(introduction);
    }

    private void FixedUpdate(){
        DrawDialogue();
    }

    private void DrawDialogue(){
        if (_textToDisplay.Length <= _textToDisplayIndex){
            if (_dialogueNextButton != null){
                _dialogueNextButton.SetActive(true);
            }
            return;
        }
        
        if(_currentPass<PASSES_PER_CHARACTER){
            _currentPass++;
            return;
        }
        
        _currentPass = 0;
        _dialogueTextBoxComponent.text += _textToDisplay[_textToDisplayIndex];
        _textToDisplayIndex++;
    }
    
    private void DisplayDialogue(string message){
        if (_dialogueTextBox == null){
            _dialogueTextBox = dialogue.transform.GetChild(1).gameObject;
        }

        if (_dialogueNextButton == null){
            _dialogueNextButton = dialogue.transform.GetChild(2).gameObject;
        }

        if (_dialogueTextBoxComponent == null){
            _dialogueTextBoxComponent = _dialogueTextBox.GetComponent<TextMeshProUGUI>();
        }

        _dialogueNextButton.SetActive(false);
        _dialogueTextBoxComponent.text = "";
        _textToDisplay = message;
        _textToDisplayIndex = 0;
    }

    public void NextDialogue(){
        print(1);
        DisplayDialogue(introduction);
    }
    
    public void SkipDialogue(){
        print(2);
        _dialogueTextBoxComponent.text = _textToDisplay;
        _textToDisplayIndex = _textToDisplay.Length;
    }
}
