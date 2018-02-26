using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandParentMethod(int position)
        {
            var output = 0;
            try
            {
                output= ParentMethod(position);
            }
            catch (Exception)
            {
                throw new ArgumentException("Erron in your argurment");
            }
            finally
            {

            }
            return output;
        }

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            int output = 0;
            int[] numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];

            return output;
        }
    }
}
