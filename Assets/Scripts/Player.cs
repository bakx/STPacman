using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.02f;
    [SerializeField] float yValue = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }

    // Event that occurs when a collision starts
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Someything hit");

        // GetComponent<MeshRenderer>().material.color = Color.red;


        if (other.gameObject.tag == "Pellet") 
        {
            // Do something

            // Increase score

            // Make pellet dissapear

            // Play sound
            

        }

    }
}
