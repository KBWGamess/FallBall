using UnityEngine;

public class Ball : MonoBehaviour
{
    public float jumpForce;
    public GameObject splashPrefab;

    private Rigidbody rb;
    private GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up *  jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0, -0.15f, 0), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        //Debug.Log(materialName);

        if(materialName == "Safe (Instance)")
        {

        }
        else if(materialName == "UnSafe (Instance)")
        {
            gameManager.RestartGame();
        }
        else if(materialName == "Finish (Instance)")
        {

        }
    }
}
