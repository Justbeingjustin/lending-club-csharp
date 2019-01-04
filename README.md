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
||Summary|**No**|
||Available Cash|**No**|
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


## Contributing

Pull requests are welcome. 

For large changes, please open an issue first to discuss what you would like to add.
