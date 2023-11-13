using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    public float Ammo = 0.0f;
    private bool shoot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot = false;
        if (Input.GetMouseButtonDown(0)&&Ammo>0)
        {
            Ammo -= 1;
            shoot = true;
        }
        if (Input.GetMouseButtonDown(0) && Ammo==0) {
            AudioSource noAmmo = GetComponent<AudioSource>();
            noAmmo.Play();
        }

    }
    private void FixedUpdate()
    {
        Ray ray = Camera.main.ViewportPointToRay(Camera.main.transform.TransformDirection(Vector3.forward));
        Debug.DrawRay(ray.origin,ray.direction);
        if (shoot) {
            
            RaycastHit result;
            Physics.Raycast(ray, out result);
            if (result.collider.gameObject.name == "Target") {
                GameObject g = result.collider.gameObject;
                Animation a = g.transform.parent.GetComponent<Animation>();
                a.Play("LowerBridge");
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AmmoBox") { 
        other.gameObject.SetActive(false);
        Ammo = +20.0f;
            AudioSource ammoBox = GetComponent<AudioSource>();
            ammoBox.Play();
    }
        
    }
}
