using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Move2P : MonoBehaviour {
	public float speed=5;
	protected Animator animator;
	//public Text gameovertext;
	float x;
	public enum State{
		None,Jump,Slide
	}
	public struct Player2{
		static public float HP;
		static public void Damage(float i_damage){
			HP=HP-i_damage;
		}
		static public State Mystate;
		static public float GetHP(){
			return HP;
		}
	}

	private UIscript uiscript;
	
	
	void Start () {
		animator = GetComponent <Animator> ();
		Player2.HP = 1000;
		Player2.Mystate = State.None;

	}
/*	public void Damage (byte i_damage){
		Player2.HP -=i_damage;
	}*/

	
	void Update () {
	//	Canvas.FindObjectOfType<
		if (Player2.HP <= 0) {
			animator.SetBool("DEAD",true);
		}
		x = gameObject.transform.position.x;
        if (Player2.HP > 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= new Vector3(0, 0, 0.05f);
                animator.SetBool("NEWSTATE", true);
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                animator.SetBool("NEWSTATE", false);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(0, 0, 0.05f);
                animator.SetBool("NEWSTATE", true);
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                animator.SetBool("NEWSTATE", false);
            }
            // 4 
            if (Input.GetKey(KeyCode.UpArrow))
            {
                animator.SetBool("JUMP", true);
                Player2.Mystate = State.Jump;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                animator.SetBool("JUMP", false);
                Player2.Mystate = State.None;
            }


            if (Input.GetKey(KeyCode.DownArrow))
            {
                animator.SetBool("SLIDE", true);
                Player2.Mystate = State.Slide;
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                animator.SetBool("SLIDE", false);
                Player2.Mystate = State.None;
            }
        }
		
		
		
	}
	
	
	
	//7  syougaibutsu
	
	void OnTriggerStay(Collider colider)
	{

			if(Player2.Mystate==State.Slide){
				Move1P.Player1.Damage(10);
			}
		}
		
}







