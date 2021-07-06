using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailColorGame : MonoBehaviour
{
    // Start is called before the first frame update
    public ColorGameLogic ColorGameLogic;
    public CameraTeleport CameraTeleport;
    public bool oneTime = true;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (oneTime)
            {
                ColorGameLogic.loseColor = true;
                CameraTeleport.charCnt.enabled = false;
                CameraTeleport.charCnt.transform.position = new Vector3(132.3f, 2, -211.3f);
                CameraTeleport.charCnt.enabled = true;
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
