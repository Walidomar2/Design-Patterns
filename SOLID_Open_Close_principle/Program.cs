namespace App
{
    public enum Color { Red, Green, Blue }
    public enum Size { Small, Medium, Large, Yuge }
    class Program
    {
        static void Main()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, Color.Green))
                Console.WriteLine($" - {p.Name} is green");

            Console.WriteLine("\n----------------------- Better Way ----------------------\n");
            var bf = new BetterFilter();
            Console.WriteLine("Green products: ");

            var GreenItems = bf.Filter(products, new ColorSpecification(Color.Green));
            foreach (var p in GreenItems)
                Console.WriteLine($" - {p.Name} is green");

            Console.WriteLine("Large products: ");
            var LargeItems = bf.Filter(products, new SizeSpecification(Size.Large));
            foreach (var p in LargeItems)
                Console.WriteLine($" - {p.Name} is large");

            Console.WriteLine("Large blue items: ");

            var LargeAndBlueItems = bf.Filter(products,
              new AndSpecification<Product>(new ColorSpecification(Color.Blue)
              , new SizeSpecification(Size.Large)));
            
            foreach (var p in LargeAndBlueItems)
            {
                Console.WriteLine($" - {p.Name} is big and blue");
            }

        }
    }

    // better way and make things Generic 
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }

    public interface IFilter<T>
    {
       IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Color == _color;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size _size;
        public SizeSpecification(Size size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Size == _size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first, _second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            _second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(Product p)
        {
            return _first.IsSatisfied(p) && _second.IsSatisfied(p);
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
                if (spec.IsSatisfied(i))
                    yield return i;
        }
    }

}