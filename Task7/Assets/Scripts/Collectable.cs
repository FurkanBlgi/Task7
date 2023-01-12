using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerConroller.instance.score += 5;
            PlayerConroller.instance.scoreText.text = PlayerConroller.instance.score.ToString();
            PlayerConroller.instance.bigPlayer.transform.localScale = new Vector3(PlayerConroller.instance.bigPlayer.transform.localScale.x + .1f, PlayerConroller.instance.bigPlayer.transform.localScale.y + .1f, PlayerConroller.instance.bigPlayer.transform.localScale.z + .1f);
            Destroy(gameObject);
        }
    }
}
