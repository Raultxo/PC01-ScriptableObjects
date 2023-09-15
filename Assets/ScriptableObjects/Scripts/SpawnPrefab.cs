using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "SpawnPrefab")]
public class SpawnPrefab : ScriptableObject
{
    public int cantidad;
    public GameObject prefab;
}
