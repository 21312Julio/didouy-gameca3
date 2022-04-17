using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(player.position.x, -1.5f, -1.5f),
            Mathf.Clamp(player.position.y, -5.8f, 0.79f),
            transform.position.z);
    }
}
