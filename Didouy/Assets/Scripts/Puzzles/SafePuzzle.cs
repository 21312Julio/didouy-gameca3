using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SafePuzzle : MonoBehaviour
{
    [SerializeField] private GameObject[] choices;
    private GameObject safe;


    public void Start()
    {
        safe = GameObject.FindGameObjectWithTag("Safe");
        if (safe.activeSelf == true)
        {
            StartCoroutine(SelectFirstChoice());
        }
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }
}
