namespace _02ClassHuman
{
    class Human
    {
        enum Sex { Male, Female };

        class Person
        {
            public Sex Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void CreatePerson(int uCN)
        {
            Person somePerson = new Person();
            somePerson.Age = uCN;
            
            if (uCN % 2 == 0)
            {
                somePerson.Name = "Big Bro";
                somePerson.Gender = Sex.Male;
            }
            else
            {
                somePerson.Name = "Hot chick";
                somePerson.Gender = Sex.Female;
            }
        }

    }
}
