using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabAssignment2 : MonoBehaviour
{

    public double numBooks, bookCost;
    
    double bulkBookCost, shippingCost, totalCost;

    // Start is called before the first frame update
    void Start()
    {
            bulkBookCost = ((bookCost * 0.60) * numBooks);
            shippingCost = (3.0 + (0.75 * (numBooks - 1)));
            totalCost = bulkBookCost + shippingCost;

            Debug.Log("Task #2\nThe total cost is:" + totalCost.ToString() +"$");  
    }
}