using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicChoice : MonoBehaviour
{
    public AudioSource shortSound;
    public AudioSource longSound;

    public GameObject musicBox;
    public string sequenceCombination = "";
    [SerializeField] private GameObject player;
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);
    public GameObject panel;
    [SerializeField] private GameObject dollCollider1;
    [SerializeField] private GameObject dollCollider2;

    [Header("Activates")]
    public GameObject matches1;

    // Update is called once per frame
    void Update()
    {
        if (musicBox != null)
        {
            if (sequenceCombination == "0111001010000111")
            {
                dollCollider1.SetActive(false);
                dollCollider2.SetActive(true);
                Debug.Log("Checking Nearby");
                RaycastHit2D[] hits = Physics2D.BoxCastAll(player.transform.position, boxSize, 0, Vector2.zero);

                if (hits.Length > 0)
                {
                    Debug.Log("Hit Length");
                    foreach (RaycastHit2D rc in hits)
                    {
                        if (rc.transform.name == "MusicBoxCollider (1)")
                        {
                            matches1.SetActive(true);
                            foreach (Transform child in panel.transform)
                            {
                                if (child.name == "Music Box")
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
            if (sequenceCombination.Length > 16)
            {
                sequenceCombination = "";
            }
        }
    }

    public void MakeSound(string digit)
    {
        sequenceCombination += digit;
    }

    public void PlaySound1()
    {
        shortSound.Play();
    }

    public void PlaySound2()
    {
        longSound.Play();
    }

    IEnumerator Destruct(GameObject gb)
    {
        yield return new WaitForSeconds(2f);
        Destroy(gb);
    }
}
