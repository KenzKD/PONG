using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header ("Ball")]
    public GameObject Ball;

    
    [Header ("Player1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;


    [Header ("Player2")]
    public GameObject Player2Paddle;
    public GameObject Player2Goal;


    [Header ("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;
    private int Player1Score; 
    private int Player2Score;
    private void ResetPosition()
    {
        Ball.GetComponent<Ball>().Reset();
    }
    public void Player1Scored ()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

     public void Player2Scored ()
    {
        Player2Score ++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
