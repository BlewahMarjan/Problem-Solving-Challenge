using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl4 : MonoBehaviour
{

    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    // Besarnya gaya awal yang diberikan untuk mendorong bola
    public float xInitialForce;
    public float yInitialForce;

    public float speed = 10.0f;

    void ResetBall()
    {
        // Reset posisi menjadi (0,0)
        transform.position = Vector2.zero;

        // Reset kecepatan menjadi (0,0)
        rigidBody2D.velocity = Vector2.zero;
    }

    void PushBall()
    {
        // Tentukan nilai komponen y dari gaya dorong antara -yInitialForce dan yInitialForce
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
        float randomDirection = Random.Range(0, 2);

        // Jika nilainya di bawah 1, bola bergerak ke kiri. 
        // Jika tidak, bola bergerak ke kanan.
        if (randomDirection < 1.0f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            rigidBody2D.AddForce(new Vector2(-xInitialForce, yInitialForce));
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(xInitialForce, yInitialForce));
        }
    }

    void RestartGame()
    {
        // Kembalikan bola ke posisi semula
        ResetBall();

        // Setelah 2 detik, berikan gaya ke bola
        Invoke("PushBall", 2);
    }

    // Titik asal lintasan bola saat ini
    private Vector2 trajectoryOrigin;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
 
        // Mulai game
        RestartGame();

        trajectoryOrigin = transform.position;

    }

    // Ketika bola beranjak dari sebuah tumbukan, rekam titik tumbukan tersebut
    //private void OnCollisionExit2D(Collision2D collision)
    //{
       // trajectoryOrigin = transform.position;
    //}

    // Untuk mengakses informasi titik asal lintasan
    //public Vector2 TrajectoryOrigin
    //{
       // get { return trajectoryOrigin; }
    //}

    //Update is called once per frame
    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity.y = speed;
        }

        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity.y = -speed;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -speed;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = speed;
        }
        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.y = 0.0f;
        }

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;
    }

  

}
