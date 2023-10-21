using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bubblePrefab;

    void Start()
    {
        InvokeRepeating("SpawnBubble", 2.0f, 3.0f);
    }

    private void SpawnBubble()
    {
        Instantiate(bubblePrefab, transform.position, Quaternion.identity);
    }
}
