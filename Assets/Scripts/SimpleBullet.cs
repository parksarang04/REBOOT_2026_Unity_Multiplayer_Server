using Fusion;
using UnityEngine;

public class SimpleBullet : NetworkBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float lifeTime = 2f;

    [Networked] private TickTimer LifeTimer { get; set; }               // 네트워트의 타이머

    public override void Spawned()                                      // 네트워크상 스폰이 되었을때
    {
        if (Object.HasStateAuthority)                                   // 오브젝트의 권한이 있을 때
        {
            LifeTimer = TickTimer.CreateFromSeconds(Runner, lifeTime);  // 타이머를 셋팅 한다
        }
    }





}
