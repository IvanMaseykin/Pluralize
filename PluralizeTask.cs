namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            int a = count % 10;
            int b = (count / 10) % 10;

            if (b == 1)
            {
                return "рублей";
            }
            if (a > 1 & a <= 4)
            {
                return "рубля";
            }
            if (a == 1)
            {
                return "рубль";
            }
            return "рублей";
        }
	}
}