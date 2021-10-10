using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    

    public GameObject objek1;
    public Transform bola;
    //public float radius;
    private float posisix;
    private float posisiy;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hasil "+objek1);
       
        int run = Random.Range(4, 10);
        for (int i = 0; i < run; i++)
        {
            posisix = Random.Range(-8f, 8f);
            posisiy = Random.Range(-4f, 4f);
            transform.position = new Vector2(posisix, posisiy);
            Instantiate(objek1, transform.position, Quaternion.identity);
            
        }
        //InvokeRepeating("SpawnObject", 2.0f, 3.0f);


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("as y" + GameObject.FindGameObjectWithTag("bola").transform.position.y);
        //Debug.Log("as x" + GameObject.FindGameObjectWithTag("bola").transform.position.x);

    }

 

    public IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("halo");
        posisix = Random.Range(-13f, 13f);
        //Debug.Log(posisix);
        posisiy = Random.Range(-8f, 8f);
        // Debug.Log(posisiy);
        //Debug.Log(GameObject.FindGameObjectWithTag("bola").transform.position.x);
        //Debug.Log(GameObject.FindGameObjectWithTag("bola").transform.position.y);
        //if ((posisix <= GameObject.FindGameObjectWithTag("bola").transform.position.x) || (posisiy <= GameObject.FindGameObjectWithTag("bola").transform.position.y)) 
        //{
        //posisix = Random.Range(-8f - 4 - GameObject.FindGameObjectWithTag("bola").transform.position.x, 8f + 4 + GameObject.FindGameObjectWithTag("bola").transform.position.x);
        //posisiy = Random.Range(-4f - 4 - GameObject.FindGameObjectWithTag("bola").transform.position.y, 4f + 4 + GameObject.FindGameObjectWithTag("bola").transform.position.y);
        //transform.position = new Vector2(posisix, posisiy);
        //Instantiate(objek1, transform.position, Quaternion.identity);
        //Debug.Log("if pertama");



        //}
        transform.position = new Vector2(posisix, posisiy);
        if (Vector2.Distance(bola.transform.position, objek1.transform.position) < 2)
        {
            Debug.Log("halo2");
            Instantiate(objek1, transform.position, Quaternion.identity);

        }
        else { Instantiate(objek1, transform.position, Quaternion.identity); }
        
    }
    
}

