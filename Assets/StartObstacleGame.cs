using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartObstacleGame : MonoBehaviour
{
    // Start is called before the first frame update

    public platform_script_1 platform_script_1;

    void OnTriggerStay(Collider other)
    {
        platform_script_1.startDoor = true;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
