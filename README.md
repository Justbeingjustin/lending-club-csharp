# lending-club-csharp
LendingClub is a US peer-to-peer lending company. Historically, only banks and large institutions could invest in consumer credit. With LendingClub, you can get new access to an asset class that institutions have enjoyed for decades, diversify your portfolio, and potentially earn competitive returns. This library aims to easily provide lending club services using the C# language.

### Table of Contents
**[Available For](#available-for)**<br>
**[Nuget](#nuget)**<br>
**[Supported Features](#supported-features)**<br>
**[Usage](#usage)**<br>
**[Contributing](#contributing)**<br>


## Available For
- .NET Standard 2.0
- .NET 4.6.1
- .NET 4.5


## Nuget

 ```
    PM> Install-Package lending-club-csharp
```
[![](https://img.shields.io/nuget/v/lending-club-csharp.svg)](https://www.nuget.org/packages/lending-club-csharp/)\
[![](https://img.shields.io/nuget/dt/lending-club-csharp.svg)](https://www.nuget.org/packages/lending-club-csharp/)

## Supported Features
|Resource|Feature|Supported|
|------|--------------|-------------|
|Account|||
||Summary|**Yes**|
||Available Cash|**Yes**|
||Transfer Funds|**Yes**|
||Pending Transfers|**Yes**|
||Cancel Transfers|**Yes**|
||Notes Owned|**Yes**|
||Detailed Notes Owned|**Yes**|
||Portfolios Owned|**Yes**|
||Create Portfolio|**Yes**|
||Submit Order|**Yes**|
|Loan|||
||Loan Listing|**Yes**|



## Usage
The API_KEY can be obtained on the settings page on the LendingClub website when the user is logged in. Also, the Investor_Id can be found in the Account Summary section on the LendingClub website. 

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

### Submit Orders
This allows investors to submit a new order for one or more loans.
```
using LendingClub.Models;
using LendingClub.Services;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY", "Investor_Id");
            accountRepository.SubmitOrder(new OrderRequest()
            {
                orders = new List<Order>() {
                     new Order(){
                          loanId=1, // comes from get GetLoans() call from loansRepository
                          portfolioId=1, // comes from GetPortfolios() call
                          requestedAmount=25
                     }
                }
            });
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
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var accountSummary = accountRepository.GetAccountSummary();
        }
    }
}
```


### Transfer Funds
This enables a user to add funds to the investor's account.
```
using LendingClub.Models;
using LendingClub.Services;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            
            // now
            var addFundsNowReceipt = accountRepository.AddFundsNow(new AddFundsNowRequest()
            {
                amount = 1,
            });
           
           // once
            var addFundsOnceReceipt = accountRepository.AddFundsOnce(new AddFundsOnceRequest()
            {
                amount = 1,
                startDate = DateTime.Now.AddDays(1)
            });
            
            // monthly
            var addFundsMonthlyReceipt = accountRepository.AddFundsMonthly(new AddFundsMonthlyRequest()
            {
                amount = 1,
                startDate = DateTime.Now.AddDays(1),
                endDate = DateTime.Now.AddMonths(2)
            });

            // bi-weekly
            var addFundsBiWeeklyReceipt = accountRepository.AddFundsBiWeekly(new AddFundsBiWeeklyRequest()
            {
                amount = 1,
                startDate = DateTime.Now,
                endDate = DateTime.Now.AddDays(35)
            });

            // weekly
            var addFundsWeeklyReceipt = accountRepository.AddFundsWeekly(new AddFundsWeeklyRequest()
            {
                amount = 1,
                startDate = DateTime.Now,
                endDate = DateTime.Now.AddDays(28)
            });
        }
    }
}
```



### Pending Transfers
This enables users to find pending fund transfers for the investor's account.
```
using LendingClub.Services;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var pendingTransfers = accountRepository.GetPendingTransfers();
        }
    }
}
```


### Cancel Transfers
This enables user to cancel the funds transfer initiated.
```
using LendingClub.Models;
using LendingClub.Services;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var transferId = 1111; // this value comes from the GetPendingTransfers() call
            var cancelTransferReceipt = accountRepository.CancelTransfers(new CancelTransfersRequest()
            {
                transferIds = new List<int>() {
                     transferId
                 }
            });
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
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var availableCash = accountRepository.GetAvailableCash();
        }
    }
}
```

### Notes Owned
This subresource provides a list of notes that are owned by the investor.
```
using LendingClub.Services;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var notes = accountRepository.GetNotes();
        }
    }
}
```

### Detailed Notes Owned
This subresource provides a list of notes that are owned by the investor. In addition to the data provided by the Owned Notes resource, this one adds financial information regarding the notes.
```
using LendingClub.Services;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var detailednotes = accountRepository.GetDetailedNotes();
        }
    }
}
```


### Portfolios Owned
This provides a list of all portfolios that are owned by the investor.

```
using LendingClub.Services;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var portfolios = accountRepository.GetPortfolios();
        }
    }
}
```


### Create Portfolio
This allows investors to create a new portfolio.
```
using LendingClub.Models;
using LendingClub.Services;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository("API_KEY","Investor_Id");
            var createdPortfolio = accountRepository.CreatePortfolio(new CreatePortfolioRequest()
            {
                PortfolioName = "NameOfPortfolio",
                PortfolioDescription = "DescriptionOfPortfolio"
            });
        }
    }
}
```








## Contributing

Pull requests are welcome. 

For large changes, please open an issue first to discuss what you would like to add.
