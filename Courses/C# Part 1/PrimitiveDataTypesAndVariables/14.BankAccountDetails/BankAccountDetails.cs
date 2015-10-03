using System;

/* 14.A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit 
 * card numbers associated with the account. Declare the variables needed to 
 * keep the information for a single bank account using the appropriate data types and descriptive names.
 */

class BankAccountDetails
{
    static void Main()
    {
        //String used as it is most suitable even for IBAN /contains both characters and numbers/ and BIC.
        string firstName, middleName, lastName, bankName, accountIBAN, accountBIC;
        //Decimal used as the bank accounts hold decimal numbers representing real money.
        decimal currentBalance;
        //Long type used as the length of the credit cards numbers usually is with up to 19 numbers.
        long creditCardMastercard, creditCardVISA, creditCardAmericanExpress;

        firstName = "John";
        middleName = "Doe";
        lastName = "Johnson";
        bankName = "BG BIG BANK";
        accountIBAN = "BG32 UBBS 7627 1413 6179 02";
        accountBIC = "BGBGBGSF";
        currentBalance = 1014.55m;
        creditCardMastercard = 4916366644852139;
        creditCardVISA = 5539580827348012;
        creditCardAmericanExpress = 6011668034094175;
        Console.WriteLine("Bank account holder: {0} {1} {2}\nIBAN: {3}\nBIC: {4}\nBANK: {5}\nCredit card number - Mastercard number: {6}\nCredit card number - VISA: {7}\nCredit card number American Express: {8}\nCurent balance: {9} BGN", firstName, middleName, lastName, accountIBAN, accountBIC, bankName, creditCardMastercard, creditCardVISA, creditCardAmericanExpress, currentBalance);
    }
}
