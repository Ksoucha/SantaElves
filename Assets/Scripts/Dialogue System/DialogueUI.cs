using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject startDialogue;
    [SerializeField] private DialogueObject endDialogue;

    public bool isOpen {  get; private set; }

    private TypewriterEffect typewriterEffect;
   
    private void Start()
    {
        typewriterEffect = GetComponent<TypewriterEffect>();
        ShowDialogue(startDialogue);
    }

    private void Update()
    {
    }

    public void ShowDialogue(DialogueObject dialogueObject, Action functionToExecuteUponFinish = null)
    {
        isOpen = true;
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroughDialogue(dialogueObject, functionToExecuteUponFinish));
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject, Action functionToExecuteUponFinish = null)
    {
        for (int i = 0; i < dialogueObject.Dialogue.Length; i++)
        {
            string dialogue = dialogueObject.Dialogue[i];
            yield return typewriterEffect.Run(dialogue, textLabel);

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
        }

        {
            CloseDialogueBox();
        }

        functionToExecuteUponFinish?.Invoke();
    }

    private void CloseDialogueBox()
    {
        isOpen = false;
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;
    }

    public void LoadEndMenu()
    {
        SceneManager.LoadScene("GameEndMenu");
    }

    public void ActivateEndText()
    {
        ShowDialogue(endDialogue, LoadEndMenu);
    }
}
