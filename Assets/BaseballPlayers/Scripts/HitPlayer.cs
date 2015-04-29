using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitPlayer : MonoBehaviour {

	public GUIText m_HelpText=null;
	public GameObject m_HitPlayer=null;
	bool bEnd=true;
    public AudioClip hit;
    private int swingCountRemaining = 20;
    public Text UIText;
    private int numberOfFairHitsLocal;



	// Use this for initialization
	void Start () {
		m_HelpText.text=m_HelpText.text.Replace("\\","\n");
		m_HitPlayer.animation["idle"].wrapMode=WrapMode.Loop;
		m_HitPlayer.animation.Play("idle");
        
	}


	
	// Update is called once per frame
    void Update()
    {
        numberOfFairHitsLocal = SwingingBatScript.NumberOfFairHits;
        UIText.text = ("Swings Remaining: " + swingCountRemaining + "\nNumber of Hits: " + numberOfFairHitsLocal);
        if (bEnd)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                bEnd = false;
                StartCoroutine("PlayAni", "hit");
                swingCountRemaining -= 1;
                //UIText.text = ("Swings Remaining: " + swingCountRemaining + "\nNumber of Hits: " + numberOfFairHitsLocal);
                return;
            }
            if(Input.GetKeyDown(KeyCode.F))
            {
                m_HitPlayer.animation.Play("Bunt");
            }

        }
    }
    //fix
	
	IEnumerator PlayAni(string name) {
		m_HitPlayer.animation.Play(name);
		yield return new WaitForSeconds(m_HitPlayer.animation[name].length);
		m_HitPlayer.animation.Play("idle");
		bEnd=true;
	}

   void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(hit, new Vector3(0f, 1f, -14f));
        Debug.Log("There was at least a tip");

    }

    
}
