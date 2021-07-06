using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class IncJump : MonoBehaviour
{
        // Start is called before the first frame update
        public AudioSource mainSong, mini;
        public GameObject FPSController;

        void OnTriggerStay(Collider other)
        {
            FPSController.GetComponent<FirstPersonController>().m_JumpSpeed = 12;
            mainSong.Stop();
            mini.Play();
        }

        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}
