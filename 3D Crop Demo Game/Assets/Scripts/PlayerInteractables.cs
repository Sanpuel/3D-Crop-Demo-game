using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractables : MonoBehaviour
{
    public int damage = 1;
    public float shootRange = 10.0f;
    public float grabRange = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetButtonUp("Fire2"))
        {
            Grab();
        }
    }
    void Grab()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.forward, out hit, grabRange);
        if (hit.transform != null)
        {
            Debug.Log(hit.transform.gameObject.name);
            if (hit.transform.gameObject.GetComponent<InteractableItem>() != null)
            {
                hit.transform.parent = transform;
                hit.transform.gameObject.GetComponent<Rigidbody>().useGravity = false;
                hit.transform.gameObject.GetComponent<Collider>().isTrigger = true;
            }

        }
    }
    void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.forward, out hit, shootRange);
        if (hit.transform.gameObject.GetComponent<EnemyHealth>() != null)
        {
            hit.transform.gameObject.GetComponent<EnemyHealth>().ReduceHP(damage);
        }
    }
}
    

