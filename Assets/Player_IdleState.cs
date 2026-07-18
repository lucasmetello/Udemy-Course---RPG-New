using UnityEngine;

public class Player_IdleState : EntityState
{
    public Player_IdleState(PlayerScript playerScript, StateMachine stateMachine, string stateName) : base(playerScript, stateMachine, stateName)
    {

    }

    public override void Update()
    {
        base.Update();

        if(Input.GetKeyDown(KeyCode.W))
            stateMachine.ChangeState(playerScript.moveState);

    }
}

