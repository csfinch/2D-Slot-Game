using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player"))
		{
			if (!game_uGUI.current_game_uGUI.stage_end)
				{
				if (game_uGUI.current_game_uGUI.star_number >0)
                    game_uGUI.current_game_uGUI.Victory();
				else
                    game_uGUI.current_game_uGUI.Defeat();
				}
		}
	}
}
