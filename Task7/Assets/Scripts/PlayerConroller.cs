using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    public static PlayerConroller instance;
    public GameObject player1;
    public GameObject player2;
    public bool start;
    public float speed;

    private Animator playerAnim1;
    private Animator playerAnim2;
    private Animator bigPlayerAnim;
    void Start()
    {
        instance = this;
        playerAnim1 = player1.GetComponent<Animator>();
        playerAnim2 = player2.GetComponent<Animator>();
        bigPlayerAnim=transform.GetChild(0).GetComponent<Animator>();
    }


    void Update()
    {
        PlayerMove();
        CheckDistance();
    }
    void PlayerMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            start = true;
        }
        if (start)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            playerAnim1.SetBool("Run", true);
            playerAnim2.SetBool("Run", true);
            bigPlayerAnim.SetBool("Run", true);
        }
    }
    void CheckDistance()
    {
        if (Vector3.Distance(player1.transform.position, player2.transform.position) < 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            player1.SetActive(false);
            player2.SetActive(false);
            /*player1.transform.GetChild(1).gameObject.SetActive(false);
            player2.transform.GetChild(1).gameObject.SetActive(false);*/
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            player1.SetActive(true);
            player2.SetActive(true);
            /*player1.transform.GetChild(1).gameObject.SetActive(true);
            player2.transform.GetChild(1).gameObject.SetActive(true);*/
        }
    }
}
