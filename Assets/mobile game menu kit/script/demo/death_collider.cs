using UnityEngine;
using System.Collections;

public class death_collider : MonoBehaviour {


	public demo_controller my_demo_controller;
	bool trigger_on;

	// Use this for initialization
	void Start () {
		trigger_on = true;
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player") && trigger_on)
		{
			trigger_on = false;
			if (!game_uGUI.current_game_uGUI.stage_end && !game_uGUI.current_game_uGUI.in_pause)
			{
				if (game_uGUI.current_game_uGUI.show_debug_messages)
					Debug.Log("death");

                game_uGUI.current_game_uGUI.Update_lives(-1);
				Invoke("Reset_trigger",0.1f);

                game_uGUI.current_game_uGUI.in_pause = true;
				my_demo_controller.Restart();
                game_uGUI.current_game_uGUI.in_pause = false;

			}
		}
	}

	void Reset_trigger()
	{
		trigger_on = true;
	}
}
