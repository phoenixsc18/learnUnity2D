using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour 
{
  private Animator animator;
  private const float CHAR_MOVE_SPEED = .05f;

  // Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
	{
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
      animator.enabled = true;
			animator.SetInteger("Direction", 2);  // up
      transform.position = new Vector3(transform.position.x, transform.position.y + CHAR_MOVE_SPEED, transform.position.z);
		}
    else if(Input.GetKey(KeyCode.DownArrow))
		{
      animator.enabled = true;
			animator.SetInteger("Direction", 0);  // down
      transform.position = new Vector3(transform.position.x, transform.position.y - CHAR_MOVE_SPEED, transform.position.z);
		}
    else if(Input.GetKey(KeyCode.LeftArrow))
		{
      animator.enabled = true;
			animator.SetInteger("Direction", 1);  // left
      transform.position = new Vector3(transform.position.x - CHAR_MOVE_SPEED, transform.position.y, transform.position.z);
		}
    else if(Input.GetKey(KeyCode.RightArrow))
		{
      animator.enabled = true;
			animator.SetInteger("Direction", 3); // right
      transform.position = new Vector3(transform.position.x + CHAR_MOVE_SPEED, transform.position.y, transform.position.z);
		}
    else
    {
      // not moving
      animator.enabled = false;
    }
	}
}

