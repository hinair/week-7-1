using UnityEngine;
using System.Collections;

public class CrosshairPosition : MonoBehaviour 
{
	void Start () 
	{
	
	}

	void LateUpdate () 
	{
		Ray ray = Camera.main.ViewportPointToRay (new Vector3(0.5f, 0.5f, 0.0f));
		Vector3 position = ray.GetPoint (1.0f);
		transform.position = position;
	}
}
