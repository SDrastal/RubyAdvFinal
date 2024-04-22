using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        Projectile controller = other.GetComponent<Projectile>();

        if (controller != null)
        {
            Debug.Log("Raycast has hit the object ");
        }
    }

    // Start is called before the first frame update
    new Rigidbody2D rigidbody2D;
    Animator animator;
    Collider2D other;

    public RubyController RubyController;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        GameObject rubyControllerObject = GameObject.FindWithTag("Player");
        animator.Play("bushIdle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();
        // Check for a specific collider tag if necessary
        if (other.tag == "Player")
        {
            animator.SetTrigger("Hit");
        }
    }

    private void ResetToIdle()
    {
        animator.ResetTrigger("Hit");
        animator.Play("bushIdle");
    }

    // You can call this from an animation event at the end of the 'Hit' animation
    public void OnHitAnimationComplete()
    {
        ResetToIdle();
    }




   /* public float changeTime = 3.0f;
    float timer;
    

    public RubyController RubyController;

  

    void Update()
    {
        //remember ! inverse the test, so if broken is true !broken will be false and return won�t be executed.
        if (!broken)
        {
            return;
        }

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    void FixedUpdate()
    {
        //remember ! inverse the test, so if broken is true !broken will be false and return won�t be executed.
        if (!broken)
        {
            return;
        }

        Vector2 position = rigidbody2D.position;

       
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

    //Public because we want to call it from elsewhere like the projectile script
    public void Fix()
    {
        broken = false;
        rigidbody2D.simulated = false;
        smokeEffect.Stop();
        animator.SetTrigger("Fixed");
        RubyController.ChangeScore(1);
    }*/
}
