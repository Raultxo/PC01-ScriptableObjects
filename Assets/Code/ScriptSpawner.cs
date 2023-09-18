using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpawner : MonoBehaviour
{
    [SerializeField] private SpawnPrefab spawnPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPrefab.cantidad; i++)
        {
            Instantiate(spawnPrefab.prefab, new Vector3(0 + i , 0 + i, 0), Quaternion.identity);
        }
    }
}
