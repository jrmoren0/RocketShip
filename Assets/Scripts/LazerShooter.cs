using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject lazerPrefab;

    [SerializeField] private GameObject spawnPoint;

    [SerializeField] private float lazerSpeed;

    private GameObject tempLazer;

    private Rigidbody tempLazerRigidBody;

    [SerializeField] private AudioSource audioPlayer;

    [SerializeField] private AudioClip pewPew;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           tempLazer = Instantiate(lazerPrefab,spawnPoint.transform.position,spawnPoint.transform.rotation);
           tempLazerRigidBody =  tempLazer.GetComponent<Rigidbody>();
           tempLazerRigidBody.velocity = gameObject.GetComponent<Rigidbody>().velocity;
           tempLazerRigidBody.AddForce(transform.forward * lazerSpeed);

            audioPlayer.PlayOneShot(pewPew);

            Destroy(tempLazer,5f);

        }
    }
}
