using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject arCamera;

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.up, out hit))
        {
            if (hit.transform.name == "Balloon_Ghost_Pink(Clone)" || hit.transform.name == "Balloon_Ghost_Red(Clone)" || hit.transform.name == "Balloon_Ghost_Yellow(Clone)")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }

}
