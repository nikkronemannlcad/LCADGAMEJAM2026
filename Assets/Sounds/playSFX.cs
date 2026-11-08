using UnityEngine;

public class playSFX : MonoBehaviour
{   
    /// so this is just to play one sfx but i had like 3 just duped the function and made diff sfx diff audio files
    [SerializeField] public AudioClip soundEffect1;
    //make sure ur sound is a wav you can literally drag and drop this into the project
    [SerializeField] public AudioSource sourceAudio1;
    //this is a component literlaly just click add component and look up audio source. 
    //then you have to drag the wav file from the project into one of the drop downs 

    public void PlaySound1()
    {   
        //play one shot will play the thing a single time
        sourceAudio1 = GetComponent<AudioSource>();
        sourceAudio1.PlayOneShot(soundEffect1);
    }

    //if you want a looped song too you can literally just use the same function then change the componenet to loop something
    //if u have any issues lmk and also pretty sure the profs can help a ton with this too
}