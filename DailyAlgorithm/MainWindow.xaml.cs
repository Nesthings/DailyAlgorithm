using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace DailyAlgorithm
{
    public partial class MainWindow : Window
    {
        private List<string> elementos = new List<string>
        {

           "/*\r\n * Escribe un programa que muestre por consola (con un print) los\r\n * números de 1 a 100 (ambos incluidos y con un salto de línea entre\r\n * cada impresión), sustituyendo los siguientes:\r\n * - Múltiplos de 3 por la palabra \"fizz\".\r\n * - Múltiplos de 5 por la palabra \"buzz\".\r\n * - Múltiplos de 3 y de 5 a la vez por la palabra \"fizzbuzz\".\r\n */\r\n",

           "/*\r\n * Escribe un programa que, dado un número, compruebe y muestre si es primo, fibonacci y par.\r\n * Ejemplos:\r\n * - Con el número 2, nos dirá: \"2 es primo, fibonacci y es par\"\r\n * - Con el número 7, nos dirá: \"7 es primo, no es fibonacci y es impar\"\r\n */\r\n",

            "/*\r\n * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.\r\n * Podrás configurar generar contraseñas con los siguientes parámetros:\r\n * - Longitud: Entre 8 y 16.\r\n * - Con o sin letras mayúsculas.\r\n * - Con o sin números.\r\n * - Con o sin símbolos.\r\n * (Pudiendo combinar todos estos parámetros entre ellos)\r\n */\r\n",

            "/*\r\n * Crea una función que dibuje una escalera según su número de escalones.\r\n * - Si el número es positivo, será ascendente de izquiera a derecha.\r\n * - Si el número es negativo, será descendente de izquiera a derecha.\r\n * - Si el número es cero, se dibujarán dos guiones bajos (__).\r\n * \r\n * Ejemplo: 4\r\n *         _\r\n *       _|       \r\n *     _|\r\n *   _|\r\n * _|\r\n * \r\n */\r\n",

            "/*\r\n * Crea un programa que realice el cifrado César de un texto y lo imprima.\r\n * También debe ser capaz de descifrarlo cuando así se lo indiquemos.\r\n *\r\n * Te recomiendo que busques información para conocer en profundidad cómo\r\n * realizar el cifrado. Esto también forma parte del reto.\r\n */\r\n",

            "/*\r\n * Crea un programa que detecte cuando el famoso \"Código Konami\" se ha introducido correctamente\r\n * desde el teclado. Si sucede esto, debe notificarse mostrando un mensaje en la terminal.\r\n */\r\n",

            "/*\r\n * Crea una función que reciba dos parámetros para crear una cuenta atrás.\r\n * - El primero, representa el número en el que comienza la cuenta.\r\n * - El segundo, los segundos que tienen que transcurrir entre cada cuenta.\r\n * - Sólo se aceptan números enteros positivos.\r\n * - El programa finaliza al llegar a cero.\r\n * - Debes imprimir cada número de la cuenta atrás.\r\n */\r\n",

            "/*\r\n * Los primeros dispositivos móviles tenían un teclado llamado T9\r\n * con el que se podía escribir texto utilizando únicamente su\r\n * teclado numérico (del 0 al 9).\r\n *\r\n * Crea una función que transforme las pulsaciones del T9 a su\r\n * representación con letras.\r\n * - Debes buscar cuál era su correspondencia original.\r\n * - Cada bloque de pulsaciones va separado por un guión.\r\n * - Si un bloque tiene más de un número, debe ser siempre el mismo.\r\n * - Ejemplo:\r\n *     Entrada: 6-666-88-777-33-3-33-888\r\n *     Salida: MOUREDEV\r\n */\r\n",

            "/*\r\n * Crea una función que sea capaz de leer el número representado por el ábaco.\r\n * - El ábaco se representa por un array con 7 elementos.\r\n * - Cada elemento tendrá 9 \"O\" (aunque habitualmente tiene 10 para realizar operaciones)\r\n *   para las cuentas y una secuencia de \"---\" para el alambre.\r\n * - El primer elemento del array representa los millones, y el último las unidades.\r\n * - El número en cada elemento se representa por las cuentas que están a la izquierda del alambre.\r\n *\r\n * Ejemplo de array y resultado:\r\n * [\"O---OOOOOOOO\",\r\n *  \"OOO---OOOOOO\",\r\n *  \"---OOOOOOOOO\",\r\n *  \"OO---OOOOOOO\",\r\n *  \"OOOOOOO---OO\",\r\n *  \"OOOOOOOOO---\",\r\n *  \"---OOOOOOOOO\"]\r\n *  \r\n *  Resultado: 1.302.790\r\n */\r\n",

            "/*\r\n * Crea un programa que sea capaz de generar e imprimir todas las \r\n * permutaciones disponibles formadas por las letras de una palabra.\r\n * - Las palabras generadas no tienen por qué existir.\r\n * - Deben usarse todas las letras en cada permutación.\r\n * - Ejemplo: sol, slo, ols, osl, los, lso \r\n */\r\n",

            "/*\r\n * Crea una función que reciba un número decimal y lo trasforme a Octal\r\n * y Hexadecimal.\r\n * - No está permitido usar funciones propias del lenguaje de programación que\r\n * realicen esas operaciones directamente.\r\n */",

            "/*\r\n * Crea las funciones capaces de transformar colores HEX\r\n * a RGB y viceversa.\r\n * Ejemplos:\r\n * RGB a HEX: r: 0, g: 0, b: 0 -> #000000\r\n * HEX a RGB: hex: #000000 -> (r: 0, g: 0, b: 0)\r\n */",

            "/*\r\n * Crea un programa que sea capaz de solicitarte un número y se\r\n * encargue de imprimir su tabla de multiplicar entre el 1 y el 10.\r\n * - Debe visualizarse qué operación se realiza y su resultado.\r\n *   Ej: 1 x 1 = 1\r\n *       1 x 2 = 2\r\n *       1 x 3 = 3\r\n *       ... \r\n */",

            "/*\r\n  * Crea un programa que calcule los puntos de una palabra.\r\n * - Cada letra tiene un valor asignado. Por ejemplo, en el abecedario\r\n *   español de 27 letras, la A vale 1 y la Z 27.\r\n * - El programa muestra el valor de los puntos de cada palabra introducida.\r\n * - El programa finaliza si logras introducir una palabra de 100 puntos.\r\n * - Puedes usar la terminal para interactuar con el usuario y solicitarle\r\n *   cada palabra.\r\n */",

            "/*\r\n * Crea una función que simule las condiciones climáticas (temperatura y probabilidad de lluvia)\r\n * de un lugar ficticio al pasar un número concreto de días según estas reglas:\r\n * - La temperatura inicial y el % de probabilidad de lluvia lo define el usuario.\r\n * - Cada día que pasa:\r\n *   - 10% de posibilidades de que la temperatura aumente o disminuya 2 grados.\r\n *   - Si la temperatura supera los 25 grados, la probabilidad de lluvia al día \r\n *     siguiente aumenta en un 20%.\r\n *   - Si la temperatura baja de 5 grados, la probabilidad de lluvia al día \r\n *     siguiente disminuye en un 20%.\r\n *   - Si llueve (100%), la temperatura del día siguiente disminuye en 1 grado.\r\n * - La función recibe el número de días de la predicción y muestra la temperatura\r\n *   y si llueve durante todos esos días.\r\n * - También mostrará la temperatura máxima y mínima de ese periodo y cuántos días va a llover.\r\n */",

            "/*\r\n * Crea un algoritmo que invierta una cadena de texto dada por medio de la consola\r\n*",

            "/*\r\n * Crea un algoritmo que indique cuantas veces se repite un caracter\r\n* en una cadena de texto dada por medio de la consola\r\n*",

            "/*\r\n * Crea un algoritmo que determine la distancia de Hamming entre dos cadenas de caracteres \r\n* ingresadas por medio de la consola\r\n*",

            "/*\r\n * Crea un algoritmo capaz de contar las palabras en una cadena de texto dada por medio de la consola\r\n* (Ten cuidado con los espacios)\r\n*",

            "/*\r\n * Crea un algoritmo capaz de contar la cantidad de numeros contenidos en una cadena de caracteres\r\n* dados por medio de la consola\r\n*",



























        };


        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void generador_Click(object sender, RoutedEventArgs e)
        {

            Random random = new Random();   

            elementos=elementos.OrderBy(item => random.Next()).ToList();

            contenedor.Text = elementos.FirstOrDefault();
        }
    }


}

