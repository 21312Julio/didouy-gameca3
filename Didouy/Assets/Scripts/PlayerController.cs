using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement controls;
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private DialogueManager dialogueManager2;
    private Vector2 boxSize = new Vector2(0.01f, 0.01f);

    public Sprite normal;
    public Sprite interact;

    [SerializeField]
    private GameObject aliveWorld;
    [SerializeField]
    private GameObject spiritWorld;
    [SerializeField]
    private GameObject Panel;

    // Alive World
    [SerializeField]
    private Tilemap groundTilemap;
    [SerializeField]
    private Tilemap collisionTilemap;
    // Spirit World
    [SerializeField]
    private Tilemap spiritGroundTilemap;
    [SerializeField]
    private Tilemap spiritCollisionTilemap;


    [SerializeField]
    private AudioSource walk;

    private void Awake()
    {
        controls = new PlayerMovement();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        controls.Main.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
        controls.Main.Interact.performed += ctx => CheckInteraction();
        controls.Main.ChangeWorld.performed += ctx => ChangeWorld();
        controls.Main.ClosePanel.performed += ctx => ClosePanel();
        //controls.Main.ContinueDialogue.performed += ctx => dialogueManager.ContinueStory();
    }

    private void ChangeWorld()
    {
        if (aliveWorld != null)
        {
            bool isActive = aliveWorld.activeSelf;
            aliveWorld.SetActive(!isActive);
        }

        if (spiritWorld != null)
        {
            bool isActive = spiritWorld.activeSelf;
            spiritWorld.SetActive(!isActive);
        }
    }

    private void Move(Vector2 direction)
    {
        if (dialogueManager.dialogueIsPlaying)
        {
            return;
        }

        if (dialogueManager2.dialogueIsPlaying)
        {
            return;
        }

        if (Panel.activeSelf == true)
        {
            return;
        }

        if (CanMove(direction) && CanMove2(direction))
        {
            transform.position += (Vector3)direction;
            walk.Play();
        }
    }

    private bool CanMove(Vector2 direction)
    {
        Vector3Int gridPosition = groundTilemap.WorldToCell(transform.position + (Vector3)direction);
        if (!groundTilemap.HasTile(gridPosition) || collisionTilemap.HasTile(gridPosition))
            return false;
        return true;
    }

    private bool CanMove2(Vector2 direction)
    {
        Vector3Int gridPosition = spiritGroundTilemap.WorldToCell(transform.position + (Vector3)direction);
        if (!spiritGroundTilemap.HasTile(gridPosition) || spiritCollisionTilemap.HasTile(gridPosition))
            return false;
        return true;
    }

    public void OpenInteractableIcon()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().sprite = interact;
    }

    public void CloseInteractableIcon()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().sprite = normal;
    }

    private void CheckInteraction()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, boxSize, 0, Vector2.zero);

        if(hits.Length > 0)
        {
            foreach(RaycastHit2D rc in hits)
            {
                if (rc.transform.GetComponent<Interactable>())
                {
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;
                }
            }
        }
    }

    private void ClosePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }

        foreach(Transform child in Panel.transform)
        {
            child.gameObject.SetActive(false);
            if (child.name == "Information")
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
