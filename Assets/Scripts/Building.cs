using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Building : MonoBehaviour 
{
	[SerializeField] Text score;

	[SerializeField] GameObject winText;
	[SerializeField] GameController gameController;

	[SerializeField] Transform doorManager;

	[SerializeField] float points;
	[SerializeField] float rotationValue;
	[SerializeField] float delay;

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("call"+ other.tag);
		if(other.tag == "Player")
		{
			doorManager.rotation = Quaternion.Euler(0,rotationValue,0);
			StartCoroutine(Points());
		}
	} 

	IEnumerator Points()
	{
		yield return new WaitForSeconds(0.5f);
		winText.SetActive(true);
		yield return new WaitForSeconds(delay);
		gameController.score += points;
		score.text = gameController.score.ToString()+ " Points";
		yield return new WaitForSeconds(delay);
		Application.LoadLevel(Application.loadedLevel);
	}
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		doorManager.rotation = Quaternion.Euler(0,0,0);
	}
}	
