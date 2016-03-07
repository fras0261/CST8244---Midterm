using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Goal : MonoBehaviour {
  public GameObject ball;

    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        _audioSource.Play();
        StartCoroutine("WaitForSound");
    }

    IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
