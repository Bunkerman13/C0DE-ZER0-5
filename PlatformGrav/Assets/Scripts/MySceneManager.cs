using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySceneManager : Singleton<MySceneManager> {

    public float score;
    public float multiplier;
    public string scoreText;
    public int coins;
    public int finalScore;
    public int finalCoins;
    public float finalMultiplier;

    public AudioSource coin;
    public AudioSource hit;
    public AudioSource pick1;
    public AudioSource pick2;
    public AudioSource pick3;

    
    //private void SetScore()
    //{
    //    scoreText = "Final Score: " + finalScore;
    //}

    //private void Update()
    //{
    //    coin = GameObject.Find("Coin").GetComponent<AudioSource>();
    //    hit = GameObject.Find("Hit").GetComponent<AudioSource>();
    //    pick1 = GameObject.Find("Pick1").GetComponent<AudioSource>();
    //    pick2 = GameObject.Find("Pick2").GetComponent<AudioSource>();
    //    pick3 = GameObject.Find("Pick3").GetComponent<AudioSource>();
    //}
}
