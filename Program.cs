
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList puntaje = new ArrayList(); //Uso de Arraulist para guardar los resultados
       int seleccion = 0;
       int resultado=0;

        do {
            Console.Clear(); //lo primero que hacemos es limpiar la pantalla de procesos anteriores
            seleccion = seleccion_menu(); //llamado al metodo para el saludo del progama
            switch (seleccion)
            {
                case 1:
                    resultado= suma();
                    Console.WriteLine("EL PUNTAJE OBTENIDO EN LA OPCION SUMA FUERON: "+ resultado + " PUNTOS");
                    Console.WriteLine(validar_puntaje(resultado,seleccion));
                    Console.ReadKey();
                    seleccion = consulta_cerrar();
                break;
                case 2:
                    resultado= resta();
                    Console.WriteLine("EL PUNTAJE OBTENIDO EN LA OPCION RESTA FUERON: "+ resultado + " PUNTOS");
                    Console.WriteLine(" "+validar_puntaje(resultado,seleccion));
                    Console.ReadKey();
                    seleccion = consulta_cerrar();      
                break;
                case 3:
                    resultado= multiplicacion();
                    Console.WriteLine("EL PUNTAJE OBTENIDO EN LA OPCION MULTIPLICACION FUERON: "+ resultado + " PUNTOS");
                    Console.WriteLine(" "+validar_puntaje(resultado,seleccion));
                    Console.ReadKey();
                    seleccion = consulta_cerrar();      
                break;
                case 4:
                    resultado= division();
                    Console.WriteLine("EL PUNTAJE OBTENIDO EN LA OPCION DIVISION FUERON: "+ resultado + " PUNTOS");
                    Console.WriteLine(" "+validar_puntaje(resultado,seleccion));
                    Console.ReadKey();
                    seleccion = consulta_cerrar();      
                break;
                case 5:
                    int salida=0;
                    Console.WriteLine("EL PROGRAMA ESTA A PUNTO DE CERRARSE...");
                    Console.WriteLine("PRESIONE: ");
                    Console.WriteLine("1: PARA CONTINUAR");
                    Console.WriteLine("0: PARA CANCELAR");
                    salida = Convert.ToInt32( Console.ReadLine());
                    if (salida == 1)
                        {
                            Console.Clear();
                            Environment.Exit(0);
                        }
                    else
                    {
                        seleccion =0;
                    }
                    
                break;
            }
        }while (seleccion != 5);

    }   

    static int consulta_cerrar()
    {
        int num=0,salida=0;
        do{ //PRIMER ENUNCIADO
            try
            {
            Console.Clear();
            Console.WriteLine("CONCLUISTE LA OPCION SELECCIONANDA");
            Console.WriteLine("TIENES LA OPCION DE SALIR DEL PROGRAMA");
            Console.WriteLine("PRESIONE: ");
            Console.WriteLine("1: PARA SALIR DEL PROGRAMA");
            Console.WriteLine("0: PARA VOLVER AL MENU PRINCIPAL");
            num = Convert.ToInt32( Console.ReadLine());
            if (num == 1)
                {
                    salida = 5;
                }
            else
            {
                salida =0;
            }
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO PARA SU DESICION");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
            if (num <0 || num >1 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
                Console.Clear();
        } while (num <0 || num >1);

        return salida;

    }

    static int seleccion_menu()
    { 
        int opcion = 0;
        do{ 
                Console.WriteLine("-------BIENVENIDO A TU APP DE OPERACIONES BASICAS DE FRACCIONES------");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("------SELECCIONE EL NUMERO DEL TEMA QUE LE GUSTARIA ESTUDIAR---------");
                Console.WriteLine("1. - SUMA");
                Console.WriteLine("2. - RESTA");
                Console.WriteLine("3. - MULTIPLICACION");
                Console.WriteLine("4. - DIVISION");
                Console.WriteLine("5. - SALIR");
                    try
                    {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    }catch(FormatException)
                    {
                            Console.Clear();
                            Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                            Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                            Console.ReadKey();
                    }
            
                    if (opcion <1 || opcion >5 )
                        {
                            Console.Clear();
                            Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                            Console.WriteLine("INTENTE NUEVAMENTE...");
                            Console.ReadKey();
                        }
                        Console.Clear();
                } while (opcion <1 || opcion >5);
                return opcion;
    }

static int division()
    {
        int puntaje=0,opcion =0;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("------------ACTIVIDIDAD DE DIVISION------------");
        Console.WriteLine("-----------------------------------------------------");

        Console.WriteLine();
        Console.WriteLine("A CONTINUACION SE PRESENTARAN UNA SERIE DE ENUNCIADOS");
        Console.WriteLine("   SELECCIONE LA OPCIONE QUE CONSIDERE CORRECTA      ");
        Console.WriteLine("       PRESIONE CUALQUIER TECLA PARA COMENZAR...");
        Console.ReadKey();
        Console.Clear();

        do{ //PRIMER ENUNCIADO
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------ENUNCIADO N0.1-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("LA DIVISION ENTRE 3/5 Y 2/8 COMO RESULTADO");
            Console.WriteLine("            EL VALOR DE 12/5");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) //SI EL VALOR ES EL CORRECTO SE SUMA 25 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //SEGUNDO ENUNCIADO
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------ENUNCIADO N0.2-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("SI DIVIDIMOS 12/9 ENTRE 9/7 EL VALOR OBTENIDO");
            Console.WriteLine("            ES 12/35");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);



         Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //TERCER ENUNCIADO ENUNCIADO
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------ENUNCIADO N0.3-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("AL DIVIDIR 8/7 ENTRE 8");
            Console.WriteLine(" EL RESULTADO OBTENIDO ES 1/7 ");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);
      
        Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //CUARTO ENUNCIADO ENUNCIADO
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------ENUNCIADO N0.4-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("LA DIVISION DE 2/5 CONTRA 4");
            Console.WriteLine("      DA COMO RESULTADO 1/10");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        return puntaje;
    }

    static int resta()
    {
        int puntaje=0,opcion =0;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("------------ACTIVIDIDAD DE RESTA------------");
        Console.WriteLine("-----------------------------------------------------");

        Console.WriteLine();
        Console.WriteLine("A CONTINUACION SE PRESENTARAN UNA SERIE DE ENUNCIADOS");
        Console.WriteLine("   SELECCIONE LA OPCIONE QUE CONSIDERE CORRECTA      ");
        Console.WriteLine("       PRESIONE CUALQUIER TECLA PARA COMENZAR...");
        Console.ReadKey();
        Console.Clear();

        do{ //PRIMER ENUNCIADO
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------ENUNCIADO N0.1-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("LA SUSTRACCION DE 2/3 Y 1/2 DA COMO RESULTADO");
            Console.WriteLine("            EL VALOR DE 1/6");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) //SI EL VALOR ES EL CORRECTO SE SUMA 25 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //SEGUNDO ENUNCIADO
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------ENUNCIADO N0.2-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("SI SUSTRAEMOS 3/5 DE 2/7 EL VALOR OBTENIDO");
            Console.WriteLine("            ES NEGATIVO");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);



         Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //TERCER ENUNCIADO ENUNCIADO
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------ENUNCIADO N0.3-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("LA SUSTRACCION DE 1/10 DE UN 1/2");
            Console.WriteLine("           DA COMO RESULTADO -2/5");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);
      
        Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //CUARTO ENUNCIADO ENUNCIADO
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--------------ENUNCIADO N0.4-------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("LA RESTA DE 2/5 CONTRA 4/4");
            Console.WriteLine("         DA COMO RESULTADO 3");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        return puntaje;
    }

    static int multiplicacion()
    {
        int puntaje=0,opcion =0;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("------------ACTIVIDIDAD DE MULTIPLICACION------------");
        Console.WriteLine("-----------------------------------------------------");

        Console.WriteLine();
        Console.WriteLine("A CONTINUACION SE PRESENTARAN UNA SERIE DE ENUNCIADOS");
        Console.WriteLine("   SELECCIONE LAS OPCIONES QUE CONSIDERE CORRECTA      ");
        Console.WriteLine("       PRESIONE CUALQUIER TECLA PARA COMENZAR...");
        Console.ReadKey();
        Console.Clear();

        do{ //PRIMER ENUNCIADO
            Console.Clear();
            Console.WriteLine(     "-----------------------------------------");
            Console.WriteLine(     "--------------ENUNCIADO N0.1-------------");
            Console.WriteLine(      "-----------------------------------------");
            Console.WriteLine("       ANALIZANDO LA MULTIPLICACION DE 3/5 Y 3/2");
            Console.WriteLine("SELECCIONE LA RESPUESTA CORRECTA");
            Console.WriteLine("1. 2/4");
            Console.WriteLine("2. 5/7");
            Console.WriteLine("3. 9/10");
            Console.WriteLine("4. 19/10");

            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >4 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 3) //SI EL VALOR ES EL CORRECTO SE SUMA 25 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >4);

        Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //SEGUNDO ENUNCIADO
             Console.Clear();
            Console.WriteLine(     "-----------------------------------------");
            Console.WriteLine(     "--------------ENUNCIADO N0.2-------------");
            Console.WriteLine(      "-----------------------------------------");
            Console.WriteLine("       ANALIZANDO LA MULTIPLICACION DE 2/4 Y 7/3");
            Console.WriteLine("SELECCIONE LA RESPUESTA CORRECTA");
            Console.WriteLine("1. 14/12");
            Console.WriteLine("2. 5/7");
            Console.WriteLine("3. 14/10");
            Console.WriteLine("4. 19/12");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >4 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >4);



         Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //TERCER ENUNCIADO ENUNCIADO
            Console.Clear();
            Console.WriteLine(     "-----------------------------------------");
            Console.WriteLine(     "--------------ENUNCIADO N0.3-------------");
            Console.WriteLine(      "-----------------------------------------");
            Console.WriteLine("       ANALIZANDO LA MULTIPLICACION DE 1/4 , 2/3 y 3/2");
            Console.WriteLine("SELECCIONE LA RESPUESTA CORRECTA");
            Console.WriteLine("1. 7/24");
            Console.WriteLine("2. 5/7");
            Console.WriteLine("3. 6/24");
            Console.WriteLine("4. 6/23");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >4 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 3)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >4);
      
        Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //CUARTO ENUNCIADO ENUNCIADO
             Console.Clear();
            Console.WriteLine(     "-----------------------------------------");
            Console.WriteLine(     "--------------ENUNCIADO N0.4-------------");
            Console.WriteLine(      "-----------------------------------------");
            Console.WriteLine("       ANALIZANDO LA MULTIPLICACION DE 2/2 , 2/3 y 3/2");
            Console.WriteLine("SELECCIONE LA RESPUESTA CORRECTA");
            Console.WriteLine("1. 14/12");
            Console.WriteLine("2. 12/12");
            Console.WriteLine("3. 14/10");
            Console.WriteLine("4. 19/12");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >4 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >4);

        return puntaje;
    }

    static int suma()
    {
        int puntaje=0,opcion =0;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("-----------------ACTIVIDIDAD DE SUMA-----------------");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("-------------------SELECCION UNICA-------------------");
        Console.WriteLine();
        Console.WriteLine("A CONTINUACION SE PRESENTARAN UNA SERIE DE ENUNCIADOS");
        Console.WriteLine("    SELECCIONE LA OPCION QUE CONSIDERE CORRECTA      ");
        Console.WriteLine("       PRESIONE CUALQUIER TECLA PARA COMENZAR...");
        Console.ReadKey();
        Console.Clear();

        do{ //PRIMER ENUNCIADO
            Console.Clear();
            Console.WriteLine(     "-----------------------------------------");
            Console.WriteLine(     "--------------ENUNCIADO N0.1-------------");
            Console.WriteLine(      "-----------------------------------------");
            Console.WriteLine("JAVIER COMPRO 2/5 LIBRAS DE MANZANA Y 1/3 LIBRAS DE PERAS");
            Console.WriteLine("     ¿CUANTAS LIBRAS DE FRUTAS COMPRO EN TOTAL?");
            Console.WriteLine("1. 8/3");
            Console.WriteLine("2. 3/8");
            Console.WriteLine("3. 11/15");
            Console.WriteLine("4. 7/8");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >4 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 3) //SI EL VALOR ES EL CORRECTO SE SUMA 25 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >4);

        Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //SEGUNDO ENUNCIADO
            Console.Clear();
            Console.WriteLine(       "-----------------------------------------");
            Console.WriteLine(       "--------------ENUNCIADO N0.2-------------");
            Console.WriteLine(       "-----------------------------------------");
            Console.WriteLine("MARCO PINTO 3/8 PARTES DE SU CUARTO EN LA MAÑANA Y 4/8 EN LA TARDE");
             Console.WriteLine("     ¿CUAL FUE EL TOTAL QUE PINTO DE SU CUARTO ESE DIA?");
            Console.WriteLine("1. 8/10");
            Console.WriteLine("2. 7/8");
            Console.WriteLine("3. 7/16");
            Console.WriteLine("4. 8/7");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >4 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >4);



         Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //TERCER ENUNCIADO ENUNCIADO
            Console.Clear();
            Console.WriteLine(      "-----------------------------------------");
            Console.WriteLine(      "--------------ENUNCIADO N0.3-------------");
            Console.WriteLine(      "-----------------------------------------");
            Console.WriteLine("ANTONIO VIO 2/4 DE PELICULA EN EL AUTOMOVIL Y 1/4 EN LA SALA");
             Console.WriteLine("     ¿QUE FRACCION DE PELICULA VIO EN TOTAL?");
            Console.WriteLine("1. 7/9");
            Console.WriteLine("2. 2/8");
            Console.WriteLine("3. 3/8");
            Console.WriteLine("4. 3/4");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >4 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 4)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >4);
      
        Console.Clear();//limpiamos pantalla
        opcion = 0;//reseteamos la varaible


        do{ //CUARTO ENUNCIADO ENUNCIADO
            Console.Clear();
            Console.WriteLine(     "-----------------------------------------");
            Console.WriteLine(     "--------------ENUNCIADO N0.4-------------");
            Console.WriteLine(     "-----------------------------------------");
            Console.WriteLine("LUIS LLENO 1/8 LECHE Y 1/2 DE CAFE EN UN VASO");
             Console.WriteLine("     ¿CUAL ES LA CANTIDAD DE LIQUIDO EN SU VASO?");
            Console.WriteLine("1. 5/8");
            Console.WriteLine("2. 2/8");
            Console.WriteLine("3. 3/8");
            Console.WriteLine("4. 3/4");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
            }
       
            if (opcion <1 || opcion >4 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1)//SI EL VALOR ES EL CORRECTO SE SUMA 10 PUNTOS 
                {
                    puntaje+=25;
                }
                Console.Clear();
        } while (opcion <1 || opcion >4);

        return puntaje;
    }

     static string validar_puntaje(int puntaje, int seleccion)
    {
        string nota="";
        switch(puntaje)
        {
            case 100:
                nota += "FELICIDADES PUNTUACION PERFECTA";
                
            break;
            case 75:
                nota += "FELICIDADES MUY BUEN TRABAJO";
            break;
            case 50:
                nota += "NECESITAS ESTUDIAR MAS";
            break;
            case 0:
                nota += "TU NOTA FUE CERO, NO TE PREOCUPES AUN PUEDES LOGRARLO \n LE RECOMENDAMOS UN REPASO";

                switch(seleccion)
                {
                    case 1:
                        string Archivo_suma = @"suma.txt";
                        IEnumerable<string> line = File.ReadLines(Archivo_suma);
                        Console.WriteLine(String.Join(Environment.NewLine, line));
                    break;
                     case 2:
                        string Archivo_resta = @"resta.txt";
                        IEnumerable<string> line_resta = File.ReadLines(Archivo_resta);
                        Console.WriteLine(String.Join(Environment.NewLine, line_resta));
                    break;
                    case 3:
                        string Archivo_multiplicacion = @"multiplicacion.txt";
                        IEnumerable<string> line_multiplicacion = File.ReadLines(Archivo_multiplicacion);
                        Console.WriteLine(String.Join(Environment.NewLine, line_multiplicacion));

                    break;
                    case 4:
                        string Archivo_div = @"resta.txt";
                        IEnumerable<string> line_div = File.ReadLines(Archivo_div);
                        Console.WriteLine(String.Join(Environment.NewLine, line_div));
                    break;
                }
            break;
        }
      return nota;
    }
}


