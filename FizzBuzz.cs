using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FizzBuzz : MonoBehaviour
{

    // Links On Screen Text
    public Text fizzBuzzText;

    // Sets Starting Number
    public int currentNum = 0;
    public string currentNumText;

    // What Should Be Said In Place Of 'Fizz' or 'Buzz'
    public string fizz = "Fizz";
    public string buzz = "Buzz";
    public string fizzbuzz;

    // When Should 'Fizz' or 'Buzz' Be Said
    public int fizzWhen = 3;
    public int buzzWhen = 5;

    // Sets If 'Fizz' or 'Buzz' Should Be Said
    public bool isFizzable;
    public bool isBuzzable;
    public bool isFizzBuzzable;

    // Called At The Start
    void Start() {
      // What Should Be Added Together In Place Of 'Fizz' & 'Buzz'
      fizzbuzz = fizz+buzz;
    }

    // Called Once / Frame
    void Update()
    {

    // Checks When Space Bar Is Released
    if(Input.GetKeyUp("space")) {

    // Updates Number
    currentNum = currentNum + 1;
    currentNumText = ""+currentNum;

    // Resets 'Fizz' & 'Buzz'
    isFizzable = false;
    isBuzzable = false;
    isFizzBuzzable = false;

    // Determines If Any Number Can Be Replaced With 'Fizz' or 'Buzz'
    if(currentNum % fizzWhen == 0) {
      isFizzable = true;
    }
    if(currentNum % buzzWhen == 0) {
      isBuzzable = true;
    }
    if(isFizzable == true && isBuzzable == true) {
      isFizzBuzzable = true;
    }

    // Checks If Number Should Be Replaced With 'FizzBuzz'
    if(isFizzBuzzable == false) {
      // Checks If Number Should Be Replaced With 'Fizz' or 'Buzz'
      if(isFizzable == true || isBuzzable == true) {
        // Checks If Number Should Be Replaced With 'Fizz'
        if(isFizzable == true) {
          // Prints 'Fizz'
          print(fizz);
          fizzBuzzText.text = fizz;
        }
        // Checks If Number Should Be Replaced With 'Buzz'
        if(isBuzzable == true) {
          // Prints 'Buzz'
          print(buzz);
          fizzBuzzText.text = buzz;
        }
      } else {
        // Prints The Current Number
        print(currentNum);
        fizzBuzzText.text = currentNumText;
      }
    } else {
      // Prints 'FizzBuzz'
      print(fizzbuzz);
      fizzBuzzText.text = fizzbuzz;
    }

  }

}
}
