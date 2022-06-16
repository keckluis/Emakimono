using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VisionRaycast : MonoBehaviour
{
    // Float a rigidbody object a set distance above a surface.

    public Transform startPoint;
    public LayerMask VisionLayer;
    Rigidbody2D rb2D;
    public GameObject detectionStatusIcon;
    int detectionCounter = 0;
    public TextMeshPro debugtext;
    GuardPatrol guardPatrol;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        guardPatrol = GetComponent<GuardPatrol>();
        //VisionLayer += LayerMask.GetMask("Player");
        //VisionLayer += LayerMask.GetMask("Obstruction");
    }

    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    void FixedUpdate()
    {
        // Cast a ray straight down.
        RaycastHit2D hit = Physics2D.Raycast(startPoint.position, transform.right*-1, 10, VisionLayer);       
        // If it hits something...
        if (hit.collider != null)   
        {


            if (!hit.collider.IsTouchingLayers(LayerMask.GetMask("Obstruction")))
            {

                if (hit.collider.gameObject.layer == 3)
                { 
                    
                    detectionCounter++;
                    guardPatrol.detected = true;
                    detectionStatusIcon.SetActive(true);

                }
                
            }
            if (hit.collider.gameObject.layer == 7)
                {
                if(detectionCounter >= 0)
                    detectionCounter--;
                detectionStatusIcon.SetActive(false);
                guardPatrol.detected = false;
            }
            

        }
        else
        {
            if (detectionCounter >= 0)
                detectionCounter--;
            detectionStatusIcon.SetActive(false);
            guardPatrol.detected = false;
        }

        if (detectionCounter > 200)
        {
            detectionCounter = 200;
            
           
        }
        debugtext.text = detectionCounter.ToString();
    }

    IEnumerator Wait(int waitTime, RaycastHit2D hit)
    {
        
        yield return new WaitForSeconds(waitTime);
        if (hit.collider.gameObject.layer == 3)
        {

        }


    }
}

