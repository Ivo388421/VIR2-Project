using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Knife : MonoBehaviour
{
    [SerializeField] GameObject memory;

    [SerializeField] MeshRenderer KnifeObject;

    private bool KnifeTrue = false;

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
        }
        else
        {
            KnifeObject.enabled = false;
        }
        
    }
}
