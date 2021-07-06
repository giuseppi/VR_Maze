using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorGame3 : MonoBehaviour
{
    // Start is called before the first frame update

    public DoorGameLogic DoorGameLogic;

    void OnTriggerStay(Collider other)
    {
        DoorGameLogic.openDoor3 = true;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
