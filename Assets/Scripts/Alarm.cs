using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Light))]
public class Alarm : MonoBehaviour {
  public GameObject ball;
    AudioSource audioSource;
    //private bool _isPlaying = false;
  // Use this for initialization
  void Start() {
        audioSource = GetComponent<AudioSource>();
  }

  void OnTriggerEnter(Collider obj)
  {
        audioSource.Play();
        ball.transform.localPosition = new Vector3(-3, 1, 3);
  }

  void OnTriggerExit(Collider obj)
  {
        StartCoroutine("WaitShortSoundDuration");
        
    }

  IEnumerator WaitShortSoundDuration()
  {
        yield return new WaitForSeconds(2);
        audioSource.Stop();
   }

}
