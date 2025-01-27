using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody sphereRigitbody; 
    public float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 inputVector = Vector2.zero; // intialize our input vector 

        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; // "a += b" <=> "a = a + b" 
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y); 
        sphereRigitbody.AddForce(inputXZPlane*ballSpeed);
    }
}
