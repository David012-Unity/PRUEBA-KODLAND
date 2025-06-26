using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public Camera cam;
    public float range = 100f;
    public GameObject impactParticle; // Prefab de la partícula a instanciar

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, range))
            {
                   GameObject impactInstance = Instantiate(
                    impactParticle,
                    hit.point,
                    Quaternion.LookRotation(hit.normal)
                );

                // Destruir la instancia después de 1 segundo
                Destroy(impactInstance, 1f);
            }
        }
    }


  }
    

