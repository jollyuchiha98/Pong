using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Conuntscore : MonoBehaviour {
    public Text ScoreBoard;
    
    public GameObject ball; 
    
    private int Pong_Asset_0_Score = 0;
    
    private int Pong_Asset_2_Score = 0;
	// Use this for initialization
	void Start () {
        
        ball = GameObject.Find("Ball");  
	
    }
	
	// Update is called once per frame
	
    void Update () {
        if (ball.transform.position.x > 18)
        {
            Pong_Asset_0_Score++; 
        }
        if (ball.transform.position.x < -18)
        {
            Pong_Asset_2_Score++;
        }
        ScoreBoard.text = Pong_Asset_0_Score.ToString() + "-" + Pong_Asset_2_Score.ToString();
        
        print(Pong_Asset_0_Score + " , " + Pong_Asset_2_Score);


	}
}
