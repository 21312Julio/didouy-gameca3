using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMirror : Interactable
{
    [SerializeField] private AudioSource interact;


    [SerializeField] private GameObject panel1;
    [SerializeField] private GameObject text1;

    [SerializeField] private GameObject mirror;
    [SerializeField] private GameObject safe;

    public string interactText;

    public override void Interact()
    {
        interact.Play();

        text1.GetComponent<Text>().text = interactText;
        if (panel1 != null && mirror != null & safe != null)
        {
            bool isActive = panel1.activeSelf;
            bool isActive2 = mirror.activeSelf;
            bool isActive3 = safe.activeSelf;

            panel1.SetActive(!isActive);
            mirror.SetActive(!isActive2);
            safe.SetActive(!isActive3);
        }
    }
}
