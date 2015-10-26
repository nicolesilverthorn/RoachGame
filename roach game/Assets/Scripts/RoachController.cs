using UnityEngine;
using System.Collections;

public class RoachController : MonoBehaviour
{
    public GameObject mRoach;

    private NavMeshAgent nav_;
    private float maxDist_ = 30.0f;
    private Vector3 dir_;
    private Vector3 spawnPos_;

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

        dir_ = Random.insideUnitSphere * maxDist_;
        nav_ = GetComponent<NavMeshAgent>();
        nav_.updateRotation = false;

        float randX = Random.Range(-15.0f, 15.0f);
        float randZ = Random.Range(-8.0f, 8.0f);
        spawnPos_ = new Vector3(randX, 0.0f, randZ);

        //for (int i = 0; i < numRoaches; i++)      <-- for loop crashes unity wtf
        //{
            Instantiate(mRoach, spawnPos_, Quaternion.identity);
        //}
    }
	
	void Update ()
    {
        mCurrState = State.MOVING;

        dir_ += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(dir_, out hit, Random.Range(0f, maxDist_), 1);
        Vector3 dest = hit.position;
        nav_.SetDestination(dest);
    }
}
