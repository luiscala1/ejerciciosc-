// ejercicio1
Console.WriteLine("Hello, World!");


//ejercicio2
int edad1 = 18;
string nombre1 = "luis";

Console.WriteLine($"{edad1}, {nombre1}");

//ejericio3
string nombre2 = "me llamo luis";

string nombremayuscula=nombre2.ToUpper();
string nombreminuscula=nombre2.ToLower();
Console.WriteLine($"{nombremayuscula}");
Console.WriteLine($"{nombreminuscula}");


//ejercicio4

int numero1 =5;
int numero2 = 8;

int suma= numero1+ numero2;
int multiplicacion= numero1* numero2;
int resta= numero1- numero2;
int division= numero1/ numero2;

Console.WriteLine(suma);
Console.WriteLine(multiplicacion);
Console.WriteLine(resta);
Console.WriteLine(division);

//ejercicio5

int entero1=8;
int entero2=9;

bool esigual= (entero1== entero2);

bool esdiferente=(entero1 != entero2);

bool esmayor=(entero1 >entero2);

bool esmenor=(entero1<entero2);

Console.WriteLine($"{esigual}");
Console.WriteLine($"{esdiferente}");
Console.WriteLine($"{esmayor}");
Console.WriteLine($"{esmenor}");

//ejercicio6

string muestra1 = "soy prgramador de python";

string modificarfrase = muestra1.Replace("python","c#");

Console.WriteLine(modificarfrase);

//ejercicio7

Console.WriteLine("como te llamas?");

string nombre = Console.ReadLine();

Console.WriteLine($"tu nombre es {nombre}");


Console.WriteLine("que edad tienes?"); 
int edad=int.Parse(Console.ReadLine());
Console.WriteLine($"tu edad es {edad}");

//ejercicio8
int mayor=15;

if (mayor > 10)
 { Console.WriteLine($"tu numero {mayor} es mayor que 10");}

else if (mayor < 10) 
{Console.WriteLine($"tu numero {mayor} es menor que 10");}

else {Console.WriteLine($"tu numero es exactamente 10");}
 
//ejercicio9

 double decimal1=12.5;
 double decimal2=13.5;
 
 double suma = decimal1+decimal2;
 double resta = decimal1-decimal2;
 double multiplicacion = decimal1*decimal2;
 double division = decimal1/decimal2;

 Console.WriteLine(suma);
 Console.WriteLine(multiplicacion);
 Console.WriteLine(resta);
 Console.WriteLine(division);
 
 //ejercicio10
 string nombre="luis";
 string apellido="cala";
 
 string nombrecompleto = nombre+" "+apellido;
 
 Console.WriteLine(nombrecompleto);
 
 //ejercicio11
 
 int numeroentero=72;
 
 double numerodouble=numeroentero;
 
 Console.WriteLine($"{numerodouble}");

//ejercicio12

Console.WriteLine("ingrese el numero");

double numero=Convert.ToDouble(Console.ReadLine());

if (numero >0)
{Console.WriteLine($"el {numero} es positivo");}

else if (numero < 0)
{
     Console.WriteLine($"el {numero} es negativo");
}

else {
     Console.WriteLine("el numero es exactamente 0"); }
 
//ejercicio13

for (int i=1; i<=10; i++)
{
    Console.WriteLine($"numero{i}");
    
}
 
 //ejercicio14

 string textoSucio = "   luis alberto   ";


 string textoLimpio = textoSucio.Trim();
 
 string textoFormateado = char.ToUpper(textoLimpio[0]) + textoLimpio.Substring(1).ToLower();
 
 Console.WriteLine($"original con espacios: '{textoSucio}'");
 Console.WriteLine($"formateado: '{textoFormateado}'");






 
 