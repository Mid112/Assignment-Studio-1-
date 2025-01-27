using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigitbody; 
    [SerializeField] private float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new (input.x, 0, input.y);
        sphereRigitbody.AddForce(inputXZPlane * ballSpeed);
    }
}
