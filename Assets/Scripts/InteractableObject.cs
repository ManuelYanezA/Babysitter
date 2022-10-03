using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : CollidableObject
{

    protected bool interacted = false;

    protected override void OnCollided(GameObject gameObject)
    {
        //Debug.Log("Collided with "+ gameObject.name);
        if(Input.GetKey(KeyCode.Z))
        {
            OnInteract();
        }
    }

    protected virtual void OnInteract()
    {
        if(!interacted)
        {
            interacted = true;
            Invoke("ReenableInteraction", 0.5f);
            //Inserte función de interacción con objeto
            Debug.Log("Interacted with " + name);
        }
    }

    private void ReenableInteraction()
    {
        interacted = false;
    }
}
