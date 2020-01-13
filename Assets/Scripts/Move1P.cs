using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Move1P : MonoBehaviour {
	public float speed=5;
	protected Animator animator;
	//public Text gameovertext;
	float x;
	public class Player1{
		static public float HP;
		static public State Mystate;
		static public void Damage(float i_damage){
			HP=HP-i_damage;
		}
		static public float GetHP(){
			return HP;
		}
	}
	public enum State{
		None,Jump,Slide
	}
	private UIscript uiscript;


	 void Start () {
		animator = GetComponent <Animator> ();
		Player1.HP = 1000;
		Player1.Mystate = State.None;
	
	}

/*	public void Damage (byte i_damage){
		Player1.HP -= i_damage;
	}*/
	void Update () {
		//Canvas.FindObjectOfType<
      
		if (Player1.HP <= 0) {
			animator.SetBool("DEAD",true);
		}
        if (Player1.HP > 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("JUMP", true);
                Player1.Mystate = State.Jump;
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetBool("JUMP", false);
                Player1.Mystate = State.None;
            }
            if (Input.GetKey(KeyCode.S))
            {
                animator.SetBool("SLIDE", true);
                Player1.Mystate = State.Slide;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                animator.SetBool("SLIDE", false);
                Player1.Mystate = State.None;
            }
            // 3 move
            x = gameObject.transform.position.x;
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(0, 0, 0.05f);
                animator.SetBool("NEWSTATE", true);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                animator.SetBool("NEWSTATE", false);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(0, 0, 0.05f);
                animator.SetBool("NEWSTATE", true);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                animator.SetBool("NEWSTATE", false);
            }
        }
	}
	void OnTriggerStay(Collider colider)
        {
			if(Player1.Mystate==State.Slide){
				Move2P.Player2.Damage(10);
			}
		}
	

	



}