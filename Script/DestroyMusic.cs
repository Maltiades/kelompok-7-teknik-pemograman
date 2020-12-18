using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameMusicPlayer.Instance.gameObject.GetComponent<AudioSource>().Pause();
        return;
    }

}
