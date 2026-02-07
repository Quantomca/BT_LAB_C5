using UnityEngine;

public class ForceTest : MonoBehaviour
{
    public float force = 500f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }
    }
}

