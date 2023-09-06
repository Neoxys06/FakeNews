using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class marchePersonnage : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    Rigidbody2D rb;
    Animator anim;
    [SerializeField]
    GameObject ImGameOver;
    void Start()
    {
      rb=GetComponent<Rigidbody2D>();
      anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     float moveHorizontal = Input.GetAxis("Horizontal");
     float moveVertical = Input.GetAxis("Vertical");
     Vector2 move= new Vector2(moveHorizontal, moveVertical);
     rb.velocity = move*speed*Time.fixedDeltaTime;
     makeAnimation(moveHorizontal, moveVertical);
    }
    void makeAnimation(float dirx, float diry){
      if(dirx==0 && diry==0)
      {
        anim.SetInteger("dir",0);
      }
      else if(dirx>0)
      {
        anim.SetInteger("dir", 2);
      }
      else if(dirx<0)
      {
        anim.SetInteger("dir", 1);
      }
      else if(diry>0)
      {
        anim.SetInteger("dir", 3);
      }
      else if(diry<0)
      {
        anim.SetInteger("dir", 4);
      }
    }
    public void GameOver(){
      ImGameOver.SetActive(true);
      StartCoroutine(LoadGameOver());
    }
    IEnumerator LoadGameOver(){
      yield return new WaitForSeconds(3f);
      SceneManager.LoadScene(0);
    }

}
