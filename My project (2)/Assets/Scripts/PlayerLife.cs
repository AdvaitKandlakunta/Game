using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    private Animator anim;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Trap"))
       {
         Die();
       }
    }
   
   private void Die()
   {
      anim.SetTrigger("death");
   }
   
}
