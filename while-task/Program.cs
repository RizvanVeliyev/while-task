namespace while_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, price, count;
            string brandName;
            #region size validation 
            while (true)
            {
                Console.Write("Size: ");
                size=int.Parse(Console.ReadLine());
                if (size >= 30 && size <= 45) break;
                else Console.WriteLine("olcu 30-45 araliginda olmalidir!");
            }
            #endregion
            #region price validation 
            while (true)
            {
                Console.Write("Price: ");
                price = int.Parse(Console.ReadLine());
                if (price>0) break;
                else Console.WriteLine("qiymet 0-dan boyuk olmalidir!");
            }
            #endregion
            #region count validation 
            while (true)
            {
                Console.Write("Count: ");
                count = int.Parse(Console.ReadLine());
                if (count > 0 && count<=100) break;
                else Console.WriteLine("say 1-100 araliginda daxil olunmalidir!");
            }
            #endregion
            #region brandName validation 
            while (true)
            {
                Console.Write("Name: ");
                brandName = Console.ReadLine();
                if (brandName.Length > 0 && brandName.Length <= 10) break;
                else Console.WriteLine("Brand adinin uzunlugu 1-10 araliginda olmalidir!");
            }
            #endregion
            int total_price = count * price;
            Console.WriteLine($"total price: {total_price}");
        }
    }
}