using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager SharedInstance;

    public TMP_Text nameText;
    public TMP_Text dialogueText;

    public GameObject dialoguePanel;

    // Start is called before the first frame update
    void Start()
    {
        SharedInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchDialogue(VillagerScript chicken)
    {
        dialoguePanel.SetActive(true);
        nameText.text = chicken.name;
        dialogueText.text = chicken.utterances[0];
    }
}
