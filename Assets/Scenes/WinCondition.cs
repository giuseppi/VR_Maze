using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool redKey = false;           
    public static bool greenKey = false;
    public static bool blueKey = false;
    public static bool purpleKey = false;
    public Light red, green, blue, purple;
    public GameObject rLight, gLight, bLight, pLight, EndDoorL, EndDoorR;
    public bool openDoor = false;
    public float doorTimer = 0.0f;
    public bool startTimer = false;

    void OnTriggerStay(Collider other)
    {
            if (!openDoor)
            {
                if (redKey)
                {
                    red.enabled = true;
                }

                if (greenKey)
                {
                    green.enabled = true;
                }

                if (blueKey)
                {
                    blue.enabled = true;
                }

                if (purpleKey)
                {
                    purple.enabled = true;
                }

                if (redKey && greenKey && blueKey && purpleKey)
                {
                    openDoor = true;
                }
            }

            else
            {
                if (!startTimer)
                {
                    startTimer = true;
                }

                if ((doorTimer += Time.deltaTime) > 2.0f)
                {
                    EndDoorL.transform.position -= new Vector3(1f * Time.deltaTime, 0, 0);
                    EndDoorR.transform.position += new Vector3(1f * Time.deltaTime, 0, 0);
                }

                if ((doorTimer += Time.deltaTime) > 13.0f)
                {
                    EndDoorL.transform.position = new Vector3(-4.12f, 0, -0.35f);
                    EndDoorR.transform.position = new Vector3(3.96f, 0, 0.65f);
                }
            }
    }

    void Start()
    {
        red = rLight.GetComponent<Light>();
        green = gLight.GetComponent<Light>();
        blue = bLight.GetComponent<Light>();
        purple = pLight.GetComponent<Light>();
        red.enabled = false;
        green.enabled = false;
        blue.enabled = false;
        purple.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
