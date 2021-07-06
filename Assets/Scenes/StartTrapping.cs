using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrapping : MonoBehaviour
{
    // Start is called before the first frame update
    public TrapRoomScript TrapRoomScript;
    public bool oneTime = true;
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (oneTime)
            {
                TrapRoomScript.trapStart = true;
                oneTime = false;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
