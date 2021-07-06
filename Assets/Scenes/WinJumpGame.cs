using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinJumpGame : MonoBehaviour
{
    // Start is called before the first frame update

    public WinCondition WinCondition;
    public GameObject blueKey, StartObstacleDoor;
    public bool oneTime = true;
    public float startingTimer = 0.0f;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (oneTime)
            {
                blueKey.transform.position = new Vector3(221, -5, -13); //make disappear
                WinCondition.blueKey = true;
                StartObstacleDoor.transform.position = new Vector3(226.25f, -2, -218.58f);
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
