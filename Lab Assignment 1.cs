using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabAssignment1 : MonoBehaviour
{
    public string courseName;
    public int modules, readings, quizzes, assignments, instructor0forYes1forNo;
    public double modulesPerc, readingsPerc, quizzesPerc, assignmentsPerc, instructorPerc;
    double modulesTotal, readingsTotal, quizzesTotal, assignmentsTotal, instructorTotal, totalTotal;
    
    void Start()
    {
        modulesTotal = ((modulesPerc/100)*(modules));
        readingsTotal = ((readingsPerc/100)*(readings));
        quizzesTotal = ((quizzesPerc/100)*(quizzes));
        assignmentsTotal = ((assignmentsPerc/100)*(assignments));
        instructorTotal = ((instructorPerc/100)*(instructor0forYes1forNo*10));

        totalTotal = ((modulesTotal+readingsTotal+quizzesTotal+assignmentsTotal+instructorTotal));

        Debug.Log("\nTask #1");
        Debug.Log(courseName);
        Debug.Log("\nDifficulty scale " +totalTotal+ " out of 10\nThe lower the number the easier it will be");
    }

}