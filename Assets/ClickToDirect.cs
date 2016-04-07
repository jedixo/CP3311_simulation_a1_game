using UnityEngine;
using System.Collections;

public class ClickToDirect : MonoBehaviour
{
	public NavMeshAgent[] controlledAgents;
	
	void Update()
	{
		//Check if the fire button is being held down
		if (Input.GetButton("Fire1"))
		{
			//Perform a raycast to determine where the user clicked
	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit;
	        if (Physics.Raycast(ray, out hit, 100))
			{
				//Direct each of our agents to the new target
				Vector3 targetPos = hit.point;
				foreach (NavMeshAgent agent in controlledAgents) {
					agent.destination = targetPos;
				}
	        }
		}
	}
}
