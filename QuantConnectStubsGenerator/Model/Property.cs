namespace QuantConnectStubsGenerator.Model
{
    public class Property
    {
        public string Name { get; set; }
        public PythonType Type { get; set; }

        public bool ReadOnly { get; set; }
        public bool Static { get; set; }
        public bool Abstract { get; set; }

        public string Value { get; set; }

        public string Summary { get; set; }

        public Property(string name)
        {
            Name = name;
        }
    }
}