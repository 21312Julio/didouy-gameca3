using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option1Alive : MonoBehaviour
{
    // Player inventory and references
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);
    [SerializeField] private GameObject player;
    [SerializeField] private Inventory inv;
    private GameObject[] slots;
    private bool[] isFull;

    // Objects that will be either activated or deactivated depending on the choice made
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

    // Audios that will be played for the actions executed
    [Header("Audios")]
    [SerializeField] private AudioSource keySFX;
    [SerializeField] private AudioSource fixSFX;
    [SerializeField] private AudioSource wooshSFX;

    // Get the current inventory from the player
    public void Awake()
    {
        inv = player.GetComponent<Inventory>();
        slots = inv.slots;
        isFull = inv.isFull;
    }

    public void CheckNear()
    {
        // Send a raycast when the option 1 in alive world is pressed
        // The code will always check child objects of the inventory and tag/names of colliders
        // hit on raycast, depending on it will perform different function.
        Debug.Log("Checking Nearby");
        RaycastHit2D[] hits = Physics2D.BoxCastAll(player.transform.position, boxSize, 0, Vector2.zero);

        if (hits.Length > 0)
        {
            Debug.Log("Hit Length");
            foreach (RaycastHit2D rc in hits)
            {
                // If it hits the bookshelf it will use the key object in inventory and activate new collider
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

                // If it hits the active bookshelf with the code it will open a panel with the image
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

                //If it detects the third mirror collider option 1 will show the clock on panel
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

                // If it detects the second mirror collider it will use the glass piece from 
                // inventory and enable a new collider to use the mirror
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

                // If it detects the second doll collider, it will check for items on inventory
                // If you have all the items necessary, clicking the option 1 will execute action
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

                // If it detects the first collider of music box it will open the puzzle
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

                // If it detects the second portrait collider, it will open the portrait puzzle
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

                // If it detects the second door collider, you're able to use the key and open,
                // finishing the game
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
