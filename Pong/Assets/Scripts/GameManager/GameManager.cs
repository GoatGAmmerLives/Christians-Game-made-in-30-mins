using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //Varibles 
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2paddle;
    public GameObject player2Goal;

    [Header("Player 2")]
    public GameObject Player1text;
    public GameObject Player2text;

    private int Player1Score;
    private int Player2Score;
    //Done

    public void Player1Scored()
    {
        Player1Score++;
        Player1text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }
    public void Player2Scored()
    {
        Player1Score++;
        Player2text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1paddle.GetComponent<Paddle>();
        player2paddle.GetComponent<Paddle>();
    }
}
