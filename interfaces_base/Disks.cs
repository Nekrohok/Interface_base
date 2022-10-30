using System;
namespace Disks
{
	public interface IRemoveableDisk
	{
		public bool HasDisk { get; }
		public void Insert();
		public void Reject();
	}
    public  interface IDisk
	{
        public void  Read();
        public void Write(string text);
	}
	public abstract class Disk : IDisk
	{
		public string memory;
		public int memSize;
		public string Memory { get; set; }
		public int MemSize { get; set; }
        public Disk()
        {
            memory = "SSD";
            memSize = 1024;
        }
        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
            Memory = memory;
            MemSize = memSize;
        }
		public abstract string GetName();
		public void Read() => Console.WriteLine("READING///");
		public void Write(string text) => Console.WriteLine($"Text \'{text}\' has been written!");
    }
	public class CD : Disk, IRemoveableDisk
	{
		public bool hasDisk;
		public bool HasDisk 
		{
			get => hasDisk; 
		}

        public override string GetName() => "CD";
        public void Insert() 
		{
			Console.WriteLine("Inserting..."); 
			hasDisk = true;
		}
		public void Reject()
		{
			Console.WriteLine("Disconnecting...");
			hasDisk = false;
		}
		public override string ToString()
		{
			if (hasDisk) {return "There is CD!";}
			else { return "No CD here!"; }
		}
	}
	public class Flash : Disk, IRemoveableDisk
	{
		public bool hasDisk;
		public bool HasDisk 
		{ 
			get => hasDisk; 
		}
        public override string GetName() => "Flash";
        public void Insert()
        {
            Console.WriteLine("Inserting...");
            hasDisk = true;
        }
        public void Reject()
        {
            Console.WriteLine("Disconnecting...");
            hasDisk = false;
        }
        public override string ToString()
        {
            if (hasDisk) { return "There is Flash!"; }
            else { return "No Flash here!"; }
        }
    }
	public class HDD : Disk { public override string GetName() => "HDD"; }
    public class DVD : Disk, IRemoveableDisk
    {
        public bool hasDisk;
        public bool HasDisk
        {
            get => hasDisk;
        }
        public override string GetName() => "DVD";
        public void Insert()
        {
            Console.WriteLine("Inserting...");
            hasDisk = true;
        }
        public void Reject()
        {
            Console.WriteLine("Disconnecting...");
            hasDisk = false;
        }
        public override string ToString()
        {
            if (hasDisk) { return "There is DVD!"; }
            else { return "No DVD here!"; }
        }

    }
}


