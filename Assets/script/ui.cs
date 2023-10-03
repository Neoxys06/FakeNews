using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int time;
    [SerializeField]
    Text myTime;
    void Start()
    {
     StartCoroutine(Minuterie());   
    }
    IEnumerator Minuterie (){
         
        while(time>0){
            yield return new WaitForSeconds(1f);
            time--;
            
            myTime.text="Time chronos : "+time;

        }
        GameObject.Find("Hori").GetComponent<marchePersonnage>().GameOver();
    }
}
