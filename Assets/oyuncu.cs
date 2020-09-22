using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyuncu : MonoBehaviour
{
    string axisName = "Horizontal";
    public Rigidbody2D bomba;
    public Transform spawn;
    public float speed = 20;
    public float bombSpeed = 5;
    public Text scoreYazi;
    private int skor = 0;
    private int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (SaveLoadManager.yeni.Equals(false))
        {
            GameData gamedata = SaveLoadManager.Load("load");
            transform.position = new Vector2(transform.position.x, gamedata.getOyuncuY());
            skor = gamedata.getHighScore();
            scoreYazi.text = skor.ToString();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveAxis = Input.GetAxisRaw(axisName) * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveAxis, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bomb = Instantiate(bomba, spawn.position, Quaternion.identity);
            bomb.AddForce(new Vector2(0, 1) * bombSpeed);
            Destroy(bomb.gameObject, 2);
        }
    }

    public void Skor()
    {
        skor++;
        scoreYazi.text = skor.ToString();
        if (skor > highScore)
        {
            highScore = skor;
            if (skor % 5 == 0)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + 1);
            }
            SaveLoadManager.Save("load", new GameData(skor, transform.position.y));
        }
    }
}
