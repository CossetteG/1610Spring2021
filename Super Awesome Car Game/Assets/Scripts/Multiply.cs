using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
    
   public int myInt = 5;
   
   void Start()
   {
       int yourInt;
       yourInt = MultiplyByTwo(myInt); 
       Debug.Log(yourInt);
   }
   
   int MultiplyByTwo(int number)
   {
      int result;
      result = number * 2;
      return result;
   } 
}
// I don't understand very much but the comments make sense 
