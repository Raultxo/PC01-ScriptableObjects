using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "SpawnPrefab", order = 1)]
public class SpawnPrefab : ScriptableObject
{
    [SerializeField] private int cantidad;
    [SerializeField] private GameObject prefab;
}
