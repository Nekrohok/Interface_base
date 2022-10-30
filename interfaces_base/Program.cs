using Disks;
using outDevices;
using System.Threading;


internal class Program
{
    public class Comp
    {
        public int countDisk { get; set; }
        public int countPrintDevice { get; set; }
        private List<IPrintInformation> outDevices;
        private List<Disk> disks;
        public void AddDisk(Disk disk) => disks.Add(disk);
        public void RemoveDisk(Disk disk) => disks.Remove(disk);
        public void AddDevice(IPrintInformation device) => outDevices.Add(device);
        public bool CheckDisk(Disk disk) => disks.Contains(disk);
        public void InsertReject(Disk disk)
        {
            if (!disks.Contains(disk))
                disks.Add(disk);
            else
                disks.Remove(disk);
        }
        public Comp(List<Disk> disks, List<IPrintInformation> outputDevices)
        {
            this.disks = disks;
            this.outDevices = outDevices;
        }
        public void PrintInfo(string text, IPrintInformation outputDevice) => outputDevice.Print(text);
        public void ReadInfo(Disk disk) => disk.Read();
        public void ShowDisk() => disks.ForEach((i) => Console.WriteLine($"Memory: {i.Memory}\nMemory size: {i.MemSize}"));
        public void ShowOutputDevice() => outDevices.ForEach((i) => Console.WriteLine($"Name: {i.GetName}"));

    }
    private static void Main(string[] args)
    {
        
        DVD dvd = new DVD()
        {
            Memory = "As all Memoey...",
            MemSize = 5
        };
        HDD hdd = new HDD()
        {
            Memory = "Bool Type",
            MemSize = 250
        };
        Printer printer = new Printer();
        Monitors monitor = new Monitors();

        List<Disk> disks = new List<Disk>
        {
            hdd, dvd
        };
        List<IPrintInformation> outDevices = new List<IPrintInformation>
        {
            printer, monitor
        };

        Comp computer = new Comp(disks, outDevices);
        computer.PrintInfo("TEXT", outDevices[0]);
        computer.ShowDisk();
    }
}