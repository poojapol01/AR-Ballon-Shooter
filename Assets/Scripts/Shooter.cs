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
            if (hit.transform.name == "Air_Balloon_1(Clone)" || hit.transform.name == "Air_Balloon_2(Clone)" || hit.transform.name == "Air_Balloon_3(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Debug.Log("Hitman");
            }
        }
    }

}
