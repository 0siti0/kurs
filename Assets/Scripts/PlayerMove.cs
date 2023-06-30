using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        if (PlayerPrefs.HasKey("playerx") && PlayerPrefs.HasKey("playery"))
        {
            this.transform.position = new Vector3(PlayerPrefs.GetFloat("playerx"), PlayerPrefs.GetFloat("playery"), 0);
        }

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("project");
        }
        Vector2 MoveVector;
        MoveVector.x = Input.GetAxis("Horizontal");
        MoveVector.y = Input.GetAxis("Vertical");

        rb.velocity = MoveVector * speed;
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("playerx", this.transform.position.x);
        PlayerPrefs.SetFloat("playery", this.transform.position.y);

    }
}