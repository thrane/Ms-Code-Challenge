namespace CoinSumChallenge
{
    // In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:

    //    1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).

    // It is possible to make £2 in the following way:

    //    1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p

    // How many different ways can £x (given in pence e.g. £1 = 100) be made using any number of coins?

    public class Challenge
    {

        private readonly int[] _coins = new []{ 200, 100, 50, 20, 10, 5, 2, 1 };
        private int _numberOfWays;

        public int Exuecute(int x)
        {
            CalculateNumber(x, 0, 0);
            var result = _numberOfWays;
            _numberOfWays = 0;
            return result;
        }

        private void CalculateNumber(int coin, int amount, int listIndex)
        {
            for (int i = 0; i <= coin/_coins[listIndex]; i++)
            {
                if (amount <= coin)
                {
                    if (listIndex < _coins.Length-1)
                    {
                        CalculateNumber(coin, amount, listIndex+1);
                    }
                }
                amount = amount + _coins[listIndex];

                if (amount == coin)
                {
                    _numberOfWays++;
                    break;
                }
            }
        }
    }
}