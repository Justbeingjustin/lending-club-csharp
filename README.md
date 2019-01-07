# lending-club-csharp

### Table of Contents
**[Available For](#available-for)**<br>
**[Nuget](#nuget)**<br>
**[Supported Features](#supported-features)**<br>
**[Useage](#useage)**<br>
**[Contributing](#contributing)**<br>


## Available For
- .NET Standard 2.0
- .NET 4.6.1
- .NET 4.5


## Nuget

 ```
    PM> Install-Package lending-club-csharp
```

## Supported Features
|Resource|Feature|Supported|
|------|--------------|-------------|
|Account|||
||Summary|**Yes**|
||Available Cash|**Yes**|
||Transfer Funds|**No**|
||Pending Transfers|**No**|
||Cancel Transfers|**No**|
||Notes Owned|**No**|
||Detailed Notes Owned|**No**|
||Portfolio Owned|**No**|
||Create Portfolio|**No**|
||Submit Order|**No**|
|Loan|||
||Loan Listing|**Yes**|



## Useage
The api key can be obtained on the settings page on the LendingClub website when the user is logged in. Also, the investorId can be found in the Account Summary section on the LendingClub website. 

### Loan Listing	
This provides the details of the loans currently listed on Lending Club. The list contains the same loans that an investor would see on the browse loans page on the Lending Club website.
```
using LendingClub.Services;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILoansRepository loansRepository = new LoansRepository("API_KEY");
            var loansContainer = loansRepository.GetLoans();

            foreach (var loan in loansContainer.loans)
            {
                Console.WriteLine(loan.loanAmount);
            }
            Console.ReadLine();
        }
    }
}
```

### Summary
This provides a summary of the investor's account.
```
using LendingClub.Services;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var accountSummary = accountRepository.GetAccountSummary();
        }
    }
}
```

### Available Cash
This provides the most up to date value of the cash available in the investor's account.
```
using LendingClub.Services;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var availableCash = accountRepository.GetAvailableCash();
        }
    }
}
```


## Contributing

Pull requests are welcome. 

For large changes, please open an issue first to discuss what you would like to add.
