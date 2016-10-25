using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


    public float speed = 8f;
    public float maxVelocity = 4f;

    private Rigidbody2D myBody;
    private Animator anim;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () { // only called every few frames, good for phyics
        PlayerMoveKeyboard();
	}

    void PlayerMoveKeyboard()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        float h = Input.GetAxisRaw("Horizontal"); //left right and a,d buttons

        if(h> 0)
        {
            if (vel < maxVelocity)
            {
                forceX = speed; // going right
            }
            Vector3 temp = transform.localScale;
            temp.x = 1.3f;
            transform.localScale = temp;
            anim.SetBool("Walk", true);
        }else if (h < 0)
        {
            if (vel < maxVelocity)
            {
                forceX = -speed; // going left
            }
            Vector3 temp = transform.localScale;
            temp.x = -1.3f;
            transform.localScale = temp;
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        myBody.AddForce(new Vector2(forceX, 0));
    }
}
