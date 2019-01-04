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

        public DateTime? reviewStatusD { get; set; }
        public string reviewStatus { get; set; }
        public string desc { get; set; }
        public string purpose { get; set; }
        public string addrZip { get; set; }
        public string addrState { get; set; }
        public string investorCount { get; set; }
        public DateTime? ilsExpD { get; set; }
        public string initialListStatus { get; set; }
        public string empTitle { get; set; }
        public string accNowDelinq { get; set; }
        public int? accOpenPast24Mths { get; set; }
        public int? bcOpenToBuy { get; set; }
        public decimal? percentBcGt75 { get; set; }
        public decimal? bcUtil { get; set; }
        public decimal? dti { get; set; }
        public int? delinq2Yrs { get; set; }
        public decimal? delinqAmnt { get; set; }
        public DateTime? earliestCrLine { get; set; }
        public int? ficoRangeLow { get; set; }
        public int? ficoRangeHigh { get; set; }
        public int? inqLast6Mths { get; set; }
        public int? mthsSinceLastDelinq { get; set; }
        public int? mthsSinceLastRecord { get; set; }
        public int? mthsSinceRecentInq { get; set; }
        public int? mthsSinceRecentRevolDelinq { get; set; }
        public int? mthsSinceRecentBc { get; set; }
        public int? mortAcc { get; set; }
        public int? openAcc { get; set; }
        public int? pubRec { get; set; }
        public int? totalBalExMort { get; set; }
        public decimal? revolBal { get; set; }
        public decimal? revolUtil { get; set; }
        public int? totalBcLimit { get; set; }
        public int? totalAcc { get; set; }
        public int? totalIlHighCreditLimit { get; set; }
        public int? numRevAccts { get; set; }
        public int? mthsSinceRecentBcDlq { get; set; }
        public int? pubRecBankruptcies { get; set; }
        public int? numAcctsEver120Ppd { get; set; }
        public int? chargeoffWithin12Mths { get; set; }
        public int? collections12MthsExMed { get; set; }
        public int? taxLiens { get; set; }
        public int? mthsSinceLastMajorDerog { get; set; }
        public int? numSats { get; set; }
        public int? numTlOpPast12m { get; set; }
        public int? moSinRcntTl { get; set; }
        public int? totHiCredLim { get; set; }
        public int? totCurBal { get; set; }
        public int? avgCurBal { get; set; }
        public int? numBcTl { get; set; }
        public int? numActvBcTl { get; set; }
        public int? numBcSats { get; set; }
        public int? pctTlNvrDlq { get; set; }
        public int? numTl90gDpd24m { get; set; }
        public int? numTl30dpd { get; set; }
        public int? numTl120dpd2m { get; set; }
        public int? numIlTl { get; set; }
        public int? moSinOldIlAcct { get; set; }
        public int? numActvRevTl { get; set; }
        public int? moSinOldRevTlOp { get; set; }
        public int? moSinRcntRevTlOp { get; set; }
        public int? totalRevHiLim { get; set; }
        public int? numRevTlBalGt0 { get; set; }
        public int? numOpRevTl { get; set; }
        public int? totCollAmt { get; set; }
        public string applicationType { get; set; }
        public decimal? annualIncJoint { get; set; }
        public decimal? dtiJoint { get; set; }
        public string isIncVJoint { get; set; }
        public int? openAcc6m { get; set; }
        public int? openActIl { get; set; }
        public int? openIl12m { get; set; }
        public int? openIl24m { get; set; }
        public int? mthsSinceRcntIl { get; set; }
        public decimal? totalBalIl { get; set; }
        public decimal? iLUtil { get; set; }
        public int? openRv12m { get; set; }
        public int? openRv24m { get; set; }
        public decimal? maxBalBc { get; set; }
        public decimal? allUtil { get; set; }
        public int? inqFi { get; set; }
        public int? totalCuTl { get; set; }
        public int? inqLast12m { get; set; }
        public decimal? mtgPayment { get; set; }
        public decimal? housingPayment { get; set; }
        public decimal? revolBalJoint { get; set; }
        public int? secAppFicoRangeLow { get; set; }
        public int? secAppFicoRangeHigh { get; set; }
        public DateTime? secAppEarliestCrLine { get; set; }
        public int? secAppInqLast6Mths { get; set; }
        public int? secAppMortAcc { get; set; }
        public int? secAppOpenAcc { get; set; }
        public decimal? secAppRevolUtil { get; set; }
        public int? secAppOpenActIl { get; set; }
        public int? secAppNumRevAccts { get; set; }
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