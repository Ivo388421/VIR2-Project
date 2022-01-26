using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Yarn.Unity;

public class ChangeText : MonoBehaviour
{
    [SerializeField] GameObject memory;
    private Dictionary<string, object> Test = new Dictionary<string, object>();
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
            if (item.Key == "$hasknife")
            {
                if (item.Value.ToString() == "True")
                {
                    gameObject.GetComponent<TextMeshProUGUI>().text = "You have a knife.";
                    gameObject.GetComponent<TextMeshProUGUI>().color = Color.red;
                }
                else
                {
                    gameObject.GetComponent<TextMeshProUGUI>().text = "You don't have a knife.";
                    gameObject.GetComponent<TextMeshProUGUI>().color = Color.green;
                }
            }
                    
        }
    }
}
