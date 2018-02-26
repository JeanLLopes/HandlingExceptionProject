namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandParentMethod(int position)
        {
            var output = 0;
            output= ParentMethod(position);
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
