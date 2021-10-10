using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score7 : MonoBehaviour
{

    public float score = 0;
    public Text scoreUI;

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
            score += 1;
            scoreUI.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
