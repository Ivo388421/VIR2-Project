using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MusicSwitch : MonoBehaviour
{
    [SerializeField] GameObject memory;
    private Dictionary<string, object> Test = new Dictionary<string, object>();

    [SerializeField] private AudioSource selectedSongManagement;

    [SerializeField] private AudioClip BadMusic;
    [SerializeField] private AudioClip GoodMusic;
    [SerializeField] private AudioClip drill;

    private bool PauseOther;
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
                if (item.Value.ToString() == "True" && PauseOther == false)
                {
                    
                    selectedSongManagement.clip = BadMusic;
                    if (selectedSongManagement.isPlaying == false)
                    {
                        selectedSongManagement.Play();
                    }
                    
                }
                if (item.Value.ToString() == "false" && PauseOther == false)
                {
                    selectedSongManagement.clip = GoodMusic;
                    if (selectedSongManagement.isPlaying == false)
                    {
                        selectedSongManagement.Play();
                    }
                }
                
            }

            if (item.Key == "$Music")
            {
                if (item.Value.ToString() == "True")
                {
                    selectedSongManagement.clip = drill;
                    PauseOther = true;
                    if (selectedSongManagement.isPlaying == false)
                    {
                        selectedSongManagement.Play();
                    }
                }
                else
                {
                    PauseOther = false;
                }
            }
        }
    }
}
