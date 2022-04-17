using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;

    public void Update()
    {
        if (slot1.transform.childCount == 0)
        {
            isFull[0] = false;
        }

        if (slot2.transform.childCount == 0)
        {
            isFull[1] = false;
        }

        if (slot3.transform.childCount == 0)
        {
            isFull[2] = false;
        }
    }


}
