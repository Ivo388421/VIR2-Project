using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Serialization;

public class MovePlayer : MonoBehaviour
{
    [FormerlySerializedAs("Speed")] [SerializeField]
    private float speed = 4;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector3 movement =  new Vector3(
            Input.GetAxis("Horizontal"), 
            0, 
            Input.GetAxis("Vertical")) * (Time.deltaTime * speed);
        transform.Translate(movement);
    }
    private void OnDestroy() {
        AnalyticsEvent.LevelComplete(name:"Level 1", eventData:new Dictionary<string, object>{
            {"Player_Seen", speed}
        });
    }
}
