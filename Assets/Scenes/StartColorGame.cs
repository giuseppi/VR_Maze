using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartColorGame : MonoBehaviour
{
    // Start is called before the first frame update

    public ColorGameLogic ColorGameLogic;

    void OnTriggerStay(Collider other)
    {
        ColorGameLogic.startColor = true;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
