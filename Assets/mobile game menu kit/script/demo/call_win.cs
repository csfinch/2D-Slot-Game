using UnityEngine;
using System.Collections;

public class call_win : MonoBehaviour {

	public int star_score;

	void Start()
	{
	}

	void OnMouseDown ()
	{
        Win();

    }

    public void Win()
    {
        if (!game_uGUI.current_game_uGUI.in_pause)
        {
            game_uGUI.current_game_uGUI.star_number = star_score;
            game_uGUI.current_game_uGUI.Victory();
        }
    }
}
