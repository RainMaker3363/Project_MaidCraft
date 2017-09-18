using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Effect : MonoBehaviour {

    private Animator animator;

    // Use this for initialization
    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();

            
        }

        StopCoroutine(Effect_Loop());
        StartCoroutine(Effect_Loop());
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (ani != null)
    //    {
    //        if (ani.isPlaying == false)
    //        {
    //            Destroy(this);
    //        }
    //    }
    //    else
    //    {

    //    }
    //}

    IEnumerator Effect_Loop()
    {
        Debug.Log(animator.GetCurrentAnimatorStateInfo(0).length);

        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        Destroy(this.gameObject);
    }
}
