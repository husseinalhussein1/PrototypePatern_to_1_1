namespace PrototypePatern
{
    interface Prototype
    {

    }
    class ConcretePrototype : Prototype
    {
        private int field1;
        public ConcretePrototype()
        {

        }

        public ConcretePrototype(int field1)
        {
            this.field1 = field1;
        }

        public ConcretePrototype(Prototype prototype)
        {
            ConcretePrototype concretePrototype = (ConcretePrototype)prototype;
            this.field1 = concretePrototype.field1;
        }

        public ConcretePrototype Clone()
        {
            return new ConcretePrototype(this);
        }

        public override string ToString()
        {
            return $" i={field1}  ";
        }
    }
    class SubClassPrototype : ConcretePrototype
    {
        private int field2;
        public SubClassPrototype Clone()
        {
            return new SubClassPrototype(this);
        }

        public SubClassPrototype()
        {

        }

        public SubClassPrototype(int field2, int field1) : base(field1)
        {
            this.field2 = field2;
        }

        public SubClassPrototype(Prototype prototype) : base(prototype)
        {
            SubClassPrototype subClassPrototype = (SubClassPrototype)prototype;
            this.field2 = subClassPrototype.field2;
        }

        public override string ToString()
        {
            return base.ToString() + $"j={field2}";
        }
    }

}
