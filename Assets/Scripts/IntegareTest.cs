using UnityEngine;
namespace Assignment27
{

    public class IntegareTest : MonoBehaviour
    {
        void Start()
        {
            int num1 = 10;
            int num2;


            IntegerAdd(num1);
            CallByRef(ref num1);
            CallByOut(out num2);
        }

        void IntegerAdd(int number)
        {
            number += 10;
            Debug.Log(number);
        }

        void CallByRef(ref int number)
        {
            number += 10;
            Debug.Log(number);
        }
        void CallByOut(out int number)
        {
            number = 20;
            Debug.Log(number);
        }


    }
}