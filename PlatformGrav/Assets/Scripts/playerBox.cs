using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerBox : MonoBehaviour
{
    //fixed update makes score incrment every second by 1
    void FixedUpdate()
    {
        MySceneManager.Instance.score += .05f;
    }
}


