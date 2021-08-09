using System;
using System.Collections.Generic;
namespace FullDemo
{
    // Supersophisticated Customer-Friendly Cake Management System
    class Cake
    {
        // Here are the private members
        private string pKind; // Kind of cake (e.g. Shortbread, Poundcake, Carrotcake, etc.)
        private int pLayers;  // How many layers the cake will have
        private string pFlavor; // The flavor of the cake itself
        private string pFrosting; // Color of the frosting
        // Here are the constructors. We have two: The default and one that takes all four members
        public Cake() // We call this one the default constructor.
        {
            // This is the default constructor
            pKind = "Poundcake";
            pLayers = 1;
            pFlavor = "Chocolate";
            pFrosting = "Chocolate";
        }
        public Cake(string _Kind, int _Layers, string _Flavor, string _Frosting)
        {
            // Instead of saving directly into the private variables,
            // let's call our setter functions. When we're inside a member function
            // we don't need to specify an object (e.g. c1.SetKind("...")). We just
            // call the function directly (e.g. SetKind("..."))
            SetKind(_Kind);
            SetLayers(_Layers);
            SetFlavor(_Flavor);
            SetFrosting(_Frosting);
        }
        // Here are the getters and setters
        public string GetKind()
        {
            return pKind;
        }
        public void SetKind(string _Kind)
        {
            pKind = _Kind;
        }
        public int GetLayers()
        {
            return pLayers;
        }
        public void SetLayers(int _Layers)
        {
            if (_Layers < 1)
            {
                _Layers = 1;
            }
            if (_Layers > 6)
            {
                _Layers = 6;
            }
            pLayers = _Layers;
        }
        public string GetFlavor()
        {
            return pFlavor;
        }
        public void SetFlavor(string _Flavor)
        {
            // This is how you validate what was passed in.
            // Chocolate, Vanilla, Yellow, Red Velvet
            if (_Flavor != "Chocolate" && _Flavor != "Vanilla" && _Flavor != "Yellow" && _Flavor != "Red Velvet")
            {
                _Flavor = "Chocolate";
            }
            pFlavor = _Flavor;
        }
        public string GetFrosting()
        {
            return pFrosting;
        }
        public void SetFrosting(string _Frosting)
        {
            pFrosting = _Frosting;
        }
        public override string ToString()
        {
            return $"{pKind} {pLayers} {pFlavor} {pFrosting}";
        }
    }
    class Program
    {
        static void ListCakes(List<Cake> cakelist)
        {
            foreach (Cake next in cakelist)
            {
                Console.WriteLine(next);
            }
        }
        static Cake SearchForCake(List<Cake> cakelist, string _Kind)
        {
            foreach (Cake next in cakelist)
            {
                if (next.GetKind() == _Kind)
                {
                    return next;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            // Test code
            // Really this entire Main() is filled with only test code.
            // We're commenting this out, but keeping it in case we need it later.
            //
            //Cake c1 = new Cake();
            //c1.SetKind("Poundcake");
            //c1.SetLayers(7);
            //c1.SetFlavor("Strawberry");
            //c1.SetFrosting("Chocolate");
            //Console.WriteLine($"{c1.GetKind()} {c1.GetLayers()} {c1.GetFlavor()} {c1.GetFrosting()}");
            //Console.WriteLine(c1);
            //Cake c2 = new Cake();
            //Console.WriteLine(c2);
            //Cake c3 = new Cake("Shortbread", 0, "Strawberry", "Strawberry");
            //Console.WriteLine(c3);
            List<Cake> cakes = new List<Cake>();
            Cake mycake = new Cake();  // Let's use default constructor
            cakes.Add(mycake);
            mycake = new Cake("Carrotcake", 2, "Vanilla", "Spice");
            cakes.Add(mycake);
            mycake = new Cake("Shortbread", 3, "Yellow", "Vanilla");
            cakes.Add(mycake);
            // See how we can reuse mycake variable. We can
            // drop any cake into it (or, pointer to a cake, really)
            //mycake = cakes[0];
            //Console.WriteLine(mycake);
            //mycake = cakes[1];
            //Console.WriteLine(mycake);
            Console.WriteLine("Here are all the cakes:");
            ListCakes(cakes);
            mycake = SearchForCake(cakes, "Carrotcake");
            if (mycake != null)
            {
                // We got back something other than null, meaning we found one.
                Console.WriteLine("\nFound the cake!");
                Console.WriteLine(mycake);
            }
            else
            {
                Console.WriteLine("Cake not found!");
            }
            mycake = new Cake("Wedding Layer", 6, "Vanilla", "Chocolate");
            cakes.Add(mycake);
            Console.WriteLine("\nLet's list all the cakes again!");
            ListCakes(cakes);
        }
    }
}