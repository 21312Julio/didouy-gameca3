using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] AudioSource talking;

    private PlayerMovement player;
    private static DialogueManager instance;

    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private Text dialogue;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private Text[] choicesText;

    private Story currentStory;

    public bool dialogueIsPlaying { get; private set; }

    // Instantiate the Dialogue Manager
    private void Awake()
    {
        if  (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        }
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        choicesText = new Text[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<Text>();
            index++;
        }
    }

    private void Update()
    {
        // If any dialogue is playing, the character cannot move
        if (!dialogueIsPlaying)
        {
            return;
        }

        // If enter is pressed, continue the story
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ContinueStory();
        }

    }

    // Enter dialogue mode, so the player can't move and inkJSON file is retrieved and displayed
    // On the screen at the panel, along with options
    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        ContinueStory();
    }

    // Exit dialogue mode if the dialogue is finished and close interaction
    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogue.text = "";
    }

    // Continue the story if there is more text on the ink file
    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogue.text = currentStory.Continue();
            talking.Play();
            DisplayChoices();
        }
        else
        {
            ExitDialogueMode();
        }
    }

    // Get choices from the ink file and display them to both button objects
    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if(currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices " +
                "given: " + currentChoices.Count);
        }

        int index = 0;
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for(int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    // Set first button selected at every dialogue interaction
    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    // When an option is detected, it is passed to dialogue manager depending on button assigned
    // And the story continues
    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        Debug.Log("Choice is choiceIndex");
    }
}
