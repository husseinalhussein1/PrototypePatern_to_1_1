namespace PrototypePatern
{
    interface Prototype1
    { }
    class ConcretePrototype1 : Prototype1
    {
        private int field1;
        public ConcretePrototype1()
        { }

        public ConcretePrototype1(int field1)
        {
            this.field1 = field1;
        }

        public ConcretePrototype1(Prototype1 prototype)
        {
            this.field1 = prototype.field1;
        }

        public ConcretePrototype1 Clone()
        {
            return new ConcretePrototype1(this);
        }

        public override string ToString()
        {
            return $" i={field1}  ";
        }
    }
    class SubClassPrototype1 : ConcretePrototype1
    {
        private int field2;

        public SubClassPrototype1()
        { }

        public SubClassPrototype1(int field2, int field1) : base(field1)
        {
            this.field2 = field2;
        }

        public SubClassPrototype1(Prototype1 prototype) : base(prototype)
        {
            this.field2 = prototype.field2;
        }
        public SubClassPrototype1 Clone()
        {
            return new SubClassPrototype1(this);
        }

        public override string ToString()
        {
            return base.ToString() + $"j={field2}";
        }
    }

}
