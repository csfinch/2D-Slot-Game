using UnityEngine;
using System.Collections;

public class get_score_points : MonoBehaviour {

	public int points;


	void Start()
	{
	}
	
	void OnMouseDown ()
	{
		if (!game_uGUI.current_game_uGUI.in_pause)
		{
            game_uGUI.current_game_uGUI.Update_int_score(points);
		}
	}
}
