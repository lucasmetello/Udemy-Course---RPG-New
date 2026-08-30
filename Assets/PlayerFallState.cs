using UnityEngine;

public class Player_FallState : EntityState
{
    public Player_FallState(PlayerScript playerScript, StateMachine stateMachine, string animBoolName) : base(playerScript, stateMachine, animBoolName)
    {
        
    }

    public override void Update()
    {
        base.Update();
    }
}
