using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //Rigidbody player;
    public float speed;
    float horizontal;

    void Start()
    {
        //player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //player.AddForce(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal*speed * Time.deltaTime);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
