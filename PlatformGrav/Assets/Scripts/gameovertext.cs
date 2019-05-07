using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameovertext : MonoBehaviour
{
    public int identifier;
    // Start is called before the first frame update
    void Start()
    {
        //final=GameObject.Find("MySceneManager (Singleton)").GetComponent<MySceneManager>().scoreText;
        if(identifier == 1)
            gameObject.GetComponent < Text >().text= "Final Score: " + MySceneManager.Instance.finalScore;
        else if(identifier == 2)
            gameObject.GetComponent<Text>().text = "Final Coins: " + MySceneManager.Instance.finalCoins;
        else if(identifier == 3)
            gameObject.GetComponent<Text>().text = "Final Multiplier: " + MySceneManager.Instance.finalMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(MySceneManager.Instance.finalCoins);
    }
}
