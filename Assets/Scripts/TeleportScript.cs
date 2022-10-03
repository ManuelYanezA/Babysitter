using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : InteractableObject
{

    public GameObject player;
    public GameObject portal;

    protected override void OnInteract()
    {
        if(!interacted)
        {
            interacted = true;
            Invoke("ReenableInteraction", 0.5f);

            Invoke("Teleport", 0.2f);

            //Debug.Log("Interacted with " + name);
        }
    }

    private void Teleport()
    {
        player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
    }

}
