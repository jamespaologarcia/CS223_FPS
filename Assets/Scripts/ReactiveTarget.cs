using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
   // private WanderingAI enemyAI;
    public void ReactToHit() {
        WanderingAI enemyAI = GetComponent<WanderingAI>();
        if (enemyAI != null)
        {
            Debug.Log("Enemy is hit");
            enemyAI.ChangeState(EnemyStates.dead);

        }
        Animator enemyAnimator = GetComponent<Animator>();
        if(enemyAnimator != null)
        {
            enemyAnimator.SetTrigger("Die");
        }
     //   StartCoroutine (Die ());
    }
    private void DeadEvent()
    {
        Destroy(this.gameObject);
    }
    private IEnumerator Die() {
        iTween.RotateAdd (this.gameObject, new Vector3 (-75, 0, 0), 1);
        yield return new WaitForSeconds (2);
        Destroy (this.gameObject);
    }
}
