using UnityEngine;

public abstract class EntityState
{
    protected PlayerScript playerScript;
    protected StateMachine stateMachine;
    protected string stateName;

    public EntityState(PlayerScript playerScript, StateMachine stateMachine, string stateName)
    {   
        this.playerScript = playerScript;
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    public virtual void Enter()
    {
        //Debug.Log("I enter" + stateName);
    }

    public virtual void Update()
    {
        //Debug.Log("I update of" + stateName);
    }

    public virtual void Exit()
    {
        //Debug.Log("I exit" + stateName);
    }
}
