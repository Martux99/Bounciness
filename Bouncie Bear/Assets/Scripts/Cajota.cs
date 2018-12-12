﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajota : MonoBehaviour {

    Rigidbody2D player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            player = collision.gameObject.GetComponent<Rigidbody2D>();
            player.gravityScale = 0;
            player.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 0.5f);
            
        }
    }

}
