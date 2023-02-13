using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firefly_Behavior : MonoBehaviour
{
    public AnimationClip anim;
    Animator myAnimator;
    bool shouldPlay = true;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (shouldPlay) {
            shouldPlay = false;
            StartCoroutine(PlayAnimation());
        }
    }

    IEnumerator PlayAnimation() {
        yield return new WaitForSeconds(Random.Range(1, 5));
        myAnimator.SetBool("isPlaying", true);
        yield return new WaitForSeconds(anim.length);
        myAnimator.SetBool("isPlaying", false);
        yield return new WaitForSeconds(Random.Range(5, 6));
        shouldPlay = true;
    }
}
