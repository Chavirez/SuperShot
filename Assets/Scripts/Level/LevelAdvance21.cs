using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAdvance21 : MonoBehaviour
{

    [SerializeField] private Animator myDoor = null;
    [SerializeField] private GameObject Door = null;
    [SerializeField] private GameObject GoldenBlock = null;
    [SerializeField] private bool openTrigger2 = false;
    [SerializeField] private GameObject Diana = null;


    private void OnTriggerEnter2(Collider other)
    {

        if(other.CompareTag("Player"))
        {

            if (openTrigger2)
            {

                Diana.SetActive(false);
                if (GoldenBlock.activeInHierarchy)
                {
                    myDoor.Play("DoorRaising", 0, 0.0f);
                   
                }

                
                 if (!GoldenBlock.activeInHierarchy)
                {

                    GoldenBlock.SetActive(true);

                }
            }

        }

    }

    public void DoorEliminator2()
    {

        Door.SetActive(false);

    }

}
