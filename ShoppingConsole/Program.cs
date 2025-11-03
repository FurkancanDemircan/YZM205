using ShoppingLibrary;

Product p1 = new Product(productId: 1, name: "Iphone 17 Pro Max", stock: 1, reviewScore: 4.5f, price: 140000, description: "It's Apple.");
Product p2 = new Product(2, "Mac Mini", stock: 3, reviewScore: 4.7f, price: 65000, description: "It have M4 Pro CPU.");
Product p3 = new Product(3, "Dyson Airwrap", 4, 4.3f, 35000, "It is hair product.");

CardLine c1 = new CardLine(1, p1, 1);
CardLine c2 = new CardLine(2, p2, 4);
CardLine c3 = new CardLine(3, p3, 1);

Card cards = new Card();
cards.Add(c1);
cards.Add(c2);
cards.Add(c3);

foreach (var item in cards.Get())
{
    Console.WriteLine(item.ToString());
}

cards.Delete(2);
foreach (var item in cards.Get())
{
    Console.WriteLine(item.ToString());
}