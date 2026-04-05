namespace AssignmentLinq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            //        1.Get all products from the "Seafood" category.Print each
            //          product's name and price.

            //            List<Product> ProductList = new List<Product>();
            //        var seafoodProducts = ProductList
            //.Where(p => p.Category == "Seafood");

            //        foreach (var p in seafoodProducts)
            //        {
            //            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //        }


            #endregion
            #region Question02
            //        var productNames = ProductList
            //.Select(p => p.ProductName);

            //        foreach (var name in productNames)
            //        {
            //            Console.WriteLine(name);
            //        }


            #endregion
            #region Question03
            //        var sortedProducts = ProductList
            //.OrderBy(p => p.UnitPrice);

            //        foreach (var p in sortedProducts)
            //        {
            //            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //        }

            #endregion
            #region Question04

            //var productsInRange = ProductList

            //    .Where(p => p.UnitPrice>=10 && p.UnitPrice<=30);

            //foreach (var p in productsInRange)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion
            #region Question05
            //        var condimentsInStock = ProductList
            //.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //        foreach (var p in condimentsInStock)
            //        {
            //            Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            //        }
            #endregion
            #region Question06
            ////        var result = ProductList
            ////.Select(p => new
            ////{
            ////    Name = p.ProductName,
            ////    Price = p.UnitPrice,
            ////    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            ////});

            ////        foreach (var item in result)
            ////        {
            ////            Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
            ////        }
            #endregion
            #region Question07
            //        var indexedProducts = ProductList
            //.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    Name = p.ProductName
            //});

            //        foreach (var item in indexedProducts)
            //        {
            //            Console.WriteLine($"{item.Position}. {item.Name}");
            //        }
            #endregion
            #region Question08
            //        var sorted = ProductList
            //.OrderBy(p => p.Category)
            //.ThenByDescending(p => p.UnitPrice);

            //        foreach (var p in sorted)
            //        {
            //            Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //        }
            #endregion
            #region Question09
            //        var beverages = ProductList
            //.Where(p => p.Category == "Beverages")
            //.OrderByDescending(p => p.UnitsInStock);

            //        foreach (var p in beverages)
            //        {
            //            Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            //        }

            #endregion
            #region Question10
            //        var ordersQuery =
            //from o in Orders
            //where o.OrderDate.Year >= 1997
            //select new
            //{
            //    o.CustomerID,
            //    o.OrderDate
            //};

            //        foreach (var o in ordersQuery)
            //        {
            //            Console.WriteLine($"{o.CustomerID} - {o.OrderDate}");
            //        }
            #endregion
            #region Question11
            //        var result = ProductList
            //.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    p.ProductName
            //});

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"{item.Position}. {item.ProductName}");
            //        }
            #endregion
            #region Question12
            //        string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //        var sortedWords = Arr
            //.OrderBy(w => w.Length) 
            //.ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //        foreach (var word in sortedWords)
            //        {
            //            Console.WriteLine(word);
            //        }
            #endregion
            #region Question13
//            string[] digits =
//{
//    "zero","one","two","three","four",
//    "five","six","seven","eight","nine"
//};
//            var result = digits
//    .Where(d => d.Length > 1 && d[1] == 'i')
//    .Reverse();

//            foreach (var d in result)
//            {
//                Console.WriteLine(d);
//            }
            #endregion
        }
    }
}
