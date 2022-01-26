using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class KnifeTeleport : MonoBehaviour
{
    [SerializeField] private GameObject dialogueRunner;

    [SerializeField] private Transform JohnTP;
    [SerializeField] private Transform AntonTP;
    [SerializeField] private Transform SteveTP;

    [SerializeField] private Transform Knife;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueRunner.GetComponent<DialogueRunner>().Dialogue.CurrentNode == "JohnStart")
        {
            Knife.position = JohnTP.position;
        }
        if (dialogueRunner.GetComponent<DialogueRunner>().Dialogue.CurrentNode == "AntonKnife")
        {
            Knife.position = AntonTP.position;
        }
        if (dialogueRunner.GetComponent<DialogueRunner>().Dialogue.CurrentNode == "SteveKnife")
        {
            Knife.position = SteveTP.position;
        }
    }
}
