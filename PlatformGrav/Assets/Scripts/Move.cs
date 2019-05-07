using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    // Use this for initialization
    public bool stop;
    public static float SPEED;
    public float speed;

    public GameObject createThings;

	void Start () {
        if (SPEED < 20)
        {
            SPEED = 20f;
        }
        
        if(this.tag == "background")
        {
            SPEED = 15f;
        }

        speed = SPEED;
	}
	
	// Update is called once per frame
	void Update () {

        speed = SPEED;
        if(this.tag == "background")
        {
            transform.Translate(Vector3.right * SPEED * Time.deltaTime);
        } else
        {
            transform.Translate(Vector3.left * SPEED * Time.deltaTime);

        }
        if (gameObject.transform.tag == "floor")
        {
            if (transform.position.x < -610)
            {

            }
        }
        //if(transform.position.x<=-220f)
        //{
        //    transform.position = new Vector3(545f, transform.position.y, transform.position.z);
        //    createThings.gameObject.GetComponent<loopThings>().create = true;
        //}
  
    }
}
