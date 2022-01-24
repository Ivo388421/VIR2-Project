using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Yarn.Unity;

public class TextChange : MonoBehaviour
{
    [SerializeField] GameObject memory;
    [SerializeField] TextMeshProUGUI TextPart;
    private Dictionary<string, object> Test = new Dictionary<string, object>();
    private string value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Test = memory.GetComponent<InMemoryVariableStorage>().variables;
        foreach (var item in Test)
        {
            if (item.Key == "$npcSaved")
            {
                value = item.Value.ToString();
            }
            
        }
        TextPart.text = "People Helped: " + value + "/7";
    }
}
