using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator animator;
    private Rigidbody playerRb;
    private AudioSource playerAudio;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool onGround = true;
    public bool gameOver = false;
    public ParticleSystem dustParticles;
    public ParticleSystem pebbleParticles;
    public AudioClip jumpSound;
    public AudioClip CrashSound;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
            //animator.SetTrigger("Jump_trig");
            pebbleParticles.Stop();
            playerAudio.PlayOneShot(jumpSound, 1);
        }



        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
            pebbleParticles.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            animator.SetBool("Death_b", true);
            animator.SetInteger("DeathType_int", 1);
            dustParticles.Play();
            pebbleParticles.Stop();
            playerAudio.PlayOneShot(CrashSound, 1);
        }
    }
}
