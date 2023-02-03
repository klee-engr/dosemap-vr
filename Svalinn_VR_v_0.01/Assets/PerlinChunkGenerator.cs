using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinChunkGenerator : MonoBehaviour
{
    public int seed;
    private Chunk chunk;

    // Start is called before the first frame update
    void Start()
    {
        chunk = GetComponent<Chunk>();
        Generate(chunk, seed);
    }

    private void Generate(Chunk chunk, int seed)
    {
        Random.InitState(seed);
        for(var x = 0; x < chunk.width; ++x)
        {
            for (var y = 0; x < chunk.width; ++y)
            {
                for (var z = 0; x < chunk.width; ++z)
                {
                    chunk.SetBlock(x, y, z, Color.red);
                }
            }
        }
    }
}
