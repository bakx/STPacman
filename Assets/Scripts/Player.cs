using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.02f;

    // Used for debugging purposes only
    private TextMesh debugText;
    
    // Start is called before the first frame update
    void Start()
    {
        debugText = GameObject.Find("Debug").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0.0f, zValue);

        debugText.text = $"x: {transform.position.x} z: {transform.position.z}";
    }

    // Event that occurs when a collision starts
    private void OnCollisionEnter(Collision other)
    {
         Debug.Log("Someything hit");

        // GetComponent<MeshRenderer>().material.color = Color.red;


        if (other.gameObject.tag == "Pellet") 
        {
            MeshRenderer pellet =  other.gameObject.GetComponent<MeshRenderer>();

            // Increase score

            // Make pellet dissapear
            UnityEngine.Object.Destroy( other.gameObject );


            // Play sound
            

        }

    }
}
