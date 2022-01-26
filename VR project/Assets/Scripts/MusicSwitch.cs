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

    [SerializeField] private bool PauseOther;

    [SerializeField] private bool badmusicPlay;

    [SerializeField] private bool goodmusicPlay;

    [SerializeField] private bool drillmusicPlay;
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
                    if (badmusicPlay == false && PauseOther == false)
                    {
                        selectedSongManagement.Stop();
                        selectedSongManagement.clip = BadMusic;
                        selectedSongManagement.Play();
                        badmusicPlay = true;
                        goodmusicPlay = false;
                        drillmusicPlay = false;
                    }


                }
                if (item.Value.ToString() == "False")
                {
                    if (goodmusicPlay == false && PauseOther == false)
                    {
                        selectedSongManagement.Stop();
                        selectedSongManagement.clip = GoodMusic;
                        selectedSongManagement.Play();
                        badmusicPlay = false;
                        goodmusicPlay = true;
                        drillmusicPlay = false;
                    }
                    
                }
                
            }

            if (item.Key == "$Music")
            {
                if (item.Value.ToString() == "True")
                {
                    if (drillmusicPlay == false && PauseOther == false)
                    {
                        selectedSongManagement.Stop();
                        selectedSongManagement.clip = drill;
                        selectedSongManagement.Play();
                        badmusicPlay = false;
                        goodmusicPlay = false;
                        drillmusicPlay = true;
                        PauseOther = true;
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
