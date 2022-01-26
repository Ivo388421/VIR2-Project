using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WallScript : MonoBehaviour
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
                    if (item.Key == "$johnTalked")
                    {
                        if (item.Value.ToString() == "True")
                        {
                            Destroy(gameObject);
                        }
                    }
                    if (item.Key == "$AntonTalked")
                    {
                        if (item.Value.ToString() == "True")
                        {
                            Destroy(gameObject);
                        }
                    }
                    if (item.Key == "$steveTalked")
                    {
                        if (item.Value.ToString() == "True")
                        {
                            Destroy(gameObject);
                        }
                    }
                    
                }
    }
}
