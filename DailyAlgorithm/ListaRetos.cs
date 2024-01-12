using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAlgorithm
{
    internal class Listax
    {

        public void Listi()
        {
            var List = new List<string>();

            List.Add("/*\r\n * Escribe un programa que muestre por consola (con un print) los\r\n * números de 1 a 100 (ambos incluidos y con un salto de línea entre\r\n * cada impresión), sustituyendo los siguientes:\r\n * - Múltiplos de 3 por la palabra \"fizz\".\r\n * - Múltiplos de 5 por la palabra \"buzz\".\r\n * - Múltiplos de 3 y de 5 a la vez por la palabra \"fizzbuzz\".\r\n */\r\n");

            List.Add("/*\r\n * Escribe un programa que, dado un número, compruebe y muestre si es primo, fibonacci y par.\r\n * Ejemplos:\r\n * - Con el número 2, nos dirá: \"2 es primo, fibonacci y es par\"\r\n * - Con el número 7, nos dirá: \"7 es primo, no es fibonacci y es impar\"\r\n */\r\n");

            List.Add("/*\r\n * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.\r\n * Podrás configurar generar contraseñas con los siguientes parámetros:\r\n * - Longitud: Entre 8 y 16.\r\n * - Con o sin letras mayúsculas.\r\n * - Con o sin números.\r\n * - Con o sin símbolos.\r\n * (Pudiendo combinar todos estos parámetros entre ellos)\r\n */\r\n");

            List.Add("/*\r\n * Crea una función que dibuje una escalera según su número de escalones.\r\n * - Si el número es positivo, será ascendente de izquiera a derecha.\r\n * - Si el número es negativo, será descendente de izquiera a derecha.\r\n * - Si el número es cero, se dibujarán dos guiones bajos (__).\r\n * \r\n * Ejemplo: 4\r\n *         _\r\n *       _|       \r\n *     _|\r\n *   _|\r\n * _|\r\n * \r\n */\r\n");

            List.Add("/*\r\n * Crea un programa que realice el cifrado César de un texto y lo imprima.\r\n * También debe ser capaz de descifrarlo cuando así se lo indiquemos.\r\n *\r\n * Te recomiendo que busques información para conocer en profundidad cómo\r\n * realizar el cifrado. Esto también forma parte del reto.\r\n */\r\n");

            List.Add("/*\r\n * Crea un programa que detecte cuando el famoso \"Código Konami\" se ha introducido correctamente\r\n * desde el teclado. Si sucede esto, debe notificarse mostrando un mensaje en la terminal.\r\n */\r\n");

            List.Add("/*\r\n * Crea una función que reciba dos parámetros para crear una cuenta atrás.\r\n * - El primero, representa el número en el que comienza la cuenta.\r\n * - El segundo, los segundos que tienen que transcurrir entre cada cuenta.\r\n * - Sólo se aceptan números enteros positivos.\r\n * - El programa finaliza al llegar a cero.\r\n * - Debes imprimir cada número de la cuenta atrás.\r\n */\r\n");

            List.Add("/*\r\n * Los primeros dispositivos móviles tenían un teclado llamado T9\r\n * con el que se podía escribir texto utilizando únicamente su\r\n * teclado numérico (del 0 al 9).\r\n *\r\n * Crea una función que transforme las pulsaciones del T9 a su\r\n * representación con letras.\r\n * - Debes buscar cuál era su correspondencia original.\r\n * - Cada bloque de pulsaciones va separado por un guión.\r\n * - Si un bloque tiene más de un número, debe ser siempre el mismo.\r\n * - Ejemplo:\r\n *     Entrada: 6-666-88-777-33-3-33-888\r\n *     Salida: MOUREDEV\r\n */\r\n");

            List.Add("/*\r\n * Crea una función que sea capaz de leer el número representado por el ábaco.\r\n * - El ábaco se representa por un array con 7 elementos.\r\n * - Cada elemento tendrá 9 \"O\" (aunque habitualmente tiene 10 para realizar operaciones)\r\n *   para las cuentas y una secuencia de \"---\" para el alambre.\r\n * - El primer elemento del array representa los millones, y el último las unidades.\r\n * - El número en cada elemento se representa por las cuentas que están a la izquierda del alambre.\r\n *\r\n * Ejemplo de array y resultado:\r\n * [\"O---OOOOOOOO\",\r\n *  \"OOO---OOOOOO\",\r\n *  \"---OOOOOOOOO\",\r\n *  \"OO---OOOOOOO\",\r\n *  \"OOOOOOO---OO\",\r\n *  \"OOOOOOOOO---\",\r\n *  \"---OOOOOOOOO\"]\r\n *  \r\n *  Resultado: 1.302.790\r\n */\r\n");

            List.Add("\r\n/*\r\n * Crea un programa que sea capaz de generar e imprimir todas las \r\n * permutaciones disponibles formadas por las letras de una palabra.\r\n * - Las palabras generadas no tienen por qué existir.\r\n * - Deben usarse todas las letras en cada permutación.\r\n * - Ejemplo: sol, slo, ols, osl, los, lso \r\n */\r\n");

            Random _random = new Random();

            int indiceAleatorio = _random.Next(List.Count);

            string ElementoAleatorio = List[indiceAleatorio];






        }
















    }
}
