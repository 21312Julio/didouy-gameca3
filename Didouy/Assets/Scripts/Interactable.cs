using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class Interactable : MonoBehaviour
{
    // Always check for objects that inherit this class and open their actions based on their interactable
    // objects
    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;    
    }

    public abstract void Interact();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            collision.GetComponent<PlayerController>().OpenInteractableIcon();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            collision.GetComponent<PlayerController>().CloseInteractableIcon();
    }
}
