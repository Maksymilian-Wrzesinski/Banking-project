public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //method cost<=20000 tax=10% more 12.5%
    public void CalculateTax()
    {
        //local variable
        double t;

        //calc tax
        if(cost<=20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
                t = cost * 12.5 / 100;
        }
        tax = t;
    }

}
