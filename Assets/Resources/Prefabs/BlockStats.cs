using UnityEngine;
using System.Collections;

public class BlockStats : MonoBehaviour 
{

	public static int blockDestroyedForce = 400;
	public bool isPlaced = true;
	public bool isPlaceable = true;
	public int currentBlockStrength = 100;
	public int blockStrength = 100;


	// Update is called once per frame
	void Update () 
	{

		// Recover block's strength
		if (currentBlockStrength < blockStrength) 
		{
			currentBlockStrength++;
		}

		if (currentBlockStrength <= 0 && isPlaced) 
		{
			transform.localScale -= new Vector3(.5F,.5F,.5f);
			isPlaced = false;
			gameObject.AddComponent<Rigidbody>();
			rigidbody.AddForce(new Vector3(Random.Range(-blockDestroyedForce,blockDestroyedForce),Random.Range(-blockDestroyedForce,blockDestroyedForce),Random.Range(-blockDestroyedForce,blockDestroyedForce)));
			rigidbody.mass = .01f;
		}
	}
}
