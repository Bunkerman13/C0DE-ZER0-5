using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
   

    void OnTriggerEnter2D(Collider2D other)
    {

        
        
        if (other.gameObject.tag == "Player")
        {
            //other.gameObject.gameObject.GetComponent<playerBox>().score += 40;


            
            //Debug.Log(gameObject.tag);
            if (gameObject.tag == "SlowAbility")
            {
                gameObject.GetComponent<SlowDown>().isActive = true;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.transform.position = new Vector2(-100, -100);
                MySceneManager.Instance.pick3.Play();
            }
            else if (gameObject.tag == "RainCoin")
            {
                gameObject.GetComponent<RainCoin>().isActive = true;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.transform.position = new Vector2(-100, -100);
                MySceneManager.Instance.pick2.Play();
            }
            else if (gameObject.tag == "Coin")
            {

                MySceneManager.Instance.score += 10;
                MySceneManager.Instance.multiplier += .1f;
                MySceneManager.Instance.coins++;
                MySceneManager.Instance.coin.Play();
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.SetActive(false);
            }
            else if(gameObject.tag == "Spike")
            {
                .Log("Hit a spike");
                MySceneManager.Instance.finalScore = MySceneManager.Instance.score;
                MySceneManager.Instance.score = 0;
                MySceneManager.Instance.coins = 0;
                MySceneManager.Instance.multiplier = 0;
                //Physics.gravity = new Vector3(0, -50, 0);
                Physics2D.gravity = new Vector2(0, -50f);
                other.gameObject.GetComponent<MainMenu>().Menuetwo();
                MySceneManager.Instance.hit.Play();
            }
            else if (gameObject.tag == "Mag")
            {
				gameObject.GetComponent<coinMagnet>().isActive = true;
				gameObject.GetComponent<coinMagnet> ().duration = 10;
				gameObject.GetComponent<SpriteRenderer>().enabled = false;
				gameObject.transform.position = new Vector2(-100, -100);
                MySceneManager.Instance.pick1.Play();
                //Destroy(gameObject);
            }
            



        }
        else
        {

            Vector2 looping = GameObject.Find("Spawn Objects").GetComponent<RectTransform>().position;
            //Debug.Log(transform.position.y);
            gameObject.transform.position = new Vector2(looping.x, transform.position.y);
        }
    }


}
