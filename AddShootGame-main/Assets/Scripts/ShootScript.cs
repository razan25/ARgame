using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;

    public void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "Apple1" || hit.transform.name == "Apple2" || hit.transform.name == "Apple3" || hit.transform.name == "Apple4")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal)); 
            }
        }
    }
}
