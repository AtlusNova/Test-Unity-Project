using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject triggerParticle;
    public GameObject collisionParticle;


    //gets executed when something enters this trigger, or when this object enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        if (triggerParticle != null)
        {

            //the triggerParticle will be spawnedat the location of this object
            //with the same rotation as the object
            Instantiate(triggerParticle, this.transform.position, this.transform.rotation);

        }
        
    }

    //gets executed when something collides with this object
    private void OnCollisionEnter(Collision collision)
    {


        if (collisionParticle != null) 
        {
            Instantiate(collisionParticle, collision.contacts[0].point, this.transform.rotation);

        }
    }
}
