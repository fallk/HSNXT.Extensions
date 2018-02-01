using HSNXT;

namespace CodeBetter.Extensions.Tests
{
   #region
   using System;
   using System.Globalization;
   using System.Xml;
   using NUnit.Framework;
   #endregion

   [TestFixture]
   public class MoneyTestFixture
   {
      private Money _cad1, _cad2, _cad3, _usd;

      #region Setup/Teardown
      [SetUp]
      public void SetUp()
      {
         _cad1 = new Money("en-CA");
         _cad2 = new Money("en-CA");
         _cad3 = new Money(15, "en-CA");
         _usd = new Money("en-US");
      }
      [TearDown]
      public void TearDown() {}
      #endregion
     
      [Test]
      public void AddingSameCurrenciesAddMethod()
      {
         Money result = Money.Add(_cad1, _cad3);
         Assert.AreEqual(15, result.Amount);
         Assert.AreEqual(_cad3, result);
      }
      [Test]
      public void AddingSameCurrenciesAddOperator()
      {
         Money result = _cad1 + _cad3;
         Assert.AreEqual(15, result.Amount);
         Assert.AreEqual(_cad3, result);
      }
      [Test]
      public void AssignDecimalToMoney()
      {
         decimal decimalValue = 432;
         Money money = decimalValue;
         Assert.AreEqual(decimalValue, money.Amount);
      }
      [Test]
      public void AssignLongToMoney()
      {
         long integerValue = 432;
         Money money = integerValue;
         Assert.AreEqual(integerValue, money.Amount);
      }
      [Test]
      public void CloneTest()
      {
         Money money = new Money(53m);
         Money clone = money.Clone();
         Assert.IsFalse(money == clone);
         Assert.AreEqual(money.IsoCurrencySymbol, clone.IsoCurrencySymbol);
         Assert.AreEqual(0, clone.Amount);
      }
      [Test]
      public void CompareToCastToObjetReturnsSameResult()
      {
         Assert.AreEqual(-1, _cad2.CompareTo((object) _cad3));
         Assert.AreEqual(1, _cad3.CompareTo((object) _cad1));
         Assert.AreEqual(0, _cad1.CompareTo((object) _cad2));
      }
      [Test]
      public void CompareToNull()
      {
         string someNullObject = null;
         Assert.AreEqual(1, _cad1.CompareTo(someNullObject));
      }
      [Test]
      public void CompareToSortsMoneyByAmount()
      {
         Assert.AreEqual(-1, _cad2.CompareTo(_cad3));
         Assert.AreEqual(1, _cad3.CompareTo(_cad1));
         Assert.AreEqual(0, _cad1.CompareTo(_cad2));
      }
      [Test]
      public void ConstructorWithLongAndCultureInfoTest()
      {
         long value = 1;
         Money money = new Money(value, CultureInfo.CurrentCulture);
         Assert.AreEqual(Convert.ToDecimal(value), money.Amount);
         Assert.AreEqual(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalDigits, money.DecimalDigits);
         Assert.AreEqual(CultureInfo.CurrentCulture.Name, money.EnglishCultureName);
         Assert.AreEqual(RegionInfo.CurrentRegion.ISOCurrencySymbol, money.IsoCurrencySymbol);
      }
      [Test]
      public void CopyTest()
      {
         Money originalMoney = new Money(53m);
         Assert.AreEqual(originalMoney, originalMoney.Copy());
         Assert.IsFalse(originalMoney == new Money(53m, "fr-FR"));
      }
      [Test]
      public void DefaultConstructor()
      {
         Money money = Money.LocalCurrency;
         Assert.AreEqual(RegionInfo.CurrentRegion.ISOCurrencySymbol, money.IsoCurrencySymbol);
         Assert.AreEqual(0, money.Amount);
      }
      [Test]
      public void DivisionDivideMethod()
      {
         Money result = Money.Divide(_cad3, 5);
         Assert.AreEqual(3m, result.Amount);
      }
      [Test]
      public void DivisionOperator()
      {
         Money result = _cad3 / 5;
         Assert.AreEqual(3m, result.Amount);
      }
      [Test]
      public void DivisionOperatorDividingToRealNumber()
      {
         _cad3 = new Money(1);
         Money result = _cad3 / 8;
         Assert.AreEqual(1m / 8m, result.Amount);
      }
      [Test]
      public void EqualOperatorNull()
      {
         Assert.IsFalse(_cad1 == null);
         Assert.IsFalse(null == _cad1);
      }
      [Test]
      public void Equals()
      {
         Assert.IsFalse(_cad1.Equals(_usd));
         Assert.IsTrue(_cad1.Equals(_cad2));
         Assert.IsTrue(_cad1.Equals(_cad1));
         Assert.IsFalse(_cad1.Equals(_cad3));
      }
      [Test]
      public void EqualsConsistentWithEqualOperator()
      {
         Assert.AreEqual(_cad1 == _cad2, _cad1.Equals(_cad2));
         Assert.AreEqual(_cad3 == _cad2, _cad3.Equals(_cad2));
         Assert.AreEqual(_cad1 == _cad3, _cad1.Equals(_cad3));
         Assert.AreEqual(_cad1 == _usd, _cad1.Equals(_usd));
         Assert.AreEqual(_cad2 == _usd, _cad2.Equals(_usd));
         Assert.AreEqual(_cad3 == _usd, _cad3.Equals(_usd));
      }
      [Test]
      public void EqualsNotEqualToOtherObjectType()
      {
         Assert.IsFalse(_cad1.Equals("Some string"));
      }
      [Test]
      public void EqualsNull()
      {
         Assert.IsFalse(_cad1.Equals(null));
      }
      [Test]
      public void EqualsOperator()
      {
         Assert.IsFalse(_cad1 == _usd);
         Assert.IsTrue(_cad1 == _cad2);
         Assert.IsFalse(_cad1 == _cad3);
      }
      [Test]
      public void Exchange()
      {
         var exchangeRate = 1.12565m;
         Money usDollars = new Money(50m, "en-us");
         Money convertedCanadianDollars = new Money(usDollars.Amount * 1.12565m, "en-CA");
         Assert.AreEqual(50 * 1.12565m, convertedCanadianDollars.Amount);
      }
      [Test]
      public void GreaterThanOrEqualTo()
      {
         Money comparator = new Money(500);
         Money greaterThan = new Money(600);
         Money lessThan = new Money(400);
         Money equalTo = new Money(500);
         Assert.IsFalse(comparator >= greaterThan, "Comparator compared to Greater Than");
         Assert.IsTrue(comparator >= equalTo, "Comparator compared to Equal To");
         Assert.IsTrue(comparator >= lessThan, "Comparator compared to Less Than");
      }
      [Test]
      public void GreaterThanSameCurrencies()
      {
         Assert.IsTrue(_cad3 > _cad1);
         Assert.IsFalse(_cad1 > _cad3);
      }
      [Test]
      public void HashCode()
      {
         Assert.AreEqual(_cad1.GetHashCode(), _cad2.GetHashCode());
      }
      [Test]
      public void LessThanOrEqualTo()
      {
         Money comparator = new Money(500);
         Money greaterThan = new Money(600);
         Money lessThan = new Money(400);
         Money equalTo = new Money(500);
         Assert.IsTrue(comparator <= greaterThan, "Comparator compared to Greater Than");
         Assert.IsTrue(comparator <= equalTo, "Comparator compared to Equal To");
         Assert.IsFalse(comparator <= lessThan, "Comparator compared to Less Than");
      }
      [Test]
      public void LessThanSameCurrencies()
      {
         Assert.IsTrue(_cad1 < _cad3);
         Assert.IsFalse(_cad3 < _cad1);
      }
      [Test]
      public void LocalCurrencyTest()
      {
         Assert.AreEqual(new Money(), Money.LocalCurrency);
      }
      [Test]
      public void MultiplicationMethod()
      {
         Money result = Money.Multiply(_cad3, 4);
         Assert.AreEqual(60m, result.Amount);
      }
      [Test]
      public void MultiplicationOperator()
      {
         Money result = _cad3 * 4;
         Assert.AreEqual(60m, result.Amount);
      }
      [Test]
      public void NotEqualOperator()
      {
         Assert.IsFalse(_cad1 != _cad2);
         Assert.IsTrue(_cad3 != _cad2);
         Assert.IsTrue(_cad1 != _cad3);
      }
      [Test]
      public void NotEqualsOperator()
      {
         Assert.IsTrue(_cad1 != _usd);
         Assert.IsFalse(_cad1 != _cad2);
         Assert.IsTrue(_cad1 != _cad3);
      }
      [Test]
      public void SubtractingSameCurrenciesSubtractMethod()
      {
         Money result = Money.Subtract(_cad3, _cad1);
         Assert.AreEqual(15m, result.Amount);

         result = Money.Subtract(_cad1, _cad3);
         Assert.AreEqual(-15m, result.Amount);
      }
      [Test]
      public void SubtractingSameCurrenciesSubtractOperator()
      {
         Money result = _cad3 - _cad1;
         Assert.AreEqual(15m, result.Amount);

         result = _cad1 - _cad3;
         Assert.AreEqual(-15m, result.Amount);
      }
      [Test]
      public void ToStringPassingFormat()
      {
         Assert.AreEqual("15.00000", _cad3.ToString("N5"));
      }
      [Test]
      public void ToStringTest()
      {
         Assert.AreEqual("$0.00", _cad1.ToString(), "Zero CAD");
         Assert.AreEqual("$15.00", _cad3.ToString(), "15 CAD");
         Assert.AreEqual("£2.00", new Money(2, "en-GB").ToString(), "2 BPS");
      }
   }
}