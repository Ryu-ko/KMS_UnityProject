using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayAudio : MonoBehaviour {

        public AudioSource audioSource;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        void OnTriggerEnter(Collider other)
        {
            audioSource.Play(); // Воспроизводим звук при входе в триггер
        }

        void OnTriggerExit(Collider other)
        {
            audioSource.Stop(); // Останавливаем звук при выходе из триггера
        }
    
}
