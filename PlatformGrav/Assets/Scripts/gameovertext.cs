using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameovertext : MonoBehaviour
{
    string final;
    // Start is called before the first frame update
    void Start()
    {
       final=GameObject.Find("MySceneManager (Singleton)").GetComponent<MySceneManager>().scoreText;
        gameObject.GetComponent < Text >().text= final;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
