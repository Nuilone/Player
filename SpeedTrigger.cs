using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        print(other.GetComponent<FirstPersonMovement>().runSpeed);
    }


    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
        print(other.GetComponent<FirstPersonMovement>().runSpeed);
    }
}