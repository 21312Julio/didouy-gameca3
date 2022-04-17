using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDialogue : Interactable
{
    [SerializeField] private AudioSource interact;
    [SerializeField] private TextAsset inkJSON;

    [SerializeField] private DialogueManager dgManager;
    public override void Interact()
    {
        interact.Play();
        dgManager.EnterDialogueMode(inkJSON);
    }
}
