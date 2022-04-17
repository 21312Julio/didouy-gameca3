using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option1Spirit : MonoBehaviour
{
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource spirit;
    [SerializeField] private AudioSource clock;

    [Header("Objects")]
    [SerializeField] private GameObject mirror;
    [SerializeField] private GameObject interactPortrait1;
    [SerializeField] private GameObject interactPortrait2;
    [SerializeField] private GameObject musicKey;

    [Header("Spirits")]
    [SerializeField] private GameObject spirit1;
    [SerializeField] private GameObject spirit2;
    [SerializeField] private GameObject spirit3;

    [Header("Interactables")]
    [SerializeField] private GameObject morse1spirit;
    [SerializeField] private GameObject morse2spirit;
    [SerializeField] private GameObject morse1alive;
    [SerializeField] private GameObject morse2alive;
    [SerializeField] private GameObject mirror1alive;
    [SerializeField] private GameObject mirror2alive;

    public void CheckNear()
    {
        Debug.Log("Checking Nearby");
        RaycastHit2D[] hits = Physics2D.BoxCastAll(player.transform.position, boxSize, 0, Vector2.zero);

        if (hits.Length > 0)
        {
            Debug.Log("Hit Length");
            foreach (RaycastHit2D rc in hits)
            {
                Debug.Log("Raycast Hit");
                if (rc.transform.tag == "Spirit1")
                {
                    spirit.Play();
                    spirit1.GetComponent<Animator>().Play("spirit1fade");
                    mirror.SetActive(true);
                    Debug.Log("Mirror Active");
                    Destroy(mirror1alive);
                    mirror2alive.SetActive(true);

                }

                else if (rc.transform.tag == "Spirit2")
                {
                    spirit.Play();
                    interactPortrait1.SetActive(false);
                    interactPortrait2.SetActive(true);
                    spirit2.GetComponent<Animator>().Play("spirit2fade");
                    Debug.Log("Eye2 Active");
                }

                else if (rc.transform.tag == "MusicKey")
                {
                    spirit.Play();
                    musicKey.SetActive(true);
                    spirit3.GetComponent<Animator>().Play("spirit3fade");
                    Debug.Log("Music Key Active");
                    Destroy(morse1spirit);
                    morse2spirit.SetActive(true);
                    Destroy(morse1alive);
                    morse2alive.SetActive(true);
                }

                else if (rc.transform.tag == "MusicKey")
                {
                    spirit.Play();
                    musicKey.SetActive(true);
                    spirit3.GetComponent<Animator>().Play("spirit3fade");
                    Debug.Log("Music Key Active");
                    Destroy(morse1spirit);
                    morse2spirit.SetActive(true);
                    Destroy(morse1alive);
                    morse2alive.SetActive(true);
                }

                else if (rc.transform.name == "ClockCollider")
                {
                    clock.Play();
                }
            }
        }
    }
}
