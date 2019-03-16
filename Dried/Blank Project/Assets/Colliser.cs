using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliser : MonoBehaviour
{
    public Material material;
    Renderer rend;
    public AudioSource _mAudio;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        rend.sharedMaterial = material;
        _mAudio.Play();
    }
    void OnCollisionExit()
    {
        rend.sharedMaterial = default;
    }
}
