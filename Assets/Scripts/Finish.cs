using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Finish : MonoBehaviour
{
    public ParticleSystem particle, particle1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerConroller.instance.winPanel.SetActive(true);
            PlayerConroller.instance.start = false;
            PlayerConroller.instance.player1.transform.DOMoveX(0, 1);
            PlayerConroller.instance.player2.transform.DOMoveX(0, 1);
            particle1.Play();
            particle.Play();
            PlayerConroller.instance.bigPlayer.GetComponent<Animator>().SetBool("Run",false);
            PlayerConroller.instance.bigPlayer.GetComponent<Animator>().SetBool("Win",true);
            //PlayerConroller.instance.player1.transform.position = new Vector3(0, PlayerConroller.instance.player1.transform.position.y, PlayerConroller.instance.player1.transform.position.z);
            //PlayerConroller.instance.player2.transform.position = new Vector3(0, PlayerConroller.instance.player2.transform.position.y, PlayerConroller.instance.player2.transform.position.z);

        }
    }
}
