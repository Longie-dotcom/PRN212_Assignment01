namespace Helper
{
    public static class IDGenerator
    {
        public static int IDGenerate<T>(List<T> list, Func<T, int> IDSelectorMethod)
        {
            // Check if the list is null or have no element
            if (list == null || list.Count == 0)
            {
                return 1;
            }

            var existedIDs = list.Select(IDSelectorMethod).ToHashSet();
            for (int i = 1; i <= existedIDs.Count + 1; i++)
            {
                if (!existedIDs.Contains(i))
                {
                    return i;
                }
            }

            return list.Count + 1;
        }
    }
}
