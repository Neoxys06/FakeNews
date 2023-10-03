using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class quete : MonoBehaviour
{
    // Start is called before the first frame update
    bool activatorQuete=false;
    int countQuete=0;
    int rencontre=3;
    int activ;
     [SerializeField] GameObject Dial;
     [SerializeField] GameObject [] activators;
     [SerializeField] GameObject [] quetes;
     [SerializeField] Text titleUi, dialUi;
     [SerializeField] string [] nameQuetes;
     [SerializeField] string []messagesQuetes, congratulations;
     [SerializeField] AudioClip soundActiv, soundQuete;
     AudioSource audio;
    void Start()
    {
        audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(activatorQuete&&countQuete==activ){

        if(Input.GetKeyDown(KeyCode.Space)){
                Destroy(activators[activ]);
                Debug.Log("tokoss !!!!");
            }
        }
    }
     private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag=="activator"){
             activ=other.gameObject.GetComponent<level>().queteLevel;
             Dial.SetActive(true);
            myActivator(activ);
        }
        if(other.collider.tag=="quete" && activatorQuete==true){
            activ =other.gameObject.GetComponent<level>().queteLevel;
            if(activ==0){
                myQuete(activ);
            }
            else if(activ==1){
                queteResearch(activ);
            }
        }
        
    }
    private void OnCollisionExit2D(Collision2D other) {
        Dial.SetActive(false);
    }
    void myActivator(int activator){
        if(countQuete==activator){
            activatorQuete=true;
            Dial.SetActive(true);
            //ajouter un script pour dialogue
            titleUi.text=nameQuetes[activator];
            dialUi.text=messagesQuetes[activator];
            audio.PlayOneShot(soundActiv);
           
        }
        else{
            Debug.Log("petit joueur");
        }
       
    }
    void myQuete(int quetec){
        if(countQuete==quetec){
            Debug.Log("quete");
            activatorQuete=false;
            Dial.SetActive(true);
            titleUi.text=nameQuetes[quetec];
            dialUi.text=congratulations[quetec];
            audio.PlayOneShot(soundQuete);
            countQuete++;
        }
    }
    void queteResearch(int quetec){
        if(countQuete==quetec){
            rencontre++;
            if(rencontre==3){
                activatorQuete=false;
                Dial.SetActive(true);
                titleUi.text=nameQuetes[quetec];
                dialUi.text=congratulations[quetec];
                countQuete++;
            }
        }
    }
}