class Sample
{
    static void Main()
    {
        //create reference variables

        Product product1, product2, product3;

        //create objcets
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        //initialize fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 2000;
        product1.quantityInStock = 120;

        product2.productID = 1002;
        product2.productName = "Car";
        product2.cost = 1000;
        product2.quantityInStock = 220;

        product3.productID = 1003;
        product3.productName = "Phone";
        product3.cost = 20000;
        product3.quantityInStock = 12;

        //call methods
        product1.CalculateTax();

        //get values of fields
        System.Console.WriteLine(product1.productID);
        System.Console.WriteLine(product1.productName);
        System.Console.WriteLine(product1.cost);
        System.Console.WriteLine(product1.quantityInStock);
        System.Console.WriteLine("Current tax: "+product1.tax);

        int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;
        System.Console.WriteLine("Total Quantity in stock "+totalQuantity);
        System.Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);
        System.Console.ReadKey();

    }
}
