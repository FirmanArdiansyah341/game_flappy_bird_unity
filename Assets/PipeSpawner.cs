using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 3f;
    [SerializeField] private float heightRange = 17;
    [SerializeField] private GameObject _pipe;
    private float timer;
    void Start()
    {
        SpawnerPipe();
    }
    void Update()
    {
        if(timer > maxTime)
        {
            SpawnerPipe();
            timer = 0;
            
        }
        timer += Time.deltaTime;
    }
    private void SpawnerPipe(){
        Vector3 spawnPos = transform.position + new Vector3(0,Random.Range(-heightRange, heightRange),0);
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);
        Destroy(pipe,10f);
    }
}
