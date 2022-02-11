using System.Collections.Generic;

namespace Data
{
    public  class SheetAPIResponse
    {
      public string range { get; set; }
      public string majorDimension { get; set; }
        // public string[][] values { get; set; }
        public IList<IList<object>> values { get; set; }

    }

    public static class SheetPareser
    {
        public static List<CortexTrait> Traits(string[][] values)
        {
            var list = new List<CortexTrait>();

            for (int x = 1; x < values.GetLength(0); x++)
            {
                list.Add(new CortexTrait(values[x]));
            }

            return list;
        }
    }
}
