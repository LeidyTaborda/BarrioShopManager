using System.Xml.Linq;

namespace BarrioShopManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Autenticación al programa
            //Variables
            string usuarioDefecto = "administrador";
            string claveDefecto = "123";

            //Autenticarse
            Console.WriteLine("---- AUTENTICACIÓN ----");
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string clave = Console.ReadLine();

            //Validación de credenciales (operador ternario)
            Console.WriteLine(usuario == usuarioDefecto && clave == claveDefecto ? "Bienvenido al sistema" : "Error de autenticación.");

            //Mostrar Menú
            //Variables
            if (usuario == usuarioDefecto && clave == claveDefecto)
            {
                int opcion = 0;
            Console.WriteLine("------------------MENÚ------------------");
            Console.WriteLine("1. Gestión de Usuarios          2. Gestión de artículos");
            Console.WriteLine("3. Gestión de ventas            4. Salir del programa");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Seleccione una opción del menú");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Le damos la bienvenida al módulo Gestión de usuarios");
                        Console.WriteLine("Ingrese el nombre del Usuario 1: ");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Ingrese el número de cédula del Usuario 1: ");
                        string id1 = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del Usuario 2: ");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Ingrese el número de cédula del Usuario 2: ");
                        string id2 = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del Usuario 3: ");
                        string name3 = Console.ReadLine();
                        Console.WriteLine("Ingrese el número de cédula del Usuario 3: ");
                        string id3 = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del Usuario 4: ");
                        string name4 = Console.ReadLine();
                        Console.WriteLine("Ingrese el número de cédula del Usuario 4: ");
                        string id4 = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del Usuario 5: ");
                        string name5 = Console.ReadLine();
                        Console.WriteLine("Ingrese el número de cédula del Usuario 5: ");
                        string id5 = Console.ReadLine();
                        //-----MENÚ GESTIÓN DE USUARIOS-----
                        Console.WriteLine("----------------------------MÓDULO GESTIÓN DE USUARIOS---------------------------");
                        Console.WriteLine("1. Ver lista de usuarios                               2. Nuevo usuario");
                        Console.WriteLine("3. Editar información de usuario (buscar por c.c)      4. Salir de Gestión de usuarios (Menú principal)");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.Write("Seleccione una opción del menú: ");
                        int subopcion = int.Parse(Console.ReadLine());
                        //subopciones
                        string VerLista()
                        {
                            return "Lista de usuarios: " +
                                id1 + " " + name1 + ", " +
                                id2 + " " + name2 + ", " +
                                id3 + " " + name3 + ", " +
                                id4 + " " + name4 + ", " +
                                id5 + " " + name5;
                        }

                        string NuevoUsuario()
                        {
                            Console.Write("Ingrese el nombre del nuevo usuario: ");
                            string name6 = Console.ReadLine();
                            Console.Write("Ingrese el número de cédula del nuevo usuario: ");
                            string id6 = Console.ReadLine();
                            return "Nuevo usuario registrado: " + id6 + " " + name6;
                        }

                        string BuscarUsuario()
                        {
                            Console.Write("Ingrese el número de cédula a buscar: ");
                            string cedula = Console.ReadLine();

                            return 
                                (cedula == id1) ? "Usuario encontrado: " + id1 + " " + name1 :
                                (cedula == id2) ? "Usuario encontrado: " + id2 + " " + name2 :
                                (cedula == id3) ? "Usuario encontrado: " + id3 + " " + name3 :
                                (cedula == id4) ? "Usuario encontrado: " + id4 + " " + name4 :
                                (cedula == id5) ? "Usuario encontrado: " + id5 + " " + name5 :
                                "Usuario no encontrado.";
                                }
                            string resultado =
                            (subopcion == 1) ? VerLista() :
                            (subopcion == 2) ? NuevoUsuario() :
                            (subopcion == 3) ? BuscarUsuario() :
                            (subopcion == 4) ? "Regresando al Menú principal..." :
                                               "Opción inválida";

                            Console.WriteLine(resultado);
                    break;
                case 2:
                    Console.WriteLine("Le damos la bienvenida al módulo Gestión de artículos.");
                    break;
                case 3:
                    Console.WriteLine("Le damos la bienvenida al módulo Gestión de ventas. ");
                    break;
                case 4:
                    Console.WriteLine("Se ha cerrado sesión en el programa. ");
                    return;               
                default:
                    Console.WriteLine("ERROR. Seleccione una opción válida.");
                    return;
                }

            }
            else
            {
                Console.WriteLine("No puede acceder al menú.");
                return;
            }
                                       
        }
                
    }
}








