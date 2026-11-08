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

    public bool acquiredShiny = false;

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
        Denial = value;
    }
    public bool getAnger()
    {
        return Anger;
    }
    public void setAnger(bool value)
    {
        Anger = value;
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
    public bool getAcquiredShiny()
    {
        return acquiredShiny;
    }
    public void setAcquiredShiny(bool value)
    {
        acquiredShiny = value;
    }
    public int getVolume()
    {
        return Volume;
    }

    public void setVolume(int volume)
    {
        Volume = volume;
        Debug.Log("Volume set to " + Volume);
    }
}
