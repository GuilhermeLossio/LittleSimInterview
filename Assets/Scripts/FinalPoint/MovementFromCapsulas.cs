using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFromCapsulas : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ballRB;
    private GameObject eventSys;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        eventSys = GameObject.Find("EventSystem");
        Vector2 pointZero = -transform.position;
        ballRB.AddForce(pointZero * speed);
        Invoke("destroyOnTime", 8.0f);
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("NPCVerifyer"))
        {
            eventSys.SendMessage("DecressLife");
            Destroy(gameObject);
        }
    }

    public void destroyOnTime()
    {
        Destroy(gameObject);
    }
}
