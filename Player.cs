using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {
        UIManager.Instance.UpdateScore(5);
    }


}
