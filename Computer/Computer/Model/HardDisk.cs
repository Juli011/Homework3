using ComputerApp.Device;
using ComputerApp.Interface;


namespace ComputerApp.Model
{
    internal class HardDisk : IComputerable, IHardDiskable
    {

        public HardDisk Remove()
        {
            return null;
        }

        public readonly Manufactorer hardDiskKind;
       
        public HardDisk(Manufactorer kind)
        {
            this.hardDiskKind = kind;
        }
    }
}
