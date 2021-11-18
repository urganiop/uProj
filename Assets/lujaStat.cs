using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lujaStat : MonoBehaviour
{
    public List<string> LujaTypes;
    [SerializeField] private string _type;
    public string Type => _type;


    void Start()
    {
        _type = LujaTypes[Random.Range(0, LujaTypes.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
