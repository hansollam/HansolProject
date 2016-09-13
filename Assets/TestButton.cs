using UnityEngine;
using System.Collections;

public class TestButton : MonoBehaviour {

    public GameObject Sphere;
    public Rigidbody rb;
    public float thrust = 5.0f;
    void Awake()
    {
        
    }

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
       
	}
   public void OnClick()
    {
        rb.AddForce(transform.forward * thrust);
    }
}
