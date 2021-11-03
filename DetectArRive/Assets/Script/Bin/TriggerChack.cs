using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerChack : MonoBehaviour
{
    public Text text;
    static int _trigger = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onTriggerEnter(Collider other)
    {
        _trigger+=1;
        text.text = "Trigger = "+_trigger;
    }
}
