using ComputerApp.Device;
using ComputerApp.Interface;


namespace ComputerApp.Model
{
    internal class Computer : IComputer, IDisposable
    {

        private List<RAM> RAMConnection = new List<RAM>(4);
        private List<HardDisk> HardDiskConnection = new List<HardDisk>(2);
        private CPU cpu = null;


        public bool SetDevice(IComputer computerable, uint amount)
        {
            if (computerable is CPU && cpu == null) cpu = computerable as CPU;

            else if (computerable is HardDisk && amount <= (HardDiskConnection.Capacity - HardDiskConnection.Where(p => p.Equals!=null).ToList().Count))
            {
                for (int i = 0; i<amount; i++)
                    HardDiskConnection.Add(computerable as HardDisk);
            }

            else if (computerable is RAM && amount <= (RAMConnection.Capacity - RAMConnection.Where(p => p.Equals!=null).ToList().Count))
            {
                for (int i = 0; i<amount; i++)
                    RAMConnection.Add(computerable as RAM);
            }

            else return false;

            return true;
        }
        
        private void RemoveDevice()
        {
            cpu = cpu.Unplug();
            foreach(RAM ram in RAMConnection) 
            {
                int index = RAMConnection.IndexOf(ram);
                RAMConnection[index]= ram.Eject();
            }
            foreach(HardDisk hd in HardDiskConnection)
            {
                int index = HardDiskConnection.IndexOf(hd);
                HardDiskConnection[index]= hd.Remove();
            }

        }
        public void Dispose()
        {
            RemoveDevice();
        }
        ~Computer()
        {
            RemoveDevice();
        }
    }
}
