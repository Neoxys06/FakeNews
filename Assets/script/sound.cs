using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]AudioClip [] playlist;
    [SerializeField] AudioSource audioSource;
    int musicIndex=0;
    void Start()
    {
        audioSource.clip=playlist[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying){
            PlayNextSong();
        }
    }
    void PlayNextSong(){
        musicIndex=(musicIndex+1)%playlist.Length;
        audioSource.clip=playlist[musicIndex];
        audioSource.Play();
    }
}
