using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    [SerializeField] private AudioSource pickup;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //item can be added to inventory
                    pickup.Play();
                    inventory.isFull[i] = true; //set current slot to true
                    Instantiate(itemButton, inventory.slots[i].transform, false); //create itembutton at slot position
                    Destroy(gameObject);//destroy pickup in world
                    break;
                }
            }
        }
    }

}
