using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_try1
{
    public class Variable
    {
        //Member variables
        public decimal Value = 0;
        public decimal tempValue1 = 0;
        public string illegalMsg = "";
        int[] operators = new int[] { -1, -1 };
        int turn = 0;        
        bool firstTime = true;
        //public bool decimalFlag = false;        

        


        //Methods
        public void Assign(string num, int action)
        {
            turn++;
            
            if (firstTime)
            {
                firstTime = false;
                Value = Convert.ToDecimal(num);
                operators[0] = action;
            }
            else
            {
                if((turn % 2) == 0)
                {
                    operators[1] = action;
                    tempValue1 = Convert.ToDecimal(num);
                }
                else
                {
                    operators[0] = action;
                    tempValue1 = Convert.ToDecimal(num);
                }
            }

            //Incase of computation
            if (action == 7)
            {
                Compute();
            }
            //Taking action based on turn number
            //Even - use action of operation[0] (to use previously saved action)
            if ((turn % 2) == 0 && turn != 1)
            {
                switch (operators[0])
                {
                    case 0:
                        Add(tempValue1);
                        break;
                    case 1:
                        Sub(tempValue1);
                        break;
                    case 2:
                        Multiply(tempValue1);
                        break;
                    case 3:
                        Divide(tempValue1);
                        break;
                    case 4:
                        //Percentage(tempValue1);
                        break;
                    case 5:
                        //Invert(tempValue1);
                        break;
                    case 6:
                        Module(tempValue1);
                        break;
                    default:
                        Compute();
                        break;
                }
            }
            else if ((turn % 2) == 1 && turn != 1)
            {
                //Odd - use action of operation[1] (to use previously saved action)
                switch (operators[1])
                {
                    case 0:
                        Add(tempValue1);
                        break;
                    case 1:
                        Sub(tempValue1);
                        break;
                    case 2:
                        Multiply(tempValue1);
                        break;
                    case 3:
                        Divide(tempValue1);
                        break;
                    case 4:
                        //Percentage(tempValue1);
                        break;
                    case 5:
                        //Invert(tempValue1);
                        break;
                    case 6:
                        Module(tempValue1);
                        break;
                    default:
                        Compute();
                        break;
                }
            }


            //if(num == "")
            //{
                                
            //}
            //else
            //{
            //    tempValue1 = Convert.ToDecimal(num);
            //    operatorInUse = action;
            //}
            

                   

            
                

            
            
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
            Value -= num;                        
        }
        public void Multiply(decimal num)
        {            
            Value *= num;                       
        }
        public void Divide(decimal num)
        {
            if (num == 0)
            {
                illegalMsg = "Division by Zero is not allowed!";                
            }
            else
            {
                Value /= num;                                
            }
            
        }
        //public void Percentage(decimal num)
        //{
        //    if(Value == 0)
        //    {
        //        Value = num / 100;
        //    }
        //    Value *= (num / 100);
        //}
        //public void Invert(decimal num)
        //{
        //    if(Value == 0)
        //    {
        //        Value = -(num);
        //    }
        //    else
        //    {
        //        tempValue1 = -(num);
        //    }
            
        //}
        public void Module(decimal num)
        {
            Value %= num;
        }
        public decimal Compute()
        {            
            return Value;
        }
        public void Reset()
        {
            Value = 0;
            tempValue1 = 0;
            firstTime = true;
            turn = 0;
            operators[0] = -1;
            operators[1] = -1;
            illegalMsg = "";
        }



    }
}
