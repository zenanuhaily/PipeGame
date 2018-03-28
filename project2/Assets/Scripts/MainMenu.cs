using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour {

	public Player player;

	public Text scoreLabel;

    public Text HowToPlay;

	private void Awake () {
		Application.targetFrameRate = 1000;
	}

	public void StartGame (int mode) {
		player.StartGame(mode);
		gameObject.SetActive(false);
		Cursor.visible = false;
        
    }

	public void EndGame (float distanceTraveled) {
		scoreLabel.text = ((int)(distanceTraveled * 10f)).ToString();
		gameObject.SetActive(true);
		Cursor.visible = true;
        
	}

    public void Exit()
    {
        Application.Quit();
    }
}