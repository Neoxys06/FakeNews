using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personnage : MonoBehaviour {
    
     // Start is called before the first frame update
     //variables
private string name;
public string surname="nanami";
int energy;
bool vie=true;
float speed=2.9f;
//table
string [] sac ={"pomme","stylo","cahier","chargeur"};
int [] nombre ={10,5,5,2};
bool [] contenu ={true,true,true,true};
//api

   // void Start() //{
        
        //name="hori";
   //Debug.Log(name);    
    //}

    // Update is called once per frame
   // void Update() //{
       // Debug.Log(surname);
       // if(energy==100){
            //Debug.Log("je suis plein");
       // }
    //} 
    //void FixedUpdate() //{
       //if(name!="bellamard"){
       // Debug.Log("je ne suis pas formateur");
       //}
       //if(energy<10){
            //Debug.Log("je suis en danger");
     //  }} 
   // void OnEnable() //{
        //if(energy>50){
            //Debug.Log("j'ai plus de la moitie");
           // }else{
           // Debug.Log("mabe ekoti");
               // }
    //}
    //void Awake() //{
       // energy=100;
    //}
   // void LateUpdate() //{
        //if(energy<=20){
           // Debug.Log("je suis faible");
        //}else if(energy>=50){
           // Debug.Log("ca va");
        //}else{
           // Debug.Log("je peux continuer");
       // }
}