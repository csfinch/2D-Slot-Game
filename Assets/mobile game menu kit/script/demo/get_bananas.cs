using UnityEngine;
using System.Collections;

public class get_bananas : MonoBehaviour {

	public int quantity = 1;

	void Start()
	{
	}

	void OnMouseDown ()
	{
		if (!game_uGUI.current_game_uGUI.in_pause)
			{
            game_uGUI.current_game_uGUI.my_progress_bar.Add_to_fill(quantity);
			}
	}
}
