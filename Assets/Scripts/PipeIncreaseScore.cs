using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    private SoundManager sound;

    private void Start()
    {
        sound = GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundManager>();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sound.PlayScoreSFX();
            Score.instance.UpdateScore();
        }
    }
}
