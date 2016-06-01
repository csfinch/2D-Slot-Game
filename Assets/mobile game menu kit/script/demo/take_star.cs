using UnityEngine;
using System.Collections;

public class take_star : MonoBehaviour {


	// Use this for initialization
	void Start () {
		this.gameObject.SetActive(true);
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player"))//if the player collide with this star
			{
			if (game_uGUI.current_game_uGUI.star_number <3)
				{
                game_uGUI.current_game_uGUI.Add_stars(1);
				}
			
			this.gameObject.SetActive(false);
			}
	}
}
