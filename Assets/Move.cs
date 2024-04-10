using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   [SerializeField] private float speed = 3f;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
