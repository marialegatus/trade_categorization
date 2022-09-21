using TradeCategorization.Model.Enum;
using TradeCategorization.Model.Interface;

namespace TradeCategorization.Model
{
    public class Trade : ITrade
    {
        public Trade(double value, string clientSector, DateTime nextPaymentDate, DateTime referenceDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
            setCategory(referenceDate);
        }

        public double Value { get; private set; }
        public string ClientSector { get; private set; }
        public DateTime NextPaymentDate { get; private set; }
        public Category Category { get; private set; }


        public void setCategory(DateTime referenceDate)
        {
            if (NextPaymentDate.AddDays(30) <= referenceDate)
            {
                Category = Category.EXPIRED;
            }
            else
                if (Value > 1000000 && ClientSector.Equals("Private"))
            {
                Category = Category.HIGHRISK;
            }
            else
                if (Value > 1000000 && ClientSector.Equals("Public"))
            {
                Category = Category.MEDIUMRISK;
            }
        }
    }
}

