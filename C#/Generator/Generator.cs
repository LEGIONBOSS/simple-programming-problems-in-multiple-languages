namespace Generator
{
    public static class ListGen
    {
        private static Random _Rand = new Random();

        public static int[] GetArray(uint size, int min = 0, int max = 100)
        {
            if (size == 0) size = 1;
            if (max < min) max = min;

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = _Rand.Next(min, max + 1);
            }
            return array;
        }

        public static List<int> GetList(uint size, int min = 0, int max = 100)
        {
            if (size == 0) size = 1;
            if (max < min) max = min;

            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(_Rand.Next(min, max + 1));
            }
            return list;
        }
    }
}
