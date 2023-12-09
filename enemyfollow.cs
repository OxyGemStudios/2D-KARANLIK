using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyfollow : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    public float range = 5f;
    public float speed;
    public float stoppingDistance;
    private float timebtwshots;
    public float starttimebtwshots;
    public GameObject bullet;
    public int enemyhealth = 100;
    public int damage = 20;
    public Transform firepoint;
    public float takipsure;
    void Start()
    {
        takipsure = 0f;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        timebtwshots = starttimebtwshots;
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) < 5f)
        {
            agent.isStopped = false;
            agent.SetDestination(target.position);
            takipsure = 1f;
        }
        
        if(Vector2.Distance(transform.position, target.position) > 5f && takipsure > 0)
        {
            agent.isStopped = false;
            agent.SetDestination(target.position);

            takipsure -= Time.deltaTime;
            // this.GetComponent<NavMeshAgent>().enabled = false;
        }
        else if(Vector2.Distance(transform.position, target.position) > 5f && takipsure <= 0)
        {
            // transform.position = this.transform.position;
            agent.isStopped = true;
        }
        //update buraya kadar takip etmesi ve uzaklaþtýktan sonra 1 sn daha takip etmesi
        
        if(Vector2.Distance(transform.position, target.position) < stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
        
    
        if(timebtwshots <= 0 && Vector2.Distance(transform.position, target.position) < 10)
        {
            Instantiate(bullet, firepoint.position, Quaternion.identity);
            timebtwshots = starttimebtwshots;
        }
        else
        {
            timebtwshots -= Time.deltaTime;
        }
    }
    public void TakeDamage(int damage)
    {
        enemyhealth -= damage;
        if(enemyhealth <= 0) { Destroy(gameObject); }
    }


}
