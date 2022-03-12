using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spown", 1, 5);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void spown()
    {

        Instantiate(enemy, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 50), enemy.transform.rotation);
    }
}
