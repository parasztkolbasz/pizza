namespace ConsoleApp1
{
    internal class OrderCalculatorTotal
    {
        public int OrderCalculator(int pizzacount, bool delevery) 
        {
            if (pizzacount <= 0 || pizzacount > 20) 
            {
                return -1;
            }
            double dbpizzaar = 2500;
            double osszes = pizzacount * dbpizzaar;
            if (pizzacount >= 4) { osszes *= 0.9; }
            if (delevery)
            {
                osszes += 500;
            }
            return (int) Math.Round( osszes);

        }
    }
}
