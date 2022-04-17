using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBookshelfNormal : Interactable
{
    // Audio Source that Plays when you interact with an object.
    [SerializeField] private AudioSource interact;

    // Panel that opens when bookshelf is interacted with and text that is displayed
    [SerializeField] private GameObject panel1;
    [SerializeField] private GameObject text1;

    public string interactText;

    // Override of abstract function Interact that checks for an interactable object in raycast
    public override void Interact()
    {
        interact.Play();

        text1.GetComponent<Text>().text = interactText;
        if (panel1 != null)
        {
            bool isActive = panel1.activeSelf;
            panel1.SetActive(!isActive);
        }
    }
}
