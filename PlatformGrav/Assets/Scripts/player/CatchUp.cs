using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchUp : MonoBehaviour
{
    float catchUpValue;

    // Start is called before the first frame update
    void Start()
    {
        catchUpValue = GameObject.Find("Player").GetComponent<Transform>().position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.transform.position.x < catchUpValue)
            //transform.Translate(Vector3.right * 1f * Time.deltaTime);
    }
}
