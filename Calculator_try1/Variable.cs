using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_try1
{
    class Variable
    {
        //Member variables
        public decimal Value = 0;
        public decimal tempValue = 0;
        public string illegalMsg = "";
        int lastOperator = -1;
        //public bool decimalFlag = false;
               
        //Methods
        public void Assign(string num, int action)
        {
            tempValue = Convert.ToDecimal(num);

            if(action != 7)
            {
                lastOperator = action;
            }            

            switch (action)
            {
                case 0:
                    Add(tempValue);
                    break;
                case 1:
                    Sub(tempValue);
                    break;
                case 2:
                    Multiply(tempValue);
                    break;
                case 3:
                    Divide(tempValue);
                    break;
                case 4:
                    Percentage(tempValue);
                    break;
                case 5:
                    Invert(tempValue);
                    break;
                case 6:
                    Module(tempValue);
                    break;
                case 7:
                    Compute();
                    break;
                default:
                    Compute();
                    break;
            }
                

            
            
        }
        //public void decimalStart()
        //{
        //    if (decimalFlag)
        //    {
        //        decimalFlag = false;
        //    }
        //    else
        //    {
        //        decimalFlag = true;
        //        Assign(0.0);
        //    }
            
        //}
    
        public void Add(decimal num)
        {
            Value+= num;
        }
        public void Sub(decimal num)
        {
            //handling first number
            if(Value == 0)
            {
                Value += num;
            }
            else
            {
                Value -= num;
            }
            
        }
        public void Multiply(decimal num)
        {
            if(Value == 0)
            {
                Value = num;
            }
            else
            {
                Value *= num;
            }
            
        }
        public void Divide(decimal num)
        {
            if(num == 0)
            {
                illegalMsg = "Division by Zero is not allowed!";
            }
            else
            {
                Value /= num;
            }
            
        }
        public void Percentage(decimal num)
        {
            Value *= (num / 100);
        }
        public void Invert(decimal num)
        {
            tempValue = -(num);
        }
        public void Module(decimal num)
        {
            Value %= num;
        }
        public decimal Compute()
        {
            if(lastOperator != -1)
            {
                Assign(tempValue.ToString(), lastOperator);
            }
            return Value;
        }
        public void Reset()
        {
            Value = 0;
        }



    }
}
