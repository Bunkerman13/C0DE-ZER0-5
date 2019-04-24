using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySceneManager : Singleton<MySceneManager> {

    public float score;
    public float multiplier;
    public Text scoreText;
    public int coins;
    public float finalScore;

    public AudioSource coin;
    public AudioSource hit;
    public AudioSource pick1;
    public AudioSource pick2;
    public AudioSource pick3;

    private void Start()
    {
        coin = GameObject.Find("Coin").GetComponent<AudioSource>();
        hit = GameObject.Find("Hit").GetComponent<AudioSource>();
        pick1 = GameObject.Find("Pick1").GetComponent<AudioSource>();
        pick2 = GameObject.Find("Pick2").GetComponent<AudioSource>();
        pick3 = GameObject.Find("Pick3").GetComponent<AudioSource>();
    }
    private void Update()
    {
        coin = GameObject.Find("Coin").GetComponent<AudioSource>();
        hit = GameObject.Find("Hit").GetComponent<AudioSource>();
        pick1 = GameObject.Find("Pick1").GetComponent<AudioSource>();
        pick2 = GameObject.Find("Pick2").GetComponent<AudioSource>();
        pick3 = GameObject.Find("Pick3").GetComponent<AudioSource>();
    }
}
