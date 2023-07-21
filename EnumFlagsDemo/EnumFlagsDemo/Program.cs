namespace EnumFlagsDemo
{
    public enum Suits
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 4,
        Hearts = 8
    }

    [Flags]
    public enum SuitsFlags
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 4,
        Hearts = 8
    }

    [Flags]
    public enum CreditCards
    {
        None = 0,
        Visa = 1,
        MasterCard = 2,
        AmEx = 4,
        Discover = 8,
        RuPay = 16
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var mySuit = Suits.Spades | Suits.Diamonds;
            Console.WriteLine(mySuit.ToString());
            Console.WriteLine((Suits.Spades | Suits.Diamonds).ToString());

            var mySuit2 = SuitsFlags.Spades | SuitsFlags.Diamonds;
            Console.WriteLine(mySuit2.ToString());
            Console.WriteLine((SuitsFlags.Spades | SuitsFlags.Diamonds).ToString());

            var mySuit3 = SuitsFlags.Clubs| SuitsFlags.Hearts;
            Console.WriteLine(mySuit3.ToString());
            Console.WriteLine((SuitsFlags.Clubs| SuitsFlags.Hearts).ToString());
            
            var myCards = CreditCards.MasterCard | CreditCards.AmEx;
            Console.WriteLine(myCards.ToString());
            // Do not check Enum Flags with == operator.
            Console.WriteLine($"Has MC: { myCards == CreditCards.MasterCard}");
            // Instead, use the HasFlag().
            Console.WriteLine($"Has MC: {myCards.HasFlag(CreditCards.MasterCard)}");
            Console.WriteLine($"Has AmEx: {myCards.HasFlag(CreditCards.AmEx)}");
            Console.WriteLine($"Has Visa: {myCards.HasFlag(CreditCards.Visa)}");

            var hasMCOrAmex = myCards.HasFlag(CreditCards.MasterCard) | myCards.HasFlag(CreditCards.AmEx);
            Console.WriteLine($"Has both, MC and AmEx: {hasMCOrAmex}");

            var hasMCAndVisa = myCards.HasFlag(CreditCards.MasterCard) & myCards.HasFlag(CreditCards.Visa);
            Console.WriteLine($"Has both, MC and Visa: {hasMCAndVisa}");

            var myCards2 = CreditCards.None;
            Console.WriteLine(myCards2.ToString());
        }
    }
}