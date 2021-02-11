using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HitOld : MonoBehaviour
{
    public int CountOldObject;
     public GameObject Particle;
     public Text UICountOldObject;
     private Vector3 MakeParticle;
     public GameObject Wayone;
     public GameObject Waytwo;
     public GameObject Waythree;
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        UICountOldObject.text=CountOldObject.ToString();
        if(CountOldObject==3){
            Wayone.SetActive(true);
            Waytwo.SetActive(false);
            Waythree.SetActive(false);
        }
         if(CountOldObject==2){
            Wayone.SetActive(false);
            Waytwo.SetActive(true);
            Waythree.SetActive(false);
        }
          if(CountOldObject==1){
            Wayone.SetActive(false);
            Waytwo.SetActive(false);
            Waythree.SetActive(true);
        }
         if(CountOldObject==0){
            Wayone.SetActive(false);
            Waytwo.SetActive(false);
            Waythree.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "OldObject") {
             CountOldObject--;
             PlayParticle();
          Destroy(other.gameObject); 
         }
    }
    void PlayParticle(){
        Instantiate(Particle,transform.position, Quaternion.identity); 
       
    }
}
