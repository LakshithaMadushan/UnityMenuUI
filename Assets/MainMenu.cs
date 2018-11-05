using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public float factorValue = 3.0f;
	public AudioSource mainAudioSource;

    public void playGame() {

		StartCoroutine (this.fade());

    }

	public void quitGame() {
		Debug.Log ("Quit!");
		Application.Quit ();
	}
		
	public IEnumerator fade(){
		while(this.mainAudioSource.volume > 0.0f){
			this.mainAudioSource.volume -= Time.deltaTime * this.factorValue;
			yield return new WaitForSeconds (0.1f);
		}

		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
