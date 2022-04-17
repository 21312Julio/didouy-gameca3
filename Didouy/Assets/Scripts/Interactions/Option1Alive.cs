using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option1Alive : MonoBehaviour
{
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);
    [SerializeField] private GameObject player;
    [SerializeField] private Inventory inv;
    private GameObject[] slots;
    private bool[] isFull;

    [Header("Activates")]
    [SerializeField] private GameObject bookshelfMorse;
    [SerializeField] private GameObject colliderMorse2;
    [SerializeField] private GameObject colliderMorse3;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject colliderMirror2;
    [SerializeField] private GameObject colliderMirror3;
    [SerializeField] private GameObject dollCollider2;
    [SerializeField] private GameObject dollCollider3;
    [SerializeField] private GameObject doorCollider1;
    [SerializeField] private GameObject doorCollider2;
    [SerializeField] private GameObject doll;
    [SerializeField] private GameObject key;
    //[SerializeField] private GameObject musicBoxCollider;
    private string checkForItems = "";

    [Header("Audios")]
    [SerializeField] private AudioSource keySFX;
    [SerializeField] private AudioSource fixSFX;
    [SerializeField] private AudioSource wooshSFX;

    public void Awake()
    {
        inv = player.GetComponent<Inventory>();
        slots = inv.slots;
        isFull = inv.isFull;
    }

    public void CheckNear()
    {
        Debug.Log("Checking Nearby");
        RaycastHit2D[] hits = Physics2D.BoxCastAll(player.transform.position, boxSize, 0, Vector2.zero);

        if (hits.Length > 0)
        {
            Debug.Log("Hit Length");
            foreach (RaycastHit2D rc in hits)
            {
                if (rc.transform.tag == "KeyBookshelf")
                {
                    foreach(GameObject slot in slots)
                    {
                        foreach (Transform child in slot.transform)
                        {
                            if (child.name == "MusicButton(Clone)")
                            {
                                bookshelfMorse.SetActive(true);
                                keySFX.Play();
                                Destroy(child.gameObject);
                                Destroy(colliderMorse2);
                                colliderMorse3.SetActive(true);
                            }
                        }
                    }   
                }

                if (rc.transform.tag == "BookshelfMorse")
                {
                    panel.SetActive(true);
                    foreach(Transform child in panel.transform)
                    {
                        if (child.name == "BookShelf")
                        {
                            child.gameObject.SetActive(true);
                        }
                    }
                }

                if (rc.transform.name == "MirrorSafeCollider (3)")
                {
                    panel.SetActive(true);
                    foreach (Transform child in panel.transform)
                    {
                        if (child.name == "Clock")
                        {
                            child.gameObject.SetActive(true);
                        }
                    }
                }

                if (rc.transform.name == "MirrorSafeCollider (2)")
                {
                    foreach (GameObject slot in slots)
                    {
                        foreach (Transform child in slot.transform)
                        {
                            if (child.name == "MirrorButton(Clone)")
                            {
                                fixSFX.Play();
                                Destroy(child.gameObject);
                                Destroy(colliderMirror2);
                                colliderMirror3.SetActive(true);
                            }
                        }
                    }
                }

                if (rc.transform.name == "DollCollider (2)")
                {
                    foreach (GameObject slot in slots)
                    {
                        foreach (Transform child in slot.transform)
                        {
                            if (child.name == "EyeButton(Clone)")
                            {
                                checkForItems += "1";
                                Destroy(child.gameObject);
                            }
                            if (child.name == "MatchesButton(Clone)")
                            {
                                checkForItems += "2";
                                Destroy(child.gameObject);
                            }
                        }

                        if (checkForItems == "112" || checkForItems == "121"
                            || checkForItems == "211")
                        {
                            wooshSFX.Play();

                            dollCollider2.SetActive(false);
                            dollCollider3.SetActive(true);
                            doorCollider1.SetActive(false);
                            doorCollider2.SetActive(true);
                            doll.GetComponent<Animator>().Play("dollfade");
                            key.SetActive(true);
                        }

                    }
                }

                if (rc.transform.name == "MusicBoxCollider (1)")
                {
                    panel.SetActive(true);
                    foreach (Transform child in panel.transform)
                    {
                        if (child.name == "Music Box")
                        {
                            child.gameObject.SetActive(true);
                        }
                    }
                }


                if (rc.transform.name == "PortraitCollider (2)")
                {
                    panel.SetActive(true);
                    foreach (Transform child in panel.transform)
                    {
                        if (child.name == "FramePuzzle")
                        {
                            child.gameObject.SetActive(true);
                        }
                    }
                }

                if (rc.transform.name == "DoorCollider (2)")
                {
                    foreach (GameObject slot in slots)
                    {
                        foreach (Transform child in slot.transform)
                        {
                            if (child.name == "HouseButton(Clone)")
                            {
                                SceneManager.LoadScene("ENDING");
                            }
                        }
                    }
                }
            }
        }
    }
}
