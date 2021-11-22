using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;

    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ShowScore.score > ShowScore.bestScore)
            ShowScore.bestScore = ShowScore.score;
        SceneManager.LoadScene("GameOverScene");
    }
}
