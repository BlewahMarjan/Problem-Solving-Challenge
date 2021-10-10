using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objek;
    public float radius;
    private float posisix;
    private float posisiy;
    // Start is called before the first frame update
    void Start()
    {
        int ran = Random.Range(2, 10);
        for (int i = 0; i < ran; i++)
        {
            posisix = Random.Range(-8f, 8f);
            posisiy = Random.Range(-4f, 4f);
            transform.position = new Vector2(posisix, posisiy);
            Instantiate(objek, transform.position, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObject()
    {
        posisix = Random.Range(-8f, 8f);
        posisiy = Random.Range(-4f, 4f);
        transform.position = new Vector2(posisix, posisiy);
        Instantiate(objek, transform.position, Quaternion.identity);
    }
}

