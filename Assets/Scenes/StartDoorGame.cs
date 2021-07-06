using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDoorGame : MonoBehaviour
{
    // Start is called before the first frame update

    public DoorGameLogic DoorGameLogic;

    void OnTriggerStay(Collider other)
    {
        DoorGameLogic.startDoor = true;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
