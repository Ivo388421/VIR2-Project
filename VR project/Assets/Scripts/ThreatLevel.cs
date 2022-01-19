using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreatLevel : MonoBehaviour
{
    bool Inventory = false;
    [SerializeField]
    int ThreatLow = 1;
    [SerializeField] 
    Transform Inventory1;
    [SerializeField]
    int ThreatOrigin = 9;
    public int ThreatNow = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= Inventory1.position.x + 0.1 &&
            transform.position.x >= Inventory1.position.x - 0.1 &&
            transform.position.y <= Inventory1.position.y + 0.1 &&
            transform.position.y >= Inventory1.position.y - 0.1 &&
            transform.position.z <= Inventory1.position.z + 0.1 &&
            transform.position.z >= Inventory1.position.z - 0.1)
        {
            Inventory = true;
        }
        else
        {
            Inventory = false;
        }

    }

    public void Grabbed()
    {
        if (Inventory == false)
        {
            ThreatNow = ThreatOrigin;
        }
    }

    public void Released()
    {
        ThreatNow = ThreatLow;
    }
}
