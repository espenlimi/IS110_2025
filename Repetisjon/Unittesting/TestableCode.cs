namespace Repetisjon.Unittesting
{
    public class TestableCode
    {
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
            new ExternalClass().ExternalMethod(value);
        }
    }

    public class ExternalClass
    {
        public void ExternalMethod(int value)
        {
            /// Simulerer en ekstern avhengighet
            // F.eks. en databaseoperasjon eller nettverkskall
            Console.WriteLine($"Ekstern metode kalt med verdi: {value}");
        }
    }
}
