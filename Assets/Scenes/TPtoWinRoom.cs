using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPtoWinRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public CameraTeleport CameraTeleport;

    void OnTriggerStay(Collider other)
    {
        CameraTeleport.winGame = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
