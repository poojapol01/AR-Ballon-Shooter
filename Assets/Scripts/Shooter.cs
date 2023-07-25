using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject arCamera;

    public void Shoot()
    {
        RaycastHit hit;

        Debug.Log("Hitman2");
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            Debug.Log("Hitman1");
            if (hit.transform.name == "Air_Balloon_1(Clone)" || hit.transform.name == "Air_Balloon_2(Clone)" || hit.transform.name == "Air_Balloon_3(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Debug.Log("Hitman");
            }
        }
    }

}
