namespace HSNXT
{
    using System;
    using System.Globalization;

    /// <summary>
    /// A class used to represent money
    /// </summary>
    /// <remarks>
    /// Contributted by Jason Hunt,
    /// http://noticeablydifferent.com/
    /// </remarks>
    public sealed class Money : IEquatable<Money>, IComparable, IComparable<Money>
    {
        private readonly CultureInfo _cultureInfo;
        private readonly RegionInfo _regionInfo;

        public string EnglishCultureName => _cultureInfo.Name;

        public string IsoCurrencySymbol => _regionInfo.ISOCurrencySymbol;

        public decimal Amount { get; }

        public int DecimalDigits => _cultureInfo.NumberFormat.CurrencyDecimalDigits;

        public Money() : this(0, CultureInfo.CurrentCulture)
        {
        }

        public Money(decimal amount) : this(amount, CultureInfo.CurrentCulture)
        {
        }

        public Money(long amount) : this(amount, CultureInfo.CurrentCulture)
        {
        }

        public Money(string cultureName) : this(new CultureInfo(cultureName))
        {
        }

        public Money(decimal amount, string cultureName) : this(amount, new CultureInfo(cultureName))
        {
        }

        public Money(CultureInfo cultureInfo) : this(0, cultureInfo)
        {
        }

        public Money(decimal amount, CultureInfo cultureInfo)
        {
            _cultureInfo = cultureInfo ?? throw new ArgumentNullException(nameof(cultureInfo));
            _regionInfo = new RegionInfo(cultureInfo.LCID);
            Amount = amount;
        }

        public Money(long amount, CultureInfo cultureInfo)
        {
            _cultureInfo = cultureInfo ?? throw new ArgumentNullException(nameof(cultureInfo));
            _regionInfo = new RegionInfo(cultureInfo.LCID);
            Amount = amount;
        }

        public static bool operator >(Money first, Money second)
        {
            AssertSameCurrency(first, second);
            return first.Amount > second.Amount;
        }

        public static bool operator >=(Money first, Money second)
        {
            AssertSameCurrency(first, second);
            return first.Amount >= second.Amount;
        }

        public static bool operator <=(Money first, Money second)
        {
            AssertSameCurrency(first, second);
            return first.Amount <= second.Amount;
        }

        public static bool operator <(Money first, Money second)
        {
            AssertSameCurrency(first, second);
            return first.Amount < second.Amount;
        }

        public static Money operator +(Money first, Money second)
        {
            AssertSameCurrency(first, second);
            return new Money(first.Amount + second.Amount, first.EnglishCultureName);
        }

        public static Money Add(Money first, Money second)
        {
            return first + second;
        }

        public static Money operator -(Money first, Money second)
        {
            AssertSameCurrency(first, second);
            return new Money(first.Amount - second.Amount, first.EnglishCultureName);
        }

        public static Money Subtract(Money first, Money second)
        {
            return first - second;
        }

        public static implicit operator Money(decimal amount)
        {
            return new Money(amount, CultureInfo.CurrentCulture);
        }

        public static implicit operator Money(long amount)
        {
            return new Money(amount, CultureInfo.CurrentCulture);
        }

        public static bool operator ==(Money first, Money second)
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            if (ReferenceEquals(first, null) || ReferenceEquals(second, null))
            {
                return false;
            }

            return (first.IsoCurrencySymbol == second.IsoCurrencySymbol && first.Amount == second.Amount);
        }

        public static bool operator !=(Money first, Money second)
        {
            return !first.Equals(second);
        }

        public static Money operator *(Money money, decimal value)
        {
            if (money == null) throw new ArgumentNullException(nameof(money));
            return new Money(Decimal.Floor(money.Amount * value), money.EnglishCultureName);
        }

        public static Money Multiply(Money money, decimal value)
        {
            return money * value;
        }

        public static Money operator /(Money money, decimal value)
        {
            if (money == null) throw new ArgumentNullException(nameof(money));
            return new Money(money.Amount / value, money.EnglishCultureName);
        }

        public static Money Divide(Money first, decimal value)
        {
            return first / value;
        }

        public static Money LocalCurrency => new Money(CultureInfo.CurrentCulture);

        public Money Copy()
        {
            return new Money(Amount, _cultureInfo);
        }

        public Money Clone()
        {
            return new Money(_cultureInfo);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (!(obj is Money))
            {
                throw new ArgumentException("Argument must be money");
            }

            return CompareTo((Money) obj);
        }

        public int CompareTo(Money other)
        {
            if (this < other)
            {
                return -1;
            }

            return this > other ? 1 : 0;
        }

        public override string ToString()
        {
            return Amount.ToString("C", _cultureInfo);
        }

        public string ToString(string format)
        {
            return Amount.ToString(format, _cultureInfo);
        }

        public override bool Equals(object obj)
        {
            return (obj is Money money) && Equals(money);
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode() ^ _cultureInfo.GetHashCode();
        }

        public bool Equals(Money other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            return ((IsoCurrencySymbol == other.IsoCurrencySymbol) && (Amount == other.Amount));
        }

        private static void AssertSameCurrency(Money first, Money second)
        {
            if (first.IsoCurrencySymbol != second.IsoCurrencySymbol)
            {
                throw new InvalidOperationException("Money type mismatch.");
            }
        }
    }
}