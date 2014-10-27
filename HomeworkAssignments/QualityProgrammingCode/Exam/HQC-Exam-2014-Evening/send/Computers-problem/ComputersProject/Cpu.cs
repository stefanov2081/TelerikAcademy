﻿namespace System
{
    using System;

    public class Cpu
    {
        private static readonly Random Random = new Random();
        private readonly byte numberOfBits;

        private readonly Ram ram;

        private readonly HardDrive videoCard;

        internal Cpu(byte numberOfCores, byte numberOfBits, Ram ram, HardDrive videoCard)
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        private byte NumberOfCores { get; set; }

        public void SquareNumber()
        {
            if (this.numberOfBits == 32)
            {
                this.SquareNumber32();
            }

            if (this.numberOfBits == 64)
            {
                this.SquareNumber64();
            }
        }

        internal void RandomMEthodWorthForNothingExceptSucking(int a, int b)
        {
            int randomNumber;

            do
            {
                randomNumber = Random.Next(1, 11);
            } 
            while (!(randomNumber >= a && randomNumber <= b));

            this.ram.SaveValue(randomNumber);
        }

        private void SquareNumber32()
        {
            int data = this.ram.LoadValue();

            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 500)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;

                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        private void SquareNumber64()
        {
            int data = this.ram.LoadValue();

            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 1000)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;

                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }
    }
}