using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerConroller.instance.winPanel.SetActive(true);
            PlayerConroller.instance.start = false;
            PlayerConroller.instance.player1.transform.position = new Vector3(0, PlayerConroller.instance.player1.transform.position.y, PlayerConroller.instance.player1.transform.position.z);
            PlayerConroller.instance.player2.transform.position = new Vector3(0, PlayerConroller.instance.player2.transform.position.y, PlayerConroller.instance.player2.transform.position.z);

        }
    }
}
