using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDoorGame : MonoBehaviour
{
    // Start is called before the first frame update

    public WinCondition WinCondition;
    public GameObject redKey;
    public bool oneTime = true;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (oneTime)
            {
                redKey.transform.position = new Vector3(221, -5, -13); //make disappear
                WinCondition.redKey = true;
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
