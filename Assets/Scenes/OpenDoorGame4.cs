using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorGame4 : MonoBehaviour
{
    // Start is called before the first frame update

    public DoorGameLogic DoorGameLogic;

    void OnTriggerStay(Collider other)
    {
        DoorGameLogic.openDoor4 = true;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
