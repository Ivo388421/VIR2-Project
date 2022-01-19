using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    [SerializeField]
    int totalThreat = 0;
    public int GlobalThreat = 0;
    public List<GameObject> Interactables = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalThreat = 0;
        foreach(GameObject G in Interactables)
        {
            totalThreat += G.GetComponent<ThreatLevel>().ThreatNow;
        }
        GlobalThreat = totalThreat;
    }
}
