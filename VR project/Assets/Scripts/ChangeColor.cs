using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    [SerializeField]
    GameObject ScriptManager;
    [SerializeField]
    float maxPlayerDist = 8;
    [SerializeField]
    float minPlayerDist = 2;
    [SerializeField]
    int MinimumThreatLevel;
    Color colorStart = Color.green;
    Color colorEnd = Color.yellow;
    Renderer Rend;
    // Start is called before the first frame update
    void Start()
    {
        Rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Player.position, transform.position);
        Rend.material.color = Color.Lerp(colorEnd, colorStart, (dist/ maxPlayerDist) * (dist/minPlayerDist));
        if(ScriptManager.GetComponent<MainScript>().GlobalThreat <= MinimumThreatLevel)
        {
            colorStart = Color.green;
            colorEnd = Color.yellow;
        }
        else
        {
            colorStart = Color.yellow;
            colorEnd = Color.red;
        }
    }
}
