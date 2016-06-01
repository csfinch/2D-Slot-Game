using UnityEngine;
using System.Collections;

public class take_money : MonoBehaviour {


	int my_value = 1;

	// Use this for initialization
	void Start () {
		this.gameObject.SetActive(true);
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player"))//if the player collide with this star
			{
            game_uGUI.current_game_uGUI.Update_virtual_money(my_value);
			
			this.gameObject.SetActive(false);
			}
	}
}
