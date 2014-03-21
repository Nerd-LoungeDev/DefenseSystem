using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public Block(BlockType type){
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public enum BlockType {
	Dirt,
	Stone,
	Cobblestone,
}
