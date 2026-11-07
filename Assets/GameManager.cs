using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    [SerializeField] private int Volume = 100;

    [SerializeField] private bool Denial = false;
    [SerializeField] private bool Anger = false;
    [SerializeField] private bool Bargening = false;
    [SerializeField] private bool Depression = false;
    [SerializeField] private bool Acceptance = false;

    [SerializeField] private bool acquiredShiny = false;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public bool getDenial()
    {
        return Denial;
    }
    public void setDenial(bool value)
    {
        Denial = false;
    }
    public bool getAnger()
    {
        return Anger;
    }
    public void setAnger(bool value)
    {
        Anger = false;
    }
    public bool getBargening()
    {
        return Bargening;
    }
    public void setBargening(bool value)
    {
        Bargening = value;
    }
    public bool getDepression()
    {
        return Depression;
    }
    public void setDepression(bool value)
    {
        Depression = value;
    }
    public bool getAcceptance()
    {
        return Acceptance;
    }
    
    public void setAcceptance(bool value)
    {
        Acceptance = value;
    }
    
    public bool setAcquiredShiny(bool value)
    {
        return value;
    }

    public void setAcquiredShiny()
    {

    }

    public int getVolume()
    {
        return Volume;
    }

    public int setVolume(int volume)
    {
        return volume;
        Debug.Log("Volume set to " + Volume);
    }
}
