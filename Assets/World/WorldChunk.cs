using UnityEngine;
using System.Collections;

public class WorldChunk : MonoBehaviour {

	public GameObject holder;

	private static int chunkSize = 32;
	Block[][][] block;


	WorldChunk(int seed){
		block = new Block[chunkSize][][];
		for (int x = 0; x < chunkSize; x++) {
			block[x] = new Block[chunkSize][];
			for (int y = 0; y < chunkSize; y++) {
				block[x][y] = new Block[chunkSize];
				for (int z = 0; z < chunkSize; z++) {
					block[x][y][z] = new Block(BlockType.Dirt);
				}
			}
		}
	}

	// Use this for initialization
	void Start () {
		for (int x = 0; x < chunkSize; x++) {
			for (int y = 0; y < chunkSize; y++) {
				for (int z = 0; z < chunkSize; z++) {
					// Is block showing
					if(isBlockShowing(x,y,z))
						Instantiate(holder,new Vector3(x,y,z), Quaternion.identity);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	bool isBlockShowing(int x, int y, int z){
		// Outside Blocks
		//Debug.Log ("Length: " + block.GetLength(0));
		if (x + 1 == chunkSize || x == 0)
			return true;
		if (y + 1 == chunkSize || y == 0)
			return true;
		if (z + 1 == chunkSize || z == 0)
			return true;
		return false;
	}
}
