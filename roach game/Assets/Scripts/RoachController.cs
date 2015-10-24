using UnityEngine;
using System.Collections;

public class RoachController : MonoBehaviour
{
    public GameObject mRoach;

    private NavMeshAgent nav_;

    public enum State
    {
        IDLE,
        MOVING,
        DEAD
    };

    public State mCurrState = State.IDLE;

    void Start ()
    {
        Random.seed = System.DateTime.Now.Millisecond;

        nav_ = GetComponent<NavMeshAgent>();
        nav_.updateRotation = false;

        for (int i = 0; i < 10; ++i) //test
        {
            //instantiate
        }
    }
	
	void Update ()
    {
        mCurrState = State.MOVING;
        float randX = Random.Range(0.0f, Screen.width);
        float randZ = Random.Range(0.0f, Screen.height);
        nav_.SetDestination(new Vector3(randX, 0, randZ));
        
        //get vector to target (to - from)
        Vector3 randRot = mRoach.transform.position - (new Vector3(randX, 0, randZ));
        //get angle of vector to target
        float angle = -Mathf.Atan2(randRot.z, randRot.x);
        angle += Mathf.PI / 2.0f;
        angle += Random.Range(-0.1f, 0.1f);
        transform.rotation = Quaternion.Euler(90.0f, -90.0f, (angle / Mathf.PI) * 180.0f);
        
    }
}
