using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_script : MonoBehaviour

{

    public AudioSource DropSound;



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CollisionTag")
        {
            DropSound.Play();
            Debug.Log("Collided");
        }
    }
}
