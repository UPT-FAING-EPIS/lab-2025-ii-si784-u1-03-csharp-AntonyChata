using Bank.WebApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.WebApi.Tests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }

    /// <summary>
/// Controla operaciones bancarias sobre cuentas.
/// </summary>
public class BankAccountService
{
    /// <summary>
    /// Deposita un monto en la cuenta indicada.
    /// </summary>
    /// <param name="accountId">Id de la cuenta destino.</param>
    /// <param name="amount">Monto a depositar (mayor a 0).</param>
    /// <returns>Saldo resultante.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Si amount ≤ 0.</exception>
    public decimal Deposit(string accountId, decimal amount) { ... }
}

}
