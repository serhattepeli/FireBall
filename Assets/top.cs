using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour
{
    Rigidbody2D rb2;
    public oyuncu oyuncu;
    public float tophizi;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        if (collision.tag.Equals("bomba"))
        {
            oyuncu.Skor();
            Destroy(collision.gameObject);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Invoke("baslat", 2);
        
    }

    void baslat()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * tophizi;
    }

    // Update is called once per frame
    void Update()
    {
        if (oyuncu.transform.position.y > 3)
            oyuncu.transform.position = new Vector2(oyuncu.transform.position.x, -4);
    }

    

}
