namespace RandomAccessibleMemory
{
    class Ram
    {
        int value;
        private int p;

        public Ram(int sizeOfRam)
        {
            this.SizeOfRam = sizeOfRam;
        }

        public Ram(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        int SizeOfRam { get; set; }

        public void SaveValue(int storeValue)
        {
            value = storeValue;
        }

        public int LoadValue()
        {
            return value;
        }
    }
}