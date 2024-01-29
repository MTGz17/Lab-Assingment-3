using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabAssignment3 : MonoBehaviour
{

    public int wholePay;
    int quotientH, remainderH, quotientF, remainderF, quotientTW, remainderTW, quotientT, remainderT, quotientFIV, remainderFIV, quotientO, remainderO;

    // Start is called before the first frame update
    void Start()
    {
            quotientH = System.Math.DivRem(wholePay, 100, out remainderH);
            quotientF = System.Math.DivRem(remainderH, 50, out remainderF);
            quotientTW = System.Math.DivRem(remainderF, 20, out remainderTW);
            quotientT = System.Math.DivRem(remainderTW, 10, out remainderT);
            quotientFIV = System.Math.DivRem(remainderT, 5, out remainderFIV);
            quotientO = System.Math.DivRem(remainderFIV, 1, out remainderO);

            Debug.Log("Task #3\nYou will get " +quotientH+ " hundred dollar bill/s");
            Debug.Log("\nYou will get " +quotientF+" fifty dollar bill/s");
            Debug.Log("\nYou will get " +quotientTW+ " twenty dollar bill/s");
            Debug.Log("\nYou will get " +quotientT+ " tenth dollar bill/s");
            Debug.Log("\nYou will get " +quotientFIV+ " five dollar bill/s");
            Debug.Log("\nYou will get " +quotientO+ " one dollar bill/s");
    }
}