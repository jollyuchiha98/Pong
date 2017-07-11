using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        StartCoroutine(Pause());
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x >= 18)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
        if (this.transform.position.x <= -18)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
    }
	IEnumerator Pause() 
    {
    yield return  new WaitForSeconds (2);
    rb.velocity = new Vector2(11, 11); 
    }

        
    
    }
