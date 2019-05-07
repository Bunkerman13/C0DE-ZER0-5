using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerBox : MonoBehaviour
{
    private void Start()
    {
        if (MySceneManager.Instance.coin == null)
        {
            MySceneManager.Instance.coin = GameObject.Find("Coin").GetComponent<AudioSource>();
            MySceneManager.Instance.hit = GameObject.Find("Hit").GetComponent<AudioSource>();
            MySceneManager.Instance.pick1 = GameObject.Find("Pick1").GetComponent<AudioSource>();
            MySceneManager.Instance.pick2 = GameObject.Find("Pick2").GetComponent<AudioSource>();
            MySceneManager.Instance.pick3 = GameObject.Find("Pick3").GetComponent<AudioSource>();
        }
        //SetScore();
    }
    //fixed update makes score incrment every second by 1
    void FixedUpdate()
    {
        MySceneManager.Instance.score += .05f;
    }
}


