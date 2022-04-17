using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBookshelfNormal : Interactable
{
    [SerializeField] private AudioSource interact;


    [SerializeField] private GameObject panel1;
    [SerializeField] private GameObject text1;

    public string interactText;

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
