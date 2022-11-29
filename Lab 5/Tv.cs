using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tv : MonoBehaviour
{
    public WebCamTexture webcam = null;
    public Microphone micro = null;

    public bool recording = false;
    // Start is called before the first frame update

    void Start()
    {
        //show available microphones
        webcam = new WebCamTexture();
        webcam.Play();
        this.GetComponent<Renderer>().material.mainTexture = webcam;
        if(!webcam.isPlaying) webcam.Play();
         
        recording = true;

        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++) {
            Debug.Log(devices[i].name);
        }

        if(Microphone.devices.Length > 0) {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = Microphone.Start("", true, 10, 44100);
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown("space")) {
            if(recording) {
                webcam.Pause();
                recording = false;
                Debug.Log("Camera Paused!");
            }
            else {
                webcam.Play();
                recording = true;
                Debug.Log("Camera Recording!");
            }
        }
        
        if(Input.GetKeyDown("enter")) {
            webcam.Stop();
        }
        */
    }
}