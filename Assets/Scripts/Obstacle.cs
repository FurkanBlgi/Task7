using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerConroller.instance.failPanel.SetActive(true);
            PlayerConroller.instance.start = false;
        }
    }
}
