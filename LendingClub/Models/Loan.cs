using System;

namespace LendingClub.Models
{
    public class Loan
    {
        /// <summary>
        /// A unique LC assigned ID for the loan listing.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// A unique LC assigned Id for the borrower member.
        /// </summary>
        public int memberId { get; set; }

        /// <summary>
        /// The listed amount of the loan applied for by the borrower. If at some point in time, the credit department reduces the loan amount, then it will be reflected in this value.
        /// </summary>
        public decimal loanAmount { get; set; }

        /// <summary>
        /// The total amount funded by investors for that loan at that point in time.
        /// </summary>
        public decimal fundedAmount { get; set; }

        /// <summary>
        /// The Number of payments on the loan. Values are in months and can be either 36 or 60.
        /// </summary>
        public int term { get; set; }

        /// <summary>
        /// Interest Rate on the loan
        /// </summary>
        public decimal intRate { get; set; }

        /// <summary>
        /// The expected default rate of the loan.
        /// </summary>
        public decimal expDefaultRate { get; set; }

        /// <summary>
        /// Service fee rate paid by the investor for this loan.
        /// </summary>
        public decimal serviceFeeRate { get; set; }

        /// <summary>
        /// The monthly payment owed by the borrower if the loan originates.
        /// </summary>
        public decimal installment { get; set; }

        /// <summary>
        /// LC assigned loan grade
        /// </summary>
        public string grade { get; set; }

        /// <summary>
        /// LC assigned loan subgrade
        /// </summary>
        public string subGrade { get; set; }

        /// <summary>
        /// Employment length in months. Possible values are whole numbers from 0 and higher. Null indicates not employed.
        /// </summary>
        public int? empLength { get; set; }

        /// <summary>
        /// The home ownership status provided by the borrower during registration or obtained from the credit report. Our values are: RENT, OWN, MORTGAGE, OTHER
        /// </summary>
        public string homeOwnership { get; set; }

        /// <summary>
        /// The annual income provided by the borrower during registration.
        /// </summary>
        public decimal? annualInc { get; set; }

        /// <summary>
        /// Indicates if income is verified by LC
        /// </summary>
        public string isIncV { get; set; }

        /// <summary>
        /// The date which the borrower accepted the offer
        /// </summary>
        public DateTime acceptD { get; set; }

        /// <summary>
        /// The date the listing will expire
        /// </summary>
        public DateTime expD { get; set; }

        /// <summary>
        /// The date which the borrower's application was listed on the platform.
        /// </summary>
        public DateTime listD { get; set; }

        /// <summary>
        /// The date LC pulled credit for this loan
        /// </summary>
        public DateTime creditPullD { get; set; }

        /// <summary>
        /// The date the loan application was reviewed by LC
        /// </summary>
        public DateTime? reviewStatusD { get; set; }

        /// <summary>
        /// The status of the loan during the listing period. Values: APPROVED, NOT_APPROVED.
        /// </summary>
        public string reviewStatus { get; set; }

        /// <summary>
        /// Loan description provided by the borrower
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// A category provided by the borrower for the loan request. Values are: debt_consolidation, medical, home_improvement, renewable_energy, small_business, wedding, vacation, moving, house, car, major_purchase, credit_card, other
        /// </summary>
        public string purpose { get; set; }

        /// <summary>
        /// The first 3 numbers of the ZIP code provided by the borrower in the loan application.
        /// </summary>
        public string addrZip { get; set; }

        /// <summary>
        /// The address state provided by the borrower during loan application
        /// </summary>
        public string addrState { get; set; }

        /// <summary>
        /// The number of investor members who have purchased notes from this loan
        /// </summary>
        public string investorCount { get; set; }

        /// <summary>
        /// The date and time when the loan will no longer be in the initial listing status. After this date is past, the initialListStatus below will not have any effect and the loan will be treated as a FRACTIONAL loan.
        /// </summary>
        public DateTime? ilsExpD { get; set; }

        /// <summary>
        /// The initial listing status of the loan. Possible values are W, F.
        /// </summary>
        public string initialListStatus { get; set; }

        /// <summary>
        /// Employment title
        /// </summary>
        public string empTitle { get; set; }

        /// <summary>
        /// The Number of accounts on which the borrower is now delinquent.
        /// </summary>
        public string accNowDelinq { get; set; }

        /// <summary>
        /// Number of trades opened in past 24 months.
        /// </summary>
        public int? accOpenPast24Mths { get; set; }

        /// <summary>
        /// Total open to buy on revolving bankcards.
        /// </summary>
        public int? bcOpenToBuy { get; set; }

        /// <summary>
        /// Percentage of all bankcard accounts > 75% of limit.
        /// </summary>
        public decimal? percentBcGt75 { get; set; }

        /// <summary>
        /// Ratio of total current balance to high credit/credit limit for all bankcard accounts.
        /// </summary>
        public decimal? bcUtil { get; set; }

        /// <summary>
        /// The borrower's debt to income ratio, calculated using the monthly payments on the total debt obligations, excluding mortgage, divided by self-reported monthly income.
        /// </summary>
        public decimal? dti { get; set; }

        /// <summary>
        /// The Number of 30+ days past-due incidences of delinquency in the borrower's credit file for the past 2 years.
        /// </summary>
        public int? delinq2Yrs { get; set; }

        /// <summary>
        /// The past-due amount owed for the accounts on which the borrower is now delinquent.
        /// </summary>
        public decimal? delinqAmnt { get; set; }

        /// <summary>
        /// The date the borrower's earliest reported credit line was opened
        /// </summary>
        public DateTime? earliestCrLine { get; set; }

        /// <summary>
        /// The lower boundary of range the borrower's FICO belongs to.
        /// </summary>
        public int? ficoRangeLow { get; set; }

        /// <summary>
        /// The upper boundary of range the borrower's FICO belongs to.
        /// </summary>
        public int? ficoRangeHigh { get; set; }

        /// <summary>
        /// The Number of inquiries by creditors during the past 6 months.
        /// </summary>
        public int? inqLast6Mths { get; set; }

        /// <summary>
        /// The Number of months since the borrower's last delinquency.
        /// </summary>
        public int? mthsSinceLastDelinq { get; set; }

        /// <summary>
        /// The Number of months since the last public record.
        /// </summary>
        public int? mthsSinceLastRecord { get; set; }

        /// <summary>
        /// Months since most recent inquiry.
        /// </summary>
        public int? mthsSinceRecentInq { get; set; }

        /// <summary>
        /// Months since most recent revolving delinquency.
        /// </summary>
        public int? mthsSinceRecentRevolDelinq { get; set; }

        /// <summary>
        /// Months since most recent bankcard account opened.
        /// </summary>
        public int? mthsSinceRecentBc { get; set; }

        /// <summary>
        /// Number of mortgage accounts.
        /// </summary>
        public int? mortAcc { get; set; }

        /// <summary>
        /// The Number of open credit lines in the borrower's credit file.
        /// </summary>
        public int? openAcc { get; set; }

        /// <summary>
        /// Number of derogatory public records.
        /// </summary>
        public int? pubRec { get; set; }

        /// <summary>
        /// Total credit balance excluding mortgage.
        /// </summary>
        public int? totalBalExMort { get; set; }

        /// <summary>
        /// Total credit revolving balance.
        /// </summary>
        public decimal? revolBal { get; set; }

        /// <summary>
        /// Revolving line utilization rate, or the amount of credit the borrower is using relative to all available revolving credit.
        /// </summary>
        public decimal? revolUtil { get; set; }

        /// <summary>
        /// Total bankcard high credit/credit limit.
        /// </summary>
        public int? totalBcLimit { get; set; }

        /// <summary>
        /// The total Number of credit lines currently in the borrower's credit file
        /// </summary>
        public int? totalAcc { get; set; }

        /// <summary>
        /// Total installment high credit/credit limit
        /// </summary>
        public int? totalIlHighCreditLimit { get; set; }

        /// <summary>
        /// Number of revolving accounts
        /// </summary>
        public int? numRevAccts { get; set; }

        /// <summary>
        /// Months since most recent bankcard delinquency.
        /// </summary>
        public int? mthsSinceRecentBcDlq { get; set; }

        /// <summary>
        /// Number of public record bankruptcies.
        /// </summary>
        public int? pubRecBankruptcies { get; set; }

        /// <summary>
        /// Number of accounts ever 120 or more days past due.
        /// </summary>
        public int? numAcctsEver120Ppd { get; set; }

        /// <summary>
        /// Number of charge-offs within 12 months.
        /// </summary>
        public int? chargeoffWithin12Mths { get; set; }

        /// <summary>
        /// Number of collections in 12 months excluding medical collections.
        /// </summary>
        public int? collections12MthsExMed { get; set; }

        /// <summary>
        /// Number of tax liens
        /// </summary>
        public int? taxLiens { get; set; }

        /// <summary>
        /// Months since most recent 90-day or worse rating.
        /// </summary>
        public int? mthsSinceLastMajorDerog { get; set; }

        /// <summary>
        /// Number of satisfactory accounts
        /// </summary>
        public int? numSats { get; set; }

        /// <summary>
        /// Number of accounts opened in past 12 months
        /// </summary>
        public int? numTlOpPast12m { get; set; }

        /// <summary>
        /// Months since most recent account opened
        /// </summary>
        public int? moSinRcntTl { get; set; }

        /// <summary>
        /// Total high credit/credit limit
        /// </summary>
        public int? totHiCredLim { get; set; }

        /// <summary>
        /// Total current balance of all accounts
        /// </summary>
        public int? totCurBal { get; set; }

        /// <summary>
        /// Average current balance of all accounts
        /// </summary>
        public int? avgCurBal { get; set; }

        /// <summary>
        /// Number of bankcard accounts
        /// </summary>
        public int? numBcTl { get; set; }

        /// <summary>
        /// Number of currently active bankcard accounts
        /// </summary>
        public int? numActvBcTl { get; set; }

        /// <summary>
        /// Number of satisfactory bankcard accounts
        /// </summary>
        public int? numBcSats { get; set; }

        /// <summary>
        /// Percent of trades never delinquent
        /// </summary>
        public int? pctTlNvrDlq { get; set; }

        /// <summary>
        /// Number of accounts 90 or more days past due in last 24 months
        /// </summary>
        public int? numTl90gDpd24m { get; set; }

        /// <summary>
        /// Number of accounts currently 30 days past due (updated in past 2 months)
        /// </summary>
        public int? numTl30dpd { get; set; }

        /// <summary>
        /// Number of accounts currently 120 days past due (updated in past 2 months)
        /// </summary>
        public int? numTl120dpd2m { get; set; }

        /// <summary>
        /// Number of installment accounts
        /// </summary>
        public int? numIlTl { get; set; }

        /// <summary>
        /// Months since oldest installment account opened
        /// </summary>
        public int? moSinOldIlAcct { get; set; }

        /// <summary>
        /// Number of currently active revolving trades
        /// </summary>
        public int? numActvRevTl { get; set; }

        /// <summary>
        /// Months since oldest revolving account opened
        /// </summary>
        public int? moSinOldRevTlOp { get; set; }

        /// <summary>
        /// Months since most recent revolving account opened
        /// </summary>
        public int? moSinRcntRevTlOp { get; set; }

        /// <summary>
        /// Total revolving high credit/credit limit
        /// </summary>
        public int? totalRevHiLim { get; set; }

        /// <summary>
        /// Number of revolving trades with balance > 0
        /// </summary>
        public int? numRevTlBalGt0 { get; set; }

        /// <summary>
        /// Number of open revolving accounts
        /// </summary>
        public int? numOpRevTl { get; set; }

        /// <summary>
        /// Total collection amounts ever owed
        /// </summary>
        public int? totCollAmt { get; set; }

        /// <summary>
        /// The loan application type. Valid values are "INDIVIDUAL" or "JOINT".
        /// </summary>
        public string applicationType { get; set; }

        /// <summary>
        /// The joint annual income if the applicationType is "JOINT".
        /// </summary>
        public decimal? annualIncJoint { get; set; }

        /// <summary>
        /// The joint debt to joint income ratio. This field is populated if the applicationType is "JOINT". Calculated using the monthly payments on the total debt obligations, excluding mortgage, divided by self-reported monthly income.
        /// </summary>
        public decimal? dtiJoint { get; set; }

        /// <summary>
        /// Indicates if joint income is verified by LC. Valid values are NOT_VERIFIED,SOURCE_VERIFIED and VERIFIED.
        /// </summary>
        public string isIncVJoint { get; set; }

        /// <summary>
        /// Number of open trades in last 6 months.
        /// </summary>
        public int? openAcc6m { get; set; }

        /// <summary>
        /// Number of currently active installment trades. This field is a replacement field for openIl6m
        /// </summary>
        public int? openActIl { get; set; }

        /// <summary>
        /// Number of installment accounts opened in past 12 months.
        /// </summary>
        public int? openIl12m { get; set; }

        /// <summary>
        /// Number of installment accounts opened in past 24 months.
        /// </summary>
        public int? openIl24m { get; set; }

        /// <summary>
        /// Months since most recent installment accounts opened.
        /// </summary>
        public int? mthsSinceRcntIl { get; set; }

        /// <summary>
        /// Total current balance of all installment accounts.
        /// </summary>
        public decimal? totalBalIl { get; set; }

        /// <summary>
        /// Ratio of total current balance to high credit/credit limit on all install acct.
        /// </summary>
        public decimal? iLUtil { get; set; }

        /// <summary>
        /// Number of revolving trades opened in past 12 months.
        /// </summary>
        public int? openRv12m { get; set; }

        /// <summary>
        /// Number of revolving trades opened in past 24 months.
        /// </summary>
        public int? openRv24m { get; set; }

        /// <summary>
        /// Maximum current balance owed on all revolving accounts.
        /// </summary>
        public decimal? maxBalBc { get; set; }

        /// <summary>
        /// Balance to credit limit on all trades.
        /// </summary>
        public decimal? allUtil { get; set; }

        /// <summary>
        /// Number of personal finance inquiries.
        /// </summary>
        public int? inqFi { get; set; }

        /// <summary>
        /// Number of credit union trades.
        /// </summary>
        public int? totalCuTl { get; set; }

        /// <summary>
        /// Number of credit inquiries in past 12 months.
        /// </summary>
        public int? inqLast12m { get; set; }

        /// <summary>
        /// Monthly mortgage amount.
        /// </summary>
        public decimal? mtgPayment { get; set; }

        /// <summary>
        /// Borrower stated housing payment on loan application.
        /// </summary>
        public decimal? housingPayment { get; set; }

        /// <summary>
        /// Sum of revolving credit balance of the co-borrowers, net of duplicate balances.
        /// </summary>
        public decimal? revolBalJoint { get; set; }

        /// <summary>
        /// FICO range (low) for the secondary applicant.
        /// </summary>
        public int? secAppFicoRangeLow { get; set; }

        /// <summary>
        /// FICO range (high) for the secondary applicant.
        /// </summary>
        public int? secAppFicoRangeHigh { get; set; }

        /// <summary>
        /// Earliest credit line at time of application for the secondary applicant.
        /// </summary>
        public DateTime? secAppEarliestCrLine { get; set; }

        /// <summary>
        /// Credit inquiries in the last 6 months at time of application for the secondary applicant.
        /// </summary>
        public int? secAppInqLast6Mths { get; set; }

        /// <summary>
        /// Number of mortgage accounts at time of application for the secondary applicant.
        /// </summary>
        public int? secAppMortAcc { get; set; }

        /// <summary>
        /// Number of open trades at time of application for the secondary applicant.
        /// </summary>
        public int? secAppOpenAcc { get; set; }

        /// <summary>
        /// Ratio of total current balance to high credit/credit limit for all revolving accounts.
        /// </summary>
        public decimal? secAppRevolUtil { get; set; }

        /// <summary>
        /// Number of currently active installment trades at time of application for the secondary applicant. This field is a replacement field for secAppOpenIl6m
        /// </summary>
        public int? secAppOpenActIl { get; set; }

        /// <summary>
        /// Number of revolving accounts at time of application for the secondary applicant.
        /// </summary>
        public int? secAppNumRevAccts { get; set; }

        /// <summary>
        /// Number of charge-offs within last 12 months at time of application for the secondary applicant.
        /// </summary>
        public int? secAppChargeoffWithin12Mths { get; set; }

        /// <summary>
        /// Number of collections within last 12 months excluding medical collections at time of application for the secondary applicant.
        /// </summary>
        public int? secAppCollections12MthsExMed { get; set; }

        /// <summary>
        /// Months since most recent 90-day or worse rating at time of application for the secondary applicant.
        /// </summary>
        public int? secAppMthsSinceLastMajorDerog { get; set; }

        /// <summary>
        /// It will indicate the loan disbursement method. Valid values are "DIRECT_PAY" or "CASH".
        /// </summary>
        public string disbursementMethod { get; set; }
    }
}