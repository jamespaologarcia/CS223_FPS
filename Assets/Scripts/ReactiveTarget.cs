using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{

    public void ReactToHit() {
        StartCoroutine (Die ());
    }
    private IEnumerator Die() {
        iTween.RotateAdd (this.gameObject, new Vector3 (-75, 0, 0), 1);
        yield return new WaitForSeconds (2);
        Destroy (this.gameObject);
    }
}
