//Worthless Google code that did like literally nothing...
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySimulator : MonoBehaviour
{
        private GameObject player;
        public string objectname;
        Rigidbody2D rb;
        private float gravityForce = 10000f;
        private float gravityDistance = 1.0f;

        // Completely empty, what's the point??

        private void Update()
        {
            player = GameObject.Find("Player");
            //Honestly not sure why they added this...
            float dist = Vector3.Distance(player.transform.position, GameObject.transform.position);
            Vector3 v - player.transform.position - transform.position;
            rb = player.GetComponent<Rigidbody2D>();
            rb.AddForce(v.normalized * (1.0f - gravityDistance) * gravityForce);
        }
}
