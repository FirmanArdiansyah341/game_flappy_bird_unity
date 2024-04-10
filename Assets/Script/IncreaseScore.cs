using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    [SerializeField] private AudioSource getPointAudio;
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player"))
        {
            Score.instance.UpdateScore();
            getPointAudio.Play();
        }
    }
}
