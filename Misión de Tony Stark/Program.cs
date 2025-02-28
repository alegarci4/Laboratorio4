

using System.ComponentModel.Design;

Console.WriteLine("Bienvenido al menú para la misión secreta de Tony Stark");
Console.WriteLine("Seleccione una opción: \n");

Console.WriteLine("\n1. Crear archivo");
Console.WriteLine("2. Agregar invento");
Console.WriteLine("3. Leer linea por linea");
Console.WriteLine("4. Leer todo el texto");
Console.WriteLine("5. Copiar archivo");
Console.WriteLine("6. Mover archivo");
Console.WriteLine("7. Crear carpeta");
Console.WriteLine("8. Verificar si existe el archivo Inventos.txt");
Console.WriteLine("9. Eliminar el archivo Inventos.txt");
Console.WriteLine("10. Listar Archivos");
Console.WriteLine("11. Salir");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    //Aqui creamos el archivo 
    case 1:
        void CrearArchivo()
        {
            string path = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\misionSecreta.txt";
            string contenido = "Traje Mark l \nReactor Arc\nInteligencia artificial JARVIS\n";
            try
            {
                File.WriteAllText(path, contenido);
                Console.WriteLine("Archivo creado exitosamente!");
            }
            catch (FileNotFoundException err)
            {
                Console.WriteLine("No existe este archivo");
            }
            catch (DirectoryNotFoundException err)
            {
                Console.WriteLine("Ups la carpeta notfound");
            }
            catch (Exception err)
            {
                Console.WriteLine("Cualquier otro error" + err.Message);
            }
        }
        CrearArchivo();
        break;

    //Funcion para agregar una nueva linea a nuestro documento
    case 2:
        void AgregarInvento()
        {
            string path = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\misionSecreta.txt";
            string contenido = "Drones de combate";
            File.AppendAllText(path, contenido);
            Console.WriteLine("Archivo creado exitosamente!");
        }
        AgregarInvento();
        break;

    // Funcion para que lea linea por linea 
    case 3:
        void leerLineaPorLinea()
        {
            string path = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\misionSecreta.txt";
            string[] lineas = File.ReadAllLines(path);
            foreach (string linea in lineas)
            {
                Console.WriteLine("Linea= " + linea);
            }
        }
        leerLineaPorLinea();
        break;

    // Leer todo el contenido del archivo
    case 4:
        void leerarchivo()
        {

            string path = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\misionSecreta.txt";
            string contenido = File.ReadAllText(path);
            Console.WriteLine("Contenido: ");
            Console.WriteLine(contenido);

        }
        leerarchivo(); 
        break;

    //Aqui copiamos nuestro archivo a otra carpeta
    case 5:
        void copiarArchivo()
        {

            string Archivo = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\misionSecreta.txt";
            File.Copy (Archivo, "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\Backup\\Copia.txt");
            Console.WriteLine("Archivo copiado exitosamente!");
        }
        copiarArchivo();
        break;

    //Esta funcion muevo, No copia el archivo a otra carpeta 
     case 6:
        void moverArchivo()
        {

            string Archivo = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\misionSecreta.txt";
            File.Move(Archivo, "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\ArchivosClasificados\\Clasificado.txt");
            Console.WriteLine("Archivo movido exitosamente!");
        }
        moverArchivo();
        break;

    //
    case 7:
        void crearCarpeta()
        {
            string path = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\Proyectos secretos";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Carpeta creada con exito");
            }
            else
            {
                Console.WriteLine("La carpeta ya existe");
            }
        }
        crearCarpeta();
        break;

    case 8:
        void verificarArchivo ()
        {
            string path = "Invento.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("El archivo existe");
            }
            else
            {
                void CrearArchivo()
                {
                    string path = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\Invento.txt";
                    string contenido = "Archivo de prueba";

                    File.WriteAllText(path, contenido);
                    Console.WriteLine("Archivo creado exitosamente, ahora ya existe");

                }
            }
        }
        verificarArchivo ();
        CrearArchivo();
        break;

    case 9:
        void eliminarArchivo()
        {

            string Archivo = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark\\Invento.txt";
            File.Delete(Archivo);
            Console.WriteLine("Archivo eliminado exitosamente.");
        }
        eliminarArchivo();
        break;

    case 10:
        void listarArchivos()
        {
            string path = "C:\\p1\\Misión de Tony Stark\\Misión de Tony Stark";

            if (Directory.Exists(path))
            {
                foreach (var archivo in Directory.GetFiles(path))
                {
                    Console.WriteLine(archivo);
                }
            }
            else
            {
                Console.WriteLine("La carpeta no existe");
            }
        }
        listarArchivos();
        break;

    case 11:
        Console.WriteLine("Hasta pronto señor Stark");
        break;
}
 