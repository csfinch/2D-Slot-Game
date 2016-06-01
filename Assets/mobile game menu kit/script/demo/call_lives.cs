using UnityEngine;
using System.Collections;

public class call_lives : MonoBehaviour {

	public int live;


	void Start()
	{
	}
	
	void OnMouseDown ()
	{
		if (!game_uGUI.current_game_uGUI.in_pause)
		{
            game_uGUI.current_game_uGUI.Update_lives(live);
		}
	}
}
