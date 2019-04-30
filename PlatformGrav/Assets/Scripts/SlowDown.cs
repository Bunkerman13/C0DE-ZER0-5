using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : PowerUp {


    // Update is called once per frame
    public override void Update () {
        base.Update();


        if (isActive)
        {
            if (Move.SPEED != 8f)
            {
                GameObject.Find("Music").GetComponent<AudioSource>().pitch = 0.85f;
                Move.SPEED = 8f;
            }
            return;
        }

        if (duration < 0)
        {
            Move.SPEED = 20f;
            GameObject.Find("Music").GetComponent<AudioSource>().pitch = 1;
            isActive = !isActive;
            Destroy(this);
        }
      

    }

    // for working with button press and coins
    public void SetActive()
    {
        if (MySceneManager.Instance.coins >= 20)
        {
            MySceneManager.Instance.coins -= 20;
            MySceneManager.Instance.multiplier -= (.1f * 20.0f);
            duration = 5;
            isActive = !isActive;
        }
    }
}
