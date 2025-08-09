using UnityEngine;

public class RizalAnimatorScript : MonoBehaviour
{
    public Animator rizalAnimator;

    public void PlayDance()
    {
        rizalAnimator.ResetTrigger("Flip");
        rizalAnimator.SetTrigger("Dance");
    }

    public void PlayFlip()
    {
        rizalAnimator.ResetTrigger("Dance");
        rizalAnimator.SetTrigger("Flip");
    }
    public void PlayAttack()
    {
        rizalAnimator.ResetTrigger("Attack");
        rizalAnimator.SetTrigger("Flip");
        rizalAnimator.SetTrigger("Dance");
    }
}
