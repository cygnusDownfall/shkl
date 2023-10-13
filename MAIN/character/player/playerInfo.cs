using System;
using UnityEngine.Events;

public class playerInfo :  characterInfo
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

    public UnityEvent<playerInfo> onSpawn,onDie;

    #region needed for skill access
    
    public override void healing(int heal)
    {
        hp += Convert.ToInt32(heal * (healScale / 100f));
    }

    public override void addChain(Effect effect)
    {
       
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
