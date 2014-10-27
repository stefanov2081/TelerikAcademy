using System;

namespace ContrlStructuresAndCondtionalStatements
{
    class Chef
    {
        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException();

        }

        private Potato GetPotato()
        {
            throw new NotImplementedException();

        }

        private void Cut(Vegetable potato)
        {
            throw new NotImplementedException();
        }

        private void Cut(Carrot carrot)
        {
            throw new NotImplementedException();
        }

        private void Cut(Potato potato)
        {
            throw new NotImplementedException();
        }

        private void Peel(Carrot carrot)
        {
            throw new NotImplementedException();
        }

        private void Peel(Potato potato)
        {
            throw new NotImplementedException();
        }

        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }
    }
}
