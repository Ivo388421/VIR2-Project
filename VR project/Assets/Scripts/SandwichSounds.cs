using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichSounds : MonoBehaviour
{
    [SerializeField] private AudioSource selectedSongManagement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void eating()
    {
        selectedSongManagement.Play();
    }
}
