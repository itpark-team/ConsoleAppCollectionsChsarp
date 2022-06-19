namespace ConsoleAppCollections
{
    public class Cat
    {
        private int _age;
        private string _name;

        public Cat(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public int Age
        {
            get { return _age; }
        }

        public string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return $"{_name}, {_age}";
        }
    }
}