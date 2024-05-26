using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private GameObject pipe;

    private float timer;

    private void Awake()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawn = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));  
        GameObject _pipe = Instantiate(pipe, spawn, Quaternion.identity);

        Destroy(_pipe, 10f);
    }
}
