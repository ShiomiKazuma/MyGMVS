using UnityEngine;

public class Free : RobotBase
{
    [SerializeField] GameObject _mainBeam;

    protected override void Attack()
    {
        throw new System.NotImplementedException();
    }

    protected override void Awaking()
    {
        throw new System.NotImplementedException();
    }

    protected override void AwakingAttack()
    {
        throw new System.NotImplementedException();
    }

    protected override void Shooting()
    {
        Instantiate(_mainBeam, this.transform.position, Quaternion.identity);
    }

    protected override void SpecialAttack()
    {
        throw new System.NotImplementedException();
    }

    protected override void SpecialShooting()
    {
        throw new System.NotImplementedException();
    }

    protected override void SubShooting()
    {
        throw new System.NotImplementedException();
    }
}
