using UnityEngine;
using System.Collections;

public class LinkInfinite : MonoBehaviour {
	
	public float maxSpeed = 5f;
	bool facingRight = true; 
	
	bool grounded = false;
	public Transform groundcheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 500f;
	bool doubleJump = false;
	
	Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle (groundcheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		anim.SetFloat ("vSpeed", rigidbody2D.velocity.y); 
		
		if (grounded) {
			doubleJump = false;
		}
		
		// float move = Input.GetAxis ("Horizontal");
		float move = 1f;
		anim.SetFloat ("Speed", Mathf.Abs (move));
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
		
		if (move > 0 && !facingRight) {
			flip ();
		}
		if (move < 0 && facingRight) {
			flip ();
		}
	}
	
	void Update () {
		if ((grounded||!doubleJump) && Input.GetKeyDown(KeyCode.UpArrow)) {
			anim.SetBool("Ground",false);
			rigidbody2D.AddForce(new Vector2 (0, jumpForce));
			if (!doubleJump && !grounded) {
				doubleJump = true;
			}
		}
	}
	
	void flip () {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}