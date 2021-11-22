using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puddleStats : MonoBehaviour
{
    public List<string> LujaTypes;
    [SerializeField] private string _type;
    // public lavaPuddle lava;
    public string Type => _type;
    

    void Start()
    {
        _type = LujaTypes[Random.Range(0, LujaTypes.Count)];
    }
}