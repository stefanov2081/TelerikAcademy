namespace Computers.UI.Console
{
    using System;
    using System.Collections.Generic;

#warning "TELERIK LECTURERS SUCK BIG TIME!"

    internal class Computers
    {
        private const int Eight = 8;
        private const int TwoGigsOfRam = 2;
        private const int TwoTimesMoreGigsOfRamThanTwo = 4;
        private const int FourtyTwoMinusTen = 32; // Cuz 42 is the answer to the universe, live and everything else!
        private const int FourtyTwoMinusTenTimesTwo = 64;

        private static Computer pc;
        private static Computer laptop;
        private static Computer server;

        public enum Type
        {
            PC,
            LAPTOP,
            SERVER
        }

        public static void MainMotherFuckingMethod()
        {
            string manufacturer = System.Console.ReadLine();

            if (manufacturer == "HP")
            {
                var ram = new Ram(TwoGigsOfRam);
                var videoCard = new HardDrive { IsMonochrome = false };
                pc = new Computer(Type.PC, new Cpu(TwoGigsOfRam, FourtyTwoMinusTen, ram, videoCard), ram, new[] { new HardDrive(500, false, 0) }, videoCard, null);

                var serverRam = new Ram(FourtyTwoMinusTenTimesTwo);
                var serverVideo = new HardDrive();
                server = new Computer(Type.SERVER, new Cpu(TwoTimesMoreGigsOfRamThanTwo, FourtyTwoMinusTen, serverRam, serverVideo), serverRam, new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) }) }, serverVideo, null);
                {
                    var card = new HardDrive
                    {
                        IsMonochrome = false
                    };

                    var ram1 = new Ram(Eight / 2);
                    laptop = new Computer(Type.LAPTOP, new Cpu(TwoGigsOfRam, FourtyTwoMinusTenTimesTwo, ram1, card), ram1, new[] { new HardDrive(500, false, 0) }, card, new System.LaptopBattery());
                }
            }
            else if (manufacturer == "Dell")
            {
                var ram = new Ram(Eight);
                var videoCard = new HardDrive { IsMonochrome = false };
                pc = new Computer(Type.PC, new Cpu(TwoGigsOfRam, FourtyTwoMinusTenTimesTwo, ram, videoCard), ram, new[] { new HardDrive(1000, false, 0) }, videoCard, null);
                var ram1 = new Ram(Eight * Eight);
                var card = new HardDrive();
                server = new Computer(Type.SERVER, new Cpu(Eight, FourtyTwoMinusTenTimesTwo, ram1, card), ram1, new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(2000, false, 0), new HardDrive(2000, false, 0) }) }, card, null);
                var ram2 = new Ram(Eight);
                var videoCard1 = new HardDrive
                {
                    IsMonochrome = false
                };

                laptop = new Computer(Type.LAPTOP, new Cpu(TwoTimesMoreGigsOfRamThanTwo, FourtyTwoMinusTen, ram2, videoCard1), ram2, new[] { new HardDrive(1000, false, 0) }, videoCard1, new System.LaptopBattery());
            }
            else if (manufacturer == "Lenovo")
            {
                var ram = new Ram(TwoTimesMoreGigsOfRamThanTwo);
                var videoCard = new HardDrive { IsMonochrome = false };
                pc = new Computer(Type.PC, new Cpu(TwoGigsOfRam, FourtyTwoMinusTenTimesTwo, ram, videoCard), ram, new[] { new HardDrive(2000, false, 0) }, videoCard, null);
                var ram1 = new Ram(Eight);
                var hardCardDriveAdapterForVideCoolerStorageDeviceAntiCookieMonsterChaser = new HardDrive { IsMonochrome = true };
                server = new Computer(Type.SERVER, new Cpu(TwoGigsOfRam, (FourtyTwoMinusTenTimesTwo + FourtyTwoMinusTenTimesTwo), ram1, hardCardDriveAdapterForVideCoolerStorageDeviceAntiCookieMonsterChaser), ram1, new List<HardDrive> { new HardDrive(500, true, 2, new List<HardDrive> { new HardDrive(500, false, 0)}) }, hardCardDriveAdapterForVideCoolerStorageDeviceAntiCookieMonsterChaser, null);
                var ram2 = new Ram(Eight + Eight);
                var secondOfThisShitWithTheLongNameThatIAmNotGoingToTypeAgainNotToMissSpellItUnintentionaly = new HardDrive { IsMonochrome = false };
                laptop = new Computer(Type.LAPTOP, new Cpu(TwoGigsOfRam, FourtyTwoMinusTen, ram2, secondOfThisShitWithTheLongNameThatIAmNotGoingToTypeAgainNotToMissSpellItUnintentionaly), ram2, new[] { new HardDrive(1000, false, 0) }, secondOfThisShitWithTheLongNameThatIAmNotGoingToTypeAgainNotToMissSpellItUnintentionaly, new System.LaptopBattery());
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            while ("Doncho,Niki and Ivo Suck!" == "Doncho,Niki and Ivo Suck!")
            {
                string donchoNeMojeDaChete = System.Console.ReadLine();
                string[] nikiPomagaNaDonchoDaPro4eteKomandata = donchoNeMojeDaChete.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (donchoNeMojeDaChete == null)
                {
                    break;
                }

                if (donchoNeMojeDaChete.StartsWith("Exit"))
                {
                    break; // break IS goto, but in Telerik told us to pee on ourselves when we see GOTO...
                }

                if (nikiPomagaNaDonchoDaPro4eteKomandata.Length != 2)
                {
                    {
                        throw new InvalidArgumentException("Invalid command!");
                    }
                }

                var command = nikiPomagaNaDonchoDaPro4eteKomandata[0];
                var charge = int.Parse(nikiPomagaNaDonchoDaPro4eteKomandata[1]);

                if (command == "Charge")
                {
                    laptop.ChargeBattery(charge);
                }
                else if (command == "Process")
                {
                    server.Process(charge);
                }
                else if (command == "Play")
                {
                    pc.Play(charge);
                }
                else
                {
                    System.Console.WriteLine("Invalid command!");
                }
            }
        }

        

        private class Computer
        {
            private System.LaptopBattery battery;

            internal Computer(Type type, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, HardDrive videoCard, System.LaptopBattery battery)
            {
                Cpu = cpu;
                Ram = ram;
                this.HardDrives = hardDrives;
                this.VideoCard = videoCard;

                if (type == Type.SERVER)
                {
                    this.VideoCard.IsMonochrome = true;
                }

                this.battery = battery;
            }

            

            private IEnumerable<HardDrive> HardDrives { get; set; }

            private HardDrive VideoCard { get; set; }

            private Cpu Cpu { get; set; }

            private Ram Ram { get; set; }

            [Obsolete("")]

            public void Play(int guessNumber)
            {
                Cpu.RandomMEthodWorthForNothingExceptSucking(1, 10);
                int number = Ram.LoadValue();
                if (number + 1 != guessNumber + 1)
                {
                    this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
                }
                else
                {
                    this.VideoCard.Draw("You win!");
                }
            }

            internal void ChargeBattery(int percentage)
            {
                this.battery.Charge(percentage);

                this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.Percentage));
            }

            internal void Process(int data)
            {
                Ram.SaveValue(data);
                //// TODO: Fix it
                Cpu.SquareNumber();
            }
        }
    }
}