using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option2Alive : MonoBehaviour
{
    // Get references from player and the safe puzzle game object 
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);
    [SerializeField] private GameObject player;
    [SerializeField] private Inventory inv;
    private GameObject[] slots;
    public SafePuzzle puzzle;

    // Objects to be activated/deactivated depending on action performed
    [Header("Activates")]
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject colliderMirror1;
    [SerializeField] private GameObject colliderMirror2;
    [SerializeField] private GameObject colliderMirror3;

    public void Awake()
    {
        // Set references to player inventory
        inv = player.GetComponent<Inventory>();
        slots = inv.slots;
    }

    public void CheckNear()
    {
        // Send a raycast when the option 2 in alive world is pressed
        // The code will always check child objects of the inventory and tag/names of colliders
        // hit on raycast, depending on it will perform different function.
        Debug.Log("Checking Nearby");
        RaycastHit2D[] hits = Physics2D.BoxCastAll(player.transform.position, boxSize, 0, Vector2.zero);

        if (hits.Length > 0)
        {
            Debug.Log("Hit Length");
            foreach (RaycastHit2D rc in hits)
            {
                // If it hits the mirrorsafecollider, the second option will always open the safe
                // puzzle
                if (rc.transform.name == "MirrorSafeCollider (1)" || 
                    rc.transform.name == "MirrorSafeCollider (2)" ||
                    rc.transform.name == "MirrorSafeCollider (3)")
                {
                    Debug.Log("asdas");
                    panel.SetActive(true);
                    foreach (Transform child in panel.transform)
                    {
                        if (child.name == "Safe")
                        {
                            if (child.gameObject != null)
                            {
                                child.gameObject.SetActive(true);
                            }   
                        }
                    }
                }
            }
        }
    }
}
