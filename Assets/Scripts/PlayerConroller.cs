using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerConroller : MonoBehaviour
{
    public static PlayerConroller instance;
    public GameObject player1;
    public GameObject player2;
    public GameObject bigPlayer;
    public bool start;
    public float speed;
    public GameObject failPanel;
    public GameObject winPanel;
    public int score;
    public TextMeshProUGUI scoreText;

    private Animator playerAnim1;
    private Animator playerAnim2;
    private Animator bigPlayerAnim;
    void Start()
    {
        instance = this;
        playerAnim1 = player1.GetComponent<Animator>();
        playerAnim2 = player2.GetComponent<Animator>();
        bigPlayerAnim = bigPlayer.GetComponent<Animator>();
    }


    void Update()
    {
        PlayerMove();
        CheckDistance();
    }
    void PlayerMove()
    {
        if (Input.GetMouseButtonDown(0) && !failPanel.activeInHierarchy && !winPanel.activeInHierarchy)
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
        else
        {
            transform.Translate(0, 0, 0);
            playerAnim1.SetBool("Run", false);
            playerAnim2.SetBool("Run", false);
            bigPlayerAnim.SetBool("Run", false);
        }
    }

    void CheckDistance()
    {
        if (Vector3.Distance(player1.transform.position, player2.transform.position) < 2f)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            player1.SetActive(false);
            player2.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            player1.SetActive(true);
            player2.SetActive(true);
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
