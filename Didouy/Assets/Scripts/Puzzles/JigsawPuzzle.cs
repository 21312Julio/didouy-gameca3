using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JigsawPuzzle : MonoBehaviour
{
    public GameObject FramePuzzle;
    [SerializeField] private GameObject player;
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);
    public GameObject panel;
    public Transform[] pictures;

    [Header("Activates")]
    public GameObject eye2;

    // Update is called once per frame
    void Update()
    {
        if (FramePuzzle != null)
        {
            if (pictures[0].rotation.z == 0 &&
                pictures[1].rotation.z == 0 &&
                pictures[2].rotation.z == 0 &&
                pictures[3].rotation.z == 0 &&
                pictures[4].rotation.z == 0 &&
                pictures[5].rotation.z == 0 &&
                pictures[6].rotation.z == 0)
            {
                Debug.Log("Checking Nearby");
                RaycastHit2D[] hits = Physics2D.BoxCastAll(player.transform.position, boxSize, 0, Vector2.zero);

                if (hits.Length > 0)
                {
                    Debug.Log("Hit Length");
                    foreach (RaycastHit2D rc in hits)
                    {
                        if (rc.transform.name == "PortraitCollider (2)")
                        {
                            eye2.SetActive(true);
                            foreach (Transform child in panel.transform)
                            {
                                if (child.name == "FramePuzzle")
                                {
                                    if (child.gameObject != null)
                                    {
                                        panel.SetActive(false);
                                        StartCoroutine(Destruct(child.gameObject));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }

    public void TurnPicture(GameObject image)
    {
        image.transform.Rotate(0f, 0f, 90f);
    }

    IEnumerator Destruct(GameObject gb)
    {
        yield return new WaitForSeconds(2f);
        Destroy(gb);
    }
}
