namespace Repetisjon.Unittesting
{
    public class TestableCode
    {
        private readonly IExternalClass externalClass;

        public TestableCode(IExternalClass externalClass)
        {
            this.externalClass = externalClass;
        }
        public TestableCode()
        {
            externalClass = new ExternalClass();
        }
        public string State { get; private set; } = "Initial State";
        
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void SetState(string state)
        {
            State = state;
        }

        public void External(int value)
        { 
            externalClass.ExternalMethod(value);
        }

        public int Multiply(int a, int b)
        {
            return 50;
        }
    }

    public class ExternalClass : IExternalClass
    {
        public void ExternalMethod(int value)
        {
            /// Simulerer en ekstern avhengighet
            // F.eks. en databaseoperasjon eller nettverkskall
            Console.WriteLine($"Ekstern metode kalt med verdi: {value}");
        }
    }
}
