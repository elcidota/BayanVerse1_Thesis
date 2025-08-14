using UnityEngine;

public class Lapu2AnimationScript : MonoBehaviour
{
    public Animator lapuLapuAnimator;

    // Play Attack animation
    public void PlayAttack()
    {
        // Reset other triggers to avoid conflicts
        lapuLapuAnimator.SetTrigger("Attack");
    }

    // Play Defend animation (Sword and Shield Impact)
    public void PlayDefend()
    {
        // Reset other triggers to avoid conflicts
        lapuLapuAnimator.SetTrigger("Defend");
    }

    // Play Tactic animation (Sword Fight One)
    public void PlayTactic()
    {
        // Reset other triggers to avoid conflicts
        lapuLapuAnimator.SetTrigger("Tactic");
    }
}
