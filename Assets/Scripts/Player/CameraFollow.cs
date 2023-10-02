using UnityEngine;

public class CameraFollow : MonoBehaviour

{

    public Transform Sphere;

    void Update()

    {

        transform.position = Sphere.transform.position + new Vector3(0, 1, -10);

    }

}