namespace StructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // timeS in this example is a 'struct'
            // and will be COPIED to the method UpdateTime()
            TimeStruct timeS = new TimeStruct();
            timeS.Seconds = 10;
            UpdateTime(timeS);

            // timeC in this example is a 'class'
            // and a REFERENCE will be sent to the method UpdateTime()
            TimeStruct timeC = new TimeStruct();
            timeC.Seconds = 20;
            UpdateTime(timeC);
        }

        public static void UpdateTime(TimeStruct time)
        {
            time.Seconds++;
        }

    }
}