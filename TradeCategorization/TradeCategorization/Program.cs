using TradeCategorization.Model.Helper;
using TradeCategorization.Model.Enum;
using TradeCategorization.Model;
using System.Globalization;

string format = "MM/dd/yyyy";
CultureInfo provider = CultureInfo.InvariantCulture;

string referenceDateInput;
DateTime referenceDate;

int iteration;

double value;
string clientSector;
string nextPaymentDateInput;
DateTime nextPaymentDate;

int index;
List<Trade> trades = new List<Trade>();

referenceDateInput = Console.ReadLine();
referenceDate = DateTime.ParseExact(referenceDateInput, format, provider);


iteration = Convert.ToInt32(Console.ReadLine());
index = iteration;

while (index > 0)
{
    index--;

    string[] info = Console.ReadLine().Split();
    value = Convert.ToDouble(info[0]);
    clientSector = info[1];
    nextPaymentDateInput = info[2];

    nextPaymentDate = DateTime.ParseExact(nextPaymentDateInput, format, provider);

    trades.Add(new Trade(value, clientSector, nextPaymentDate, referenceDate));
}

Console.WriteLine();
foreach (Trade trade in trades)
{
    var categoryDisplayName = EnumHelper<Category>.GetDisplayValue(trade.Category);
    Console.WriteLine(categoryDisplayName);
}