using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapLaserScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TrapRoomScript TrapRoomScript;

    void OnTriggerEnter(Collider other)
    {
        TrapRoomScript.loseGame = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
