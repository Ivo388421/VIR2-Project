using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreatLevel : MonoBehaviour
{
    [SerializeField]
    int ThreatLow = 1;
    [SerializeField]
    int ThreatOrigin = 9;
    public int ThreatNow = 1;
    private bool grabbed;
    
    GameObject[] inventoryList = new GameObject[]{} ;
    // Start is called before the first frame update
    void Start()
    {
        inventoryList = GameObject.FindGameObjectsWithTag("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        if (InventoryCheck() == true && grabbed == true)
        {
            ThreatNow = ThreatLow;
        }

        if (grabbed == true && InventoryCheck() == false)
        {
            ThreatNow = ThreatOrigin;
        }
        else
        {
            ThreatNow = ThreatLow;
        }

    }

    public void Grabbed()
    {
        grabbed = true;
    }

    public void Released()
    {
        grabbed = false;
    }

    public bool InventoryCheck()
    {
        foreach(GameObject Inventory in inventoryList)
        {
            if (transform.position.x <= Inventory.transform.position.x + 0.05 &&
                transform.position.x >= Inventory.transform.position.x - 0.05 &&
                transform.position.y <= Inventory.transform.position.y + 0.05 &&
                transform.position.y >= Inventory.transform.position.y - 0.05 &&
                transform.position.z <= Inventory.transform.position.z + 0.05 &&
                transform.position.z >= Inventory.transform.position.z - 0.05)
            {
                return true;
            }
        }

        return false;
    }
}
