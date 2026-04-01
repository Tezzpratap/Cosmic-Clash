using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] AudioClips;
    public static AudioManager instance;

    public void Awake(){
        //if(instance != null){
            instance = this;
        //}
    }
    
    public void PlaySFX(int ClipToPlay){
        AudioClips[ClipToPlay].Play();
    }
}
