using UnityEngine;

public class Player_GroundedState : EntityState
{
    public Player_GroundedState(PlayerScript playerScript, StateMachine stateMachine, string stateName) : base(playerScript, stateMachine, stateName)
    {

    }

    public override void Update()
    {
        base.Update();

        if(input.Player.Jump.WasPressedThisFrame())
        {
            stateMachine.ChangeState(playerScript.jumpState);
        }
    

        

    }
}
