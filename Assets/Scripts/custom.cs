using UnityEngine;

public class custom : MonoBehaviour
{
    public Rigidbody rb; 
    float Time_Const = 1.85f;
    float temp = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
        //rb.drag = 1;
    }

    public float forwardForce = -500f;
    public float sideWays = 100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(-sideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(sideWays * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0 , 0, forwardForce * Time.deltaTime);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if(Input.GetKey("space"))
        {
            if(Time.time > temp) // temp initial is 0 , Time.time (current time)
            {
                rb.AddForce(0, 500, 0);
                temp = Time.time + Time_Const;
            }
        }


    }
}
