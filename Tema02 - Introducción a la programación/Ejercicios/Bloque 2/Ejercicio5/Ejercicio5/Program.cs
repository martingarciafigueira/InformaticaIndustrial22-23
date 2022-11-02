//Declaramos las variables
double precio, importeFinal;
short cantidad;

//Pedimos los datos al usuario
Console.WriteLine("Introduce la cantidad");
cantidad = short.Parse(Console.ReadLine());

Console.WriteLine("Introduce el precio");
precio = double.Parse(Console.ReadLine());

//Hacemos los cálculos
importeFinal = precio * cantidad;

//Mostramos los resultados
Console.WriteLine("El precio del producto es " + precio + " euros y la cantidad que compra es " + cantidad + " por lo tanto debe pagar " + importeFinal + " euros. Vuelva pronto.");

Console.ReadLine();
