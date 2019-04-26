using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCoin : PowerUp {

    public GameObject coinPrefab, rainCoinPrefab;
    public Vector2 playerPos;
    public static bool RAINING;

    public override void Start()
    {
        base.Start();
        RAINING = false;
    }

    // Update is called once per frame
    public override void Update () {
        playerPos = GameObject.Find("Player").transform.position;

        base.Update();

        //while active, move any coins on screen down
        if (isActive)
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Coin");
            foreach (GameObject g in objs)
            {
                g.transform.position += Vector3.down * .1f;
            }
        }

        //spawns them every other second
        if (isActive && coinPrefab != null)
        {
            if ((int)duration % 2 == 1 && duration > 3)
            {
                //rain coins at random positions on screen
                Instantiate(coinPrefab, new Vector2(Random.Range(playerPos.x + 25, playerPos.x + 60),
                    Random.Range(playerPos.y + 9, playerPos.y + 20)), Quaternion.identity);

            }

            if (duration <= 3)
            {
                GameObject[] objs = GameObject.FindGameObjectsWithTag("Coin");

                foreach (GameObject g in objs)
                {
                    //fade out sprite before it disappears
                    Color tempColor = g.GetComponent<SpriteRenderer>().color;
                    tempColor.a -= .1f;
                    g.GetComponent<SpriteRenderer>().color = tempColor;

                    // Destroy(g, 3);
                    g.SetActive(false);
                }
            }
        }
	}

    public void SetActive()
    {
        Instantiate(rainCoinPrefab, GameObject.Find("Player").transform.position , Quaternion.identity);
    }
}
