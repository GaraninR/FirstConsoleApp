// See https://aka.ms/new-console-template for more information

using FirstConsoleApp;

Console.WriteLine("========= WELCOME TO SALARY CALCULATOR =========");

static void printInfo(string? employeeFN, string? employeeLN, int totalFees, int salaryNetto)
{
    System.Console.WriteLine("Total fees: " + totalFees);
    System.Console.WriteLine("Your netto salary for " + employeeFN + " " + employeeLN + " " + " is " + salaryNetto);
}

// method for getting social insurance
static int getSocialInsurance(int income)
{
    int socialInsurance;
    if (income < 2000)
    {
        socialInsurance = 5;
    }
    else if (income >= 2000 && income < 5000)
    {
        socialInsurance = 10;
    }
    else
    {
        socialInsurance = 15;
    }

    return socialInsurance;
}

static int sumAllFees(int incomeTaxSum, int socialInsuranceSum, int additionalMedicalInsuranceSum, int pensionFundSum, int charityFeesSum)
{
    return incomeTaxSum + socialInsuranceSum + additionalMedicalInsuranceSum + pensionFundSum + charityFeesSum;
}

Console.WriteLine("Enter employee's first and last name: ");

String? employeeFNLN;


for (int i = 0; i < 3; i = i + 1)
{

    employeeFNLN = Console.ReadLine();

    string[] fnlnArr = employeeFNLN!.Split(" ");

    Console.WriteLine("Enter income: ");
    int startIncome = Convert.ToInt32(Console.ReadLine());

    Employee epl = new Employee(fnlnArr[0], fnlnArr[1], 7, 10);

    int income = epl.getIncomeSum(startIncome);

    int incomeTax;
    int socialInsurance;
    int additionalMedicalInsurance;
    int pensionFund;
    int charityFees;

    incomeTax = 5;
    socialInsurance = getSocialInsurance(income);

    additionalMedicalInsurance = 25;
    pensionFund = 2;
    charityFees = 1;

    int incomeTaxSum = income / 100 * incomeTax;
    int socialInsuranceSum = income / 100 * socialInsurance;
    int additionalMedicalInsuranceSum = income / 100 * additionalMedicalInsurance;
    int pensionFundSum = income / 100 * pensionFund;
    int charityFeesSum = income / 100 * charityFees;
    int totalFees = sumAllFees(incomeTaxSum, socialInsuranceSum,
                                additionalMedicalInsuranceSum,
                                pensionFundSum, charityFeesSum);

    int salaryNetto = income - totalFees;
    printInfo(epl.firstName, epl.lastName, totalFees, salaryNetto);
}

