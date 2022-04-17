using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeChoice : MonoBehaviour
{
    public GameObject codeText;
    public string codeTextValue = "";
    [SerializeField] private GameObject player;
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);
    public GameObject panel;
    public float delay = 0.2f;

    [Header("Activates")]
    public GameObject eye1;

    // Update is called once per frame
    void Update()
    {
        if (codeText != null)
        {
            codeText.GetComponent<Text>().text = codeTextValue;
            if (codeTextValue == "1213")
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
                            eye1.SetActive(true);
                            foreach (Transform child in panel.transform)
                            {
                                if (child.name == "Safe")
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
            if (codeTextValue.Length > 4)
            {
                codeTextValue = "";
            }
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

    IEnumerator Destruct(GameObject gb)
    {
        yield return new WaitForSeconds(2f);
        Destroy(gb);
    }
}
