using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopUp : MonoBehaviour
{   
    [SerializeField]
    private GameObject PopUp;
    
    [SerializeField]
    private GameObject target;

    [SerializeField]
    private GameObject character;
    
    private void Start()
    { 
        PopUp.SetActive(false);
        
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject == target)
        {
            PopUp.SetActive(true);
        }

        //This will make the textbox visible.
        if (Input.GetKeyDown(KeyCode.E))
        {
            character.GetComponent<TextManager>().textBox.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        //When the player leaves the trigger. The pop up will go away again.
        PopUp.SetActive(false);
    }
}
