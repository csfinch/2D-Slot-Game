using UnityEngine;
using System.Collections;

public class call_lose : MonoBehaviour {


	void Start()
	{

	}

	void OnMouseDown ()
	{
		if (!game_uGUI.current_game_uGUI.in_pause)
			{
            game_uGUI.current_game_uGUI.Defeat();
			}
	}
}
