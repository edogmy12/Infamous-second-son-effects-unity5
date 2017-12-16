#pragma strict

var isgrounded : boolean = true;
				var rb : Rigidbody;
				var anim : Animator;


				 function Update()
				 {
						if(anim.GetBool ("Grounded") == false && Input.GetKey("space"))
						 {
							isgrounded = false;
							rb.drag = 7;
						 }
						else
						{
							isgrounded = true;
							rb.drag = 0;
						}
			 }
 
		