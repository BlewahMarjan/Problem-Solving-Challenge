using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score8 : MonoBehaviour
{

    public float score = 0;
    public Text scoreUI;
    public Spawn SpawnObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("kotak"))
        {
            StartCoroutine(SpawnObject.SpawnObject());
            score += 1;
            scoreUI.text = "Score: " + score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
