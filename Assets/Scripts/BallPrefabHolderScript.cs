using UnityEngine;
using System.Collections;

public class BallPrefabHolderScript : MonoBehaviour {

    private int numberOfTimesThisBallHasCollided;
    


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
            
        }
        
        //numberOfTimesThisBallHasCollided += 1;
        //if (numberOfTimesThisBallHasCollided == 2)
        //{
        //    if (collision.gameObject.tag == "Bat")
        //    {
        //        SwingingBatScript.NumberOfHits += 1;
        //        Debug.Log("Total Number of Times Bat Connected with a Ball: " + SwingingBatScript.NumberOfHits);
        //    }
        //    else
        //    {
        //        Debug.Log("I am running into something already");
        //        //Destroy(gameObject);
        //    }
        //}
        //if (numberOfTimesThisBallHasCollided == 3)
        //{
        //    if (collision.gameObject.tag == "FairBall")
        //    {
        //        {
        //            SwingingBatScript.NumberOfFairHits += 1;
        //            Debug.Log("Total Number of Fair Ball Hits: " + SwingingBatScript.NumberOfFairHits);
        //        }
        //    }
        //}
        //if(numberOfTimesThisBallHasCollided>3)
        //{
        //    Debug.Log("Collided a lot: " + numberOfTimesThisBallHasCollided);
        //}
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
}
