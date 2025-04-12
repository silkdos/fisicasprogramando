using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //Attributes
    public Rigidbody playerRigidbody;
    public float jumpForce = 500;
    public float speedMove = 50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }


    //Update for detection of Inputs
    private void Update()
    {

        //Jump
        if (Input.GetKeyUp(KeyCode.Space))
            playerRigidbody.AddForce(Vector3.up * jumpForce);
        //playerRigidbody.AddForce(0, 1000, 0); //Alternative
    }

    // FixedUpdate for Physics
    void FixedUpdate()
    {
        playerRigidbody.AddForce(Input.GetAxis("Horizontal") * speedMove , 0, Input.GetAxis("Vertical") * speedMove );
    }

}
