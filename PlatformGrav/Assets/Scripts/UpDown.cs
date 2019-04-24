using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public float vertical = 1;
    public bool stop;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime*vertical);

        if(transform.position.y<=-3.2f)
        {
            vertical = 1;
        }
        else if (transform.position.y >= 3.2f)
        {
            vertical = -1;
        }
    }
}

