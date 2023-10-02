    using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]


public class DragAndShoot : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    private float forceMultiplier = 3;
    private Rigidbody rb;

    private bool isShot;


    void Start ()
    {

        rb = GetComponent<Rigidbody>();

    }
        
    private void OnMouseDown()
    {

        mousePressDownPos = Input.mousePosition;

   
    }

    private void OnMouseDrag()
    {

        Vector3 forceInit = (Input.mousePosition - mousePressDownPos);
        Vector3 forceV = (new Vector3(forceInit.x, forceInit.y, z: forceInit.y)) * forceMultiplier;

        if (!isShot)
            ThrowPrediction.Instance.UpdateTrajectory(forceVector: forceV, rb, startingPoint: transform.position);


    }

    private void OnMouseUp()
    {

        mouseReleasePos = Input.mousePosition;
        Shoot(Force: mousePressDownPos - mouseReleasePos);
        ThrowPrediction.Instance.HideLine();
    }
    
    void Shoot(Vector3 Force)
    {

        if (isShot)
            return;

        rb.AddForce(new Vector3(Force.x, Force.y, z: Force.y) * forceMultiplier);
        isShot = true;
        Spawner.Instance.NewSpawnRequest();
    }

    public bool ballIsShot()
    {

        return isShot;

    }
}
