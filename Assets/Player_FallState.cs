using UnityEngine;

public class PlayerFallState : EntityState
{
    public PlayerFallState(PlayerScript playerScript, StateMachine stateMachine, string animBoolName) : base(playerScript, stateMachine, animBoolName)
    {
        
    }

    public override void Update()
    {
        base.Update();
    }
}
