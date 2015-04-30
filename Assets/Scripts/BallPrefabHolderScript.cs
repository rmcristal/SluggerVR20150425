using UnityEngine;
using System.Collections;

public class BallPrefabHolderScript : MonoBehaviour {

    public GameObject bat;
    


	// Use this for initialization
	void Start () {

        
     
	}
	
	// Update is called once per frame
	void Update () 
	{
	

	}




	void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "Bat")
        {
            UIScript.NumberOfHits++;
            StartCoroutine("DestroyBallScript");
            
        }

	}


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "NewFair")
        {
            UIScript.NumberOfFairHits++;
            Destroy(gameObject.collider);
            
        }
        
        if(other.gameObject.tag == "FoulBall")
        {
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyBallScript()
    {
        yield return new WaitForSeconds(7);
        Destroy(gameObject);
    }
}
