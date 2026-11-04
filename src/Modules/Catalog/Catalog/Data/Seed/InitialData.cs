namespace Catalog.Data.Seed;

public static class InitialData
{
    public static IEnumerable<Product> Products => new List<Product>
    {
        Product.Create(Guid.NewGuid(), "iPhone Duo", ["Phones"], "Dual-screen flagship smartphone designed for seamless multitasking and high performance.", "product-1.png", 2000),
        Product.Create(Guid.NewGuid(), "Samsung Galaxy S24", ["Phones"], "Premium smartphone featuring high-resolution dynamic AMOLED display and advanced AI capabilities.", "product-2.png", 1200),
        Product.Create(Guid.NewGuid(), "Google Pixel 9 Pro", ["Phones"], "Advanced computational photography powerhouse featuring pure Android and Tensor G4 processor.", "product-3.png", 999),
        Product.Create(Guid.NewGuid(), "OnePlus 12", ["Phones"], "High-performance smartphone with ultra-fast charging, Snapdragon chipset, and Hasselblad camera system.", "product-4.png", 799),
        Product.Create(Guid.NewGuid(), "Xiaomi 14 Ultra", ["Phones"], "Photography-focused flagship smartphone with quad Leica optical lenses and Snapdragon platform.", "product-5.png", 1100),
        Product.Create(Guid.NewGuid(), "Sony Xperia 1 VI", ["Phones"], "Professional multimedia smartphone with dedicated camera controls and high-fidelity audio.", "product-6.png", 1299),
        Product.Create(Guid.NewGuid(), "Asus ROG Phone 8 Pro", ["Phones"], "Ultimate gaming phone equipped with specialized cooling, AirTrigger controls, and 165Hz display.", "product-7.png", 1199),
        Product.Create(Guid.NewGuid(), "Motorola Edge 50 Ultra", ["Phones"], "Sleek device featuring premium materials, Pantone-validated display, and rapid turbo charging.", "product-8.png", 899),
        Product.Create(Guid.NewGuid(), "Nothing Phone (2)", ["Phones"], "Distinctive transparent design with interactive Glyph interface and clean Nothing OS.", "product-9.png", 649),
        Product.Create(Guid.NewGuid(), "Apple iPhone 16 Pro", ["Phones"], "Titanium design powered by A18 Pro chip with advanced Camera Control and studio-quality mics.", "product-10.png", 1199),
    };
}