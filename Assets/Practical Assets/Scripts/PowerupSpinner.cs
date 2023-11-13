using UnityEngine;
using System.Collections;

public class PowerupSpinner : MonoBehaviour 
{
	public float spinSpeed = 10.0f;

	void Start () 
	{
		
	}

	void Update () 
	{
		transform.Rotate (0.0f, spinSpeed * Time.deltaTime, 0.0f);
	}
}
