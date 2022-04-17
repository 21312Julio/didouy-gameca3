using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option2Alive : MonoBehaviour
{
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);
    [SerializeField] private GameObject player;
    [SerializeField] private Inventory inv;
    private GameObject[] slots;
    public SafePuzzle puzzle;

    [Header("Activates")]
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject colliderMirror1;
    [SerializeField] private GameObject colliderMirror2;
    [SerializeField] private GameObject colliderMirror3;

    public void Awake()
    {
        inv = player.GetComponent<Inventory>();
        slots = inv.slots;
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
