using UnityEngine;

public class NedRaycastHight : MonoBehaviour
{
    public Transform smokeParticle;

    void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, -transform.up, out hit, 1f))
        {
            if(!smokeParticle.gameObject.activeInHierarchy)
            smokeParticle.gameObject.SetActive(true);

            smokeParticle.position = new Vector3(hit.point.x, hit.point.y + 0.1f, hit.point.z);
        }
        else
            if (smokeParticle.gameObject.activeInHierarchy)
                smokeParticle.gameObject.SetActive(false);
    }
}
