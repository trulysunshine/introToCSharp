using System;

namespace AIE
{
    class DigitalPiggyBank
    {
        private float balance;

        public void deposit(float amount)
        {
            balance = balance + amount;
        }

        public float withdraw()
        {
            float temp = balance;
            balance = 0;
            return temp;
        }
    }
    class Program
    {
        //program entry point
        static void Main()
        {
            DigitalPiggyBank dylanPiggyBank = new DigitalPiggyBank();
            dylanPiggyBank.deposit(525.50f);
            dylanPiggyBank.deposit(1.24f);
            dylanPiggyBank.deposit(3.67f);

            DigitalPiggyBank brandonPiggyBank = new DigitalPiggyBank();
            brandonPiggyBank.deposit(.50f);
            brandonPiggyBank.deposit(30.50f);

            float myCash = dylanPiggyBank.withdraw();
            Console.WriteLine(myCash);
        }
    }
}
