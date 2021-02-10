using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HitOld : MonoBehaviour
{
    public int score;
     public GameObject Particle;
     public Text textscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textscore.text=score.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "OldObject") {
             score++;
             PlayParticle();
          Destroy(other.gameObject); 
         }
    }
    void PlayParticle(){
        Instantiate(Particle,transform.position, Quaternion.identity); 
       
    }
}
