namespace ClassAndObjectHW
{
    public class Product
    {
        public Product(int productLength, int productWidth, int productHight)
        {
            ProductLenth = productLength;
            ProductWidth = productWidth;
            ProductHight = productHight;
        }

        public int ProductLenth { get; set; }
        public int ProductWidth { get; set; }
        public int ProductHight { get; set; }
        public int ProductWeight { get; set; }


        public void ProductSelection()
        {
            Console.WriteLine("Product is being prepared.");
        }
        public void ProductSetUp()
        {
            Console.WriteLine($"Your product parameters are: length - {ProductLenth}, width - {ProductWidth}, hight - {ProductHight}, weight - {ProductWeight}");
        }



    }
}
