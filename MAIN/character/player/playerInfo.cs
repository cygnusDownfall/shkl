using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;

public class playerInfo :  CharacterInfo
{
    #region BattleStatus

    public byte healScale = 100;//don vi %
    public byte recoveryMPScale = 100;//don vi %


    #endregion
    #region socialStatus
    public string namePlayer;

    public charJob job;
    //public string gender;
    // #region customSkin
    // public string skin;
    // public string face;
    // public string hair;
    // public string hairColor;
    // public string eye;
    // public string eyeColor;
    // public string clothes;
    // #endregion
    #endregion
    public List<Effect> chainEffect;
    public UnityEvent<playerInfo, Effect> onChain;
    public UnityEvent<playerInfo> onSpawn,onDie;

    #region needed for skill access
    public override void takeDamage(int dmg, DmgType dmgType)
    {
        NativeArray<int> Hp = new NativeArray<int>(1, Allocator.TempJob);
        Hp[0] = hp;
        DamageCalcJob dmgCalc = new DamageCalcJob()
        {
            HP = Hp,
            Dmg = dmg,
            defense = defence[dmgType],
            scaleDefense = 100
        };
        JobHandle handle = dmgCalc.Schedule();
        handle.Complete();
        hp = dmgCalc.HP[0];
        Hp.Dispose();
        Debug.Log(hp);
    }
    public override void healing(int heal)
    {
        hp += Convert.ToInt32(heal * (healScale / 100f));
    }

    public override void addChain(Effect effect)
    {
        Debug.Log("on chain listener count:" + (onChain.GetPersistentEventCount()));
        if (onChain.GetPersistentEventCount() != 0)
        {
            onChain.Invoke(this, effect);
        }
        else
        {
            StartCoroutine(effect.trigger(gameObject));
            chainEffect.Add(effect);
        }
    }
    public void removeChain(Effect effect)
    {
        chainEffect.Remove(effect);
    }
    #endregion

    void Start()
    {
        hp = maxHP;
        mp = maxMP;
        attack = 1;
        speed = 1;
        //hoac load tu file 


        //xu li loading dau game
        onSpawn.Invoke(this);
        loadingUI.Instance.Hide();
    }
    void Update()
    {
    }
    public void save(){

    }
    
}
