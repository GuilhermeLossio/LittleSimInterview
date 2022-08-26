using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    [SerializeField] public GameObject balls;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateBalls", 5.0f, 1f);
    }

    // Update is called once per frame
    public void InstantiateBalls()
    {
        float randLoc = Random.Range(-10f, 10f);
        Instantiate(balls, new Vector2(randLoc, -6.5f), Quaternion.identity);
    }
}
