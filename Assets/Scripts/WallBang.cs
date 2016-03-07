using UnityEngine;
using System.Collections;

public class WallBang : MonoBehaviour {

    AudioSource audioSource;

	void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    void OnCollisionEnter(Collision obj)
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}
