using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}


public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    public float tilt;
    public Boundary boundary;
    

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal")*speed;
        float moveVertical = Input.GetAxis("Vertical") * speed;

        rb.AddForce(moveHorizontal, 0.0f, moveVertical);
        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
        rb.rotation = Quaternion.Euler(0.0f,0.0f,rb.velocity.x*-tilt);
    }
}
