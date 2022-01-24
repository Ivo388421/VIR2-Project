using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class Knife : MonoBehaviour
{
    [SerializeField] GameObject memory;

    [SerializeField] MeshRenderer KnifeObject;
    [SerializeField] MeshRenderer KnifeObjectHandle;

    private bool KnifeTrue = false;

    [SerializeField] private GameObject image;

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
                    KnifeTrue = true;
                }
                else
                {
                    KnifeTrue = false;
                }
            }
            
        }
        if (KnifeTrue == true)
        {
            KnifeObject.enabled = true;
            KnifeObjectHandle.enabled = true;
            image.GetComponent<Image>().color = new Color32(114,114,114,120);
        }
        else
        {
            KnifeObject.enabled = false;
            KnifeObjectHandle.enabled = false;
            image.GetComponent<Image>().color = new Color32(255,255,255,0);
        }
        
    }
}
