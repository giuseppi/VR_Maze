using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailDoorGame : MonoBehaviour
{
    // Start is called before the first frame update
    public DoorGameLogic DoorGameLogic;
    public CameraTeleport CameraTeleport;

    void OnTriggerStay(Collider other)
    {
            DoorGameLogic.loseDoor = true;
            CameraTeleport.charCnt.enabled = false;
            CameraTeleport.charCnt.transform.position = new Vector3(195f, 5, -10);
            CameraTeleport.charCnt.enabled = true;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
