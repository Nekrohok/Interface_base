using System;
namespace outDevices
{
	public interface IPrintInformation
	{
        public string GetName();
        public void Print(string str);
	}
	public class Printer :	IPrintInformation
	{
        public string GetName() => "Printer";
        public void Print(string str) => Console.WriteLine(str);


    }
    public class Monitors: IPrintInformation
    {
        public string GetName() => "Monitor";
        public void Print(string str) => Console.WriteLine(str);


    }
}