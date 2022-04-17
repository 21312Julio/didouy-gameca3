using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDialogue : Interactable
{
    // Interact Audio Source and inkJSON file that will be converted into text
    [SerializeField] private AudioSource interact;
    [SerializeField] private TextAsset inkJSON;

    // Dialogue Manager that will handle the inkJSON transformation
    [SerializeField] private DialogueManager dgManager;

    // Interactable object that will play when character enter the raycast
    public override void Interact()
    {
        interact.Play();
        dgManager.EnterDialogueMode(inkJSON);
    }
}
