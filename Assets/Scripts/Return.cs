using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    public GameObject Menu;

    public void ReturnToGame() {
        Menu.SetActive(false);
    }
}
