using System; //indicating a namespace

namespace IntroToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a variable
            //datatype and name
            //optionally you can assign a value to the variable as it is created.
            string inputTemp = null;

            //What about developer defined datatypes?
            //The class name is used as the datatype
            
            //declaring a variable of the developer datatype class 
            //  sets aside a physical area in memory to hold the 
            //  address location of the actual instance of the class
            //default of these variables is null
            Wallet myWallet = null;

            //How does one get an instance (occurance) of my class
            //The instance is referred to as the object
            //The instance is a physical thing
            //The new command executes the constructor of your class
            myWallet = new Wallet(); //signature of the Default constructor
            Console.WriteLine($"Cash {myWallet.CashBills + myWallet.CashCoins}");

            Wallet herWallet = new Wallet();

            herWallet.CashCoins = 3.75;
            Console.WriteLine($"Cash {herWallet.CashBills + herWallet.CashCoins}");

            //signature of the Greedy Constructor
            Wallet hisWallet = new Wallet(10, 2, "ADDR1234", null, null, null);
            Console.WriteLine($"Cash {hisWallet.CashBills + hisWallet.CashCoins}");

            //assigning a value to my instance using the property
            //the instance is on the left side of an assignment statement
            //the property is using the "set"
            myWallet.CashCoins = 13;
            double addedNumbers = myWallet.CashBills + myWallet.CashCoins;
            Console.WriteLine($"Cash {addedNumbers}");

            //object initializers
            //will use the default constructor to create the instance
            //THEN it assigns values to the data storage in the instance 
            //  via a coding block
            //could also be new Wallet() { ..... }
            Wallet myInitializedWallet = new Wallet
            {
                BankCard = null,
                CashBills = 25.00, //using the set of the property CashBills
                CashCoins = 2.00,
                GasCard = "123456"
            };

            Console.WriteLine($"cash {myInitializedWallet.CashBills + myInitializedWallet.CashCoins}");
            Console.WriteLine($"Cards Bank: {myInitializedWallet.BankCard} Gas: {myInitializedWallet.GasCard} Visa: {myInitializedWallet.VisaCard}");

            //Using the class behaviours (method)
            //the method returns a bool (true or false)
            //REMEMBER, your conditions resolves to either true or false
            //  true == true resolves to true, why code the condition?
            //  false == true resolves to false, why code the condition?

            double insufficient = 4.25;
            double sufficient = 2.75;
            if (herWallet.ExtractAmount(sufficient))
            {
                Console.WriteLine($"Sufficient coins, new coin amount: {myInitializedWallet.CashCoins}");
            }
            else
            {
                Console.WriteLine($"Insufficient coins, new coin amount: {myInitializedWallet.CashCoins}. Use bills and get your change back.");
            }
        }
    }
}
