namespace VendingMachine
{
    public static class MoneyManagement
    {
        public static Money ReturnMoney(ref Money amount)
        {
            var returnedAmount = amount;
            amount = new Money();
            return returnedAmount;
        }

        public static bool IsValidCoin(Money coin)
        {
            return coin.Euros switch
            {
                0 => coin.Cents == 10 || coin.Cents == 20 || coin.Cents == 50,
                1 => coin.Cents == 0,
                2 => coin.Cents == 0,
                _ => false
            };
        }

        public static Money InsertCoin(Money amount, ref Money totalAmount)
        {
            if (IsValidCoin(amount))
            {
                totalAmount.Euros += amount.Euros;
                totalAmount.Cents += amount.Cents;

                totalAmount.Euros += totalAmount.Cents / 100;
                totalAmount.Cents %= 100;
            }

            return totalAmount;
        }
    }
}
