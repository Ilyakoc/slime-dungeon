using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Health : MonoBehaviour
{
    [SerializeField]
    private float _maxHp;

    [SerializeField]
    private UnityEvent Die;

    [SerializeField]
    private UnityEvent<float> HpChaged;

    [SerializeField]
    private UnityEvent<float> HpChagedPercent;

    private float _hp;

    public float HP
    {
        get =>  _hp;
        set
        {
            _hp = value;
            HpChaged?.Invoke(_hp);
            HpChagedPercent?.Invoke(_hp / _maxHp);

            if(_hp<=0)
                Die?.Invoke();
        }
    }

    void Start()
    {
        Init();
    }

    public void Init()
    {
        HP = _maxHp;
    }

    public void GetDamage(float damage)
    {
        HP -= damage;
    }

    public void AddHealth(float hp) 
    {
        HP += hp;
    }
}
