namespace App
{
    class Program
    {
        static void Main()
        {

        }
    }

    //class OldMachine : IMachine_Bad
    //{
    //    public void Fax()
    //    {
    //        // so we must implement that interface although i really don't need it here  
    //        throw new NotImplementedException();
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine("Printing");
    //    }

    //    public void Scan()
    //    {
    //        Console.WriteLine("Scaning");
    //    }
    //}

    class OldMachine : IMachine_Better
    {
        public void Print()
        {
            Console.WriteLine("Printing........");
        }

        public void Scan()
        {
            Console.WriteLine("Scaning........");
        }
    }

    class NewMachine : INewMachine
    {
        public void Fax()
        {
            Console.WriteLine("Faxing........");
        }

        public void Print()
        {
            Console.WriteLine("Printing........");
        }

        public void Scan()
        {
            Console.WriteLine("Scaning........");
        }
    }

}