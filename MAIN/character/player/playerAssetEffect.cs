using UnityEngine;
using UnityEngine.VFX;

public class playerAssetEffect : Singleton<playerAssetEffect>
{
    //public static playerAssetEffect ins;
    public GameObject dmgShowObj;
    public GameObject effectHit;
    public byte cardPoint=0;
    public byte maxCardPoint=100;
}
