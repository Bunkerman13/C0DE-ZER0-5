using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public GameObject spike;
    public GameObject coin;
    public GameObject ground;
    public GameObject groundRotate;
    public GameObject groundLong;
    public GameObject slow;
    public GameObject mag;
    public GameObject rain;

    public List<GameObject> objects;


    float width;
    float height;
    float centerX;

    // Use this for initialization
    void Start () {

        Vector2 looping = GetComponent<RectTransform>().position;
        //gameObject.transform.position = new Vector2(looping.x, transform.position.y);
        width = 200f;
        height = 3.2f;

        centerX = GetComponent<RectTransform>().position.x;
        objects = new List<GameObject>();

        for (int x = 0; x < 30; x++)
        {
            objects.Add(SpawningObjects());
        }
	}
	
	// Update is called once per frame
	void Update () {
		for(int x = 0; x < 30; x++)
        {
            if (objects[x] == null)
            {
                GameObject temp = SpawningObjects();
                //Debug.Log("Missing: " + x);
                if (temp.tag != "Coin")
                {
                    objects[x] = temp;
                }
            }
        }
	}

    GameObject SpawningObjects()
    {
        int num = Random.Range(0, 1000);

        GameObject temp = null;


        
       // temp = Instantiate(rain, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);


        //Spikes
        if (num > 900 && num < 985)
            temp = Instantiate(spike, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height/2, height/2), 0), Quaternion.identity);
        //Coins
        else if (num >= 0 && num < 800)
            temp = Instantiate(coin, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        //Platform
        else if (num > 800 && num < 850)
            temp = Instantiate(ground, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        //Platform spinning
        else if (num > 850 && num < 875)
            temp = Instantiate(groundRotate, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        //Platform long
        else if (num > 875 && num < 900)
            temp = Instantiate(groundLong, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        //rain
        else if (num > 985 && num < 990)
            temp = Instantiate(rain, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        //slow
        else if (num > 990 && num < 995)
            temp = Instantiate(slow, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);
        //magnet
        else if (num == 995||num==1000)
            temp = Instantiate(mag, new Vector3(centerX + Random.Range(0, width), 0 + Random.Range(-height, height), 0), Quaternion.identity);

        return temp;
        
    }
}
