using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMagnet : PowerUp {
	GameObject player;
    GameObject effectMag;
    RaycastHit2D[] hit;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
        effectMag = GameObject.Find("PlayerMagnet");
        effectMag.GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        effectMag.transform.position = player.transform.position;
		if (isActive == true&&duration>0) {
            duration -= Time.deltaTime;
			hit = Physics2D.CircleCastAll(new Vector2(player.transform.position.x, player.transform.position.y), 10, Vector2.right, 10);
            effectMag.GetComponent<SpriteRenderer>().enabled = true;


            for (int i = 0; i < hit.Length; i++) {
				if (hit [i].transform.tag == "Coin" && hit[i]) {
					Debug.Log ("coin");
					MySceneManager.Instance.score += 10;
					MySceneManager.Instance.multiplier += .1f;
					MySceneManager.Instance.coins++;
					Destroy (hit [i].transform.gameObject);
                    MySceneManager.Instance.coin.Play();

                }
			}
			}
       if(duration <= 0)
        {
            effectMag.GetComponent<SpriteRenderer>().enabled = false;
        }
    }	
	}

