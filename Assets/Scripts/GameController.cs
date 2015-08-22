using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	// detinations
	[SerializeField] Transform building1;
	[SerializeField] Transform building2;

	Vector3 destinationPosition;

	// agent
	[SerializeField] NavMeshAgent agent = new NavMeshAgent();
	[SerializeField] Transform agentTransform;

	[SerializeField] float movingDistance;
	public float score;

	[SerializeField] GameObject p1button;
	[SerializeField] GameObject p2button;

	public void P1()
	{
		DeactivateButtons(false);
		destinationPosition = new Vector3(building1.position.x,building1.position.y,building1.position.z + movingDistance);
		agent.SetDestination(destinationPosition);
	}

	public void P2() 
	{
		DeactivateButtons(false);
		destinationPosition = new Vector3(building2.position.x,building2.position.y,building2.position.z + movingDistance);
		agent.SetDestination(destinationPosition);
	} 

	void DeactivateButtons(bool boolValue)
	{
		p1button.SetActive(boolValue);
		p2button.SetActive(boolValue);
	}

	public void Restart()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
