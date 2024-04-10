using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyLittleBird : MonoBehaviour
{
    [SerializeField] private float velocity = 5f;
    [SerializeField] private float rotationSpeed = 8f;
    [SerializeField] private AudioSource audioJump;
    [SerializeField] private AudioSource backgroundAudio;
    [SerializeField] private AudioSource gameOverAudio;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameOverAudio.Stop();
    }

    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame || Input.GetKeyDown(KeyCode.Space))
        {
            //jump
            rb.velocity = Vector2.up * velocity;
            audioJump.Play();
            
        }
        transform.rotation = Quaternion.Euler(0,0,rb.velocity.y*rotationSpeed);
    }
    void OnCollisionEnter2D(Collision2D other){
        audioJump.Stop();
        backgroundAudio.Stop();
        GameManager.instance.GameOver();
        gameOverAudio.Play();
    }
}
