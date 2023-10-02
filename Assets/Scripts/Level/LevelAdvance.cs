using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAdvance : MonoBehaviour
{

    [SerializeField] private Animator myDoor = null;
    [SerializeField] private GameObject Door = null;
    [SerializeField] private GameObject Diana = null;
    [SerializeField] private bool openTrigger = false;



    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player"))
        {

            if (openTrigger)
            {
           
                myDoor.Play("DoorRaising", 0, 0.0f);
                Diana.SetActive(false);

            }

        }

    }

    public void DoorEliminator()
    {

        Door.SetActive(false);

    }

}
