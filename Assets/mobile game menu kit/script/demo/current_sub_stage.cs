using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class current_sub_stage : MonoBehaviour {

    public Text my_text;
    game_master my_game_master;


    // Use this for initialization
    void Start () {

        if (game_master.game_master_obj)
        {
            my_game_master = (game_master)game_master.game_master_obj.GetComponent("game_master");
            my_text.text = my_game_master.current_stage.ToString();

        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
