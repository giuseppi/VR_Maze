using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndColorGame : MonoBehaviour
{
    // Start is called before the first frame update
    public ColorGameLogic ColorGameLogic;
    public WinCondition WinCondition;
    public GameObject purpleKey;
    public bool oneTime = true;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (oneTime)
            {
                ColorGameLogic.endColor = true;
                purpleKey.transform.position = new Vector3(41.1f, -5, -216); //make disappear
                WinCondition.purpleKey = true;
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
