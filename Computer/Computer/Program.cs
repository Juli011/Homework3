
using ComputerApp.Model;
using ComputerApp.Device;

Computer computer1 = new Computer();
computer1.SetDevice(new CPU(Manufactorer.Intel), 1);
computer1.SetDevice(new RAM(Manufactorer.Intel), 4);
computer1.SetDevice(new HardDisk(Manufactorer.Intel), 2);

Computer computer2 = new Computer();
computer2.SetDevice(new CPU(Manufactorer.AMD), 1);
computer2.SetDevice(new RAM(Manufactorer.AMD), 2);
computer2.SetDevice(new HardDisk(Manufactorer.AMD), 1);