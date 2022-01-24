using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableTP : MonoBehaviour
{
    [SerializeField] private GameObject LocomotionSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DialogueStart()
    {
        LocomotionSystem.GetComponent<TeleportationProvider>().enabled = false;
    }
    
    public void DialogueEnd()
    {
        LocomotionSystem.GetComponent<TeleportationProvider>().enabled = true;
    }
}
