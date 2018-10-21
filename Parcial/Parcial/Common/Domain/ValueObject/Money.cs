using Parcial.Common.Application.Enum;

namespace Parcial.Common.Domain.ValueObject
{
    public class Money
    {
        public decimal Amount { get; }
        public Currency Currency { get; }

        public Money()
        {
        }

        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money GoldPieces(decimal amount)
        {
            return new Money(amount, Currency.GOLD);
        }

        public static Money SilverPieces(decimal amount)
        {
            return new Money(amount, Currency.SILVER);
        }

        public static Money CooperPieces(decimal amount)
        {
            return new Money(amount, Currency.COOPER);
        }
    }
}
