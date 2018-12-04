
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
    public Transform end;
    public Text scoreText;

	// Update is called once per frame
	void Update () {
   
       // float score = player.position.z - end.position.z;
        scoreText.text = (447-player.position.z).ToString("0  ");
		
	}
}
