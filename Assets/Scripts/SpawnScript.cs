using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;
    private float destroyObjectTime = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(3);
        for (int i = 0; i < balloons.Length; i++) 
        {
            Instantiate(balloons[i], spawnPoints[i].position, spawnPoints[i].rotation);
        }
        StartCoroutine(StartSpawning());

        Invoke("DestroyObject", destroyObjectTime);
    }

    private void DestroyObject()
    {
        if (GameObject.Find("Air_Balloon_1(Clone)") != null)
        {
            //it exists
            Destroy(GameObject.Find("Air_Balloon_1(Clone)"));
            Debug.Log("Destroyed First Ballon");
        }
        if (GameObject.Find("Air_Balloon_2(Clone)") != null)
        {
            //it exists
            Destroy(GameObject.Find("Air_Balloon_2(Clone)"));
            Debug.Log("Destroyed Second Ballon");
        }
        if (GameObject.Find("Air_Balloon_3(Clone)") != null)
        {
            //it exists
            Destroy(GameObject.Find("Air_Balloon_3(Clone)"));
            Debug.Log("Destroyed Third Ballon");
        }
        if (GameObject.Find("msVFX_Stylized Smoke 5(Clone)") != null)
        {
            //it exists
            Destroy(GameObject.Find("msVFX_Stylized Smoke 5(Clone)"));
        }
    }
}
