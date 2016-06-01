using UnityEngine;
using System.Collections;

public class check_if_call_win_or_lose : MonoBehaviour {


	void Start()
	{
	}

	void OnMouseDown ()
	{
		if (!game_uGUI.current_game_uGUI.in_pause)
			{
			if (game_uGUI.current_game_uGUI.star_number > 0)
                game_uGUI.current_game_uGUI.Victory();
			else
                game_uGUI.current_game_uGUI.Defeat();
			}
	}
}
