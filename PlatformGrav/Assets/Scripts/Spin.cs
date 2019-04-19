using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public bool stop;
    public static float SPEED;
    public float speed;
    public float rotateSpeed=1.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (SPEED < 20)
        {
            SPEED = 20f;
        }

        speed = SPEED;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * (rotateSpeed * Time.deltaTime));
        speed = SPEED;
        transform.Translate(Vector3.left * SPEED * Time.deltaTime);
    }
}
