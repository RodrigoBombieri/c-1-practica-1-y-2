// See https://aka.ms/new-console-template for more information

//1 -------------------------
//Hacer un programa para solicitar dos números y luego 
//calcule y emita la suma en pantalla.


// float numero1;
// float numero2;
// float resultado;

// Console.WriteLine("Ingrese un número: ");
// numero1 = float.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese otro número: ");
// numero2 = float.Parse(Console.ReadLine());

// resultado = numero1 + numero2;

// Console.WriteLine("El resultado es: " + resultado);



//2 ------------------------
//Hacer un programa para solicitar por teclado un número 
//y luego devolver su valor elevado al cubo.


// int numero1;
// int cubo;

// Console.WriteLine("Ingrese un número: ");
// numero1 = int.Parse(Console.ReadLine());

// cubo = numero1 * numero1 * numero1;

// Console.WriteLine("El número ingresado elevado al cubo es: " + cubo);

//3 -------------------------
//Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades 
//y la velocidad promedio de un vehículo. Calcular y emitir por pantalla 
//el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.


// float kilometros, velocidad, tiempo;

// Console.WriteLine("Cuántos km hay entre las ciudades?: ");
// kilometros = float.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la velocidad del vehículo: ");
// velocidad = float.Parse(Console.ReadLine());

// tiempo = kilometros/velocidad;

// //Para acortar los decimales le agregamos el ToString
// Console.WriteLine("El tiempo para llegar de una a otra es: " + tiempo.ToString("0.00") + "hs");

//4 --------------------------------
//Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
//más una comisión del 5% sobre el total facturado por cada empleado. 
//Hacer un programa para ingresar el total facturado por un empleado 
//y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.


// float total_facturado;
// float comision;
// float sueldo_total;

// const float sueldoFijo = 15000;
// const float porcentajeComision = 0.05F;

// Console.WriteLine("Ingrese el total facturado: ");
// total_facturado = float.Parse(Console.ReadLine());

// comision = total_facturado * porcentajeComision;
// sueldo_total = comision + sueldoFijo;

// Console.WriteLine("El sueldo total es: " + sueldo_total);

//5 -------------------------
//Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno
// y luego calcule y emita por pantalla el promedio final.


// float nota1;
// float nota2;
// float nota3;
// float promedio_final;

// Console.WriteLine("Ingrese la primer nota: ");
// nota1 = float.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la segunda nota: ");
// nota2 = float.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la tercer nota: ");
// nota3 = float.Parse(Console.ReadLine());

// promedio_final = (nota1 + nota2 + nota3) / 3;

// Console.WriteLine("El promedio es: " + promedio_final);



//6 ----------------------------
//Ingresar por teclado los m2 de un predio y los
//m2 cubiertos, calcular el % de m2 cubiertos y descubiertos

// float metros_totales;
// float metros_cubiertos;
// float porcentaje_mc;
// float porcentaje_md;
// float metros_descubiertos;


// Console.WriteLine("Ingrese los m2 totales del terreno: ");
// metros_totales = float.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese los m2 cubiertos: ");
// metros_cubiertos = float.Parse(Console.ReadLine());

// metros_descubiertos = metros_totales - metros_cubiertos;
// porcentaje_mc = (metros_cubiertos * 100) / metros_totales;
// porcentaje_md = (metros_descubiertos * 100) / metros_totales;

// Console.WriteLine("El porcentaje de metros cubiertos es de: " + porcentaje_mc + "%");
// Console.WriteLine("El porcentaje de metros descubiertos es de: " + porcentaje_md + "%");



//7 ---------------------------------------------
// Promoción del 15% de descuento sobre el total de la compra,
//Solicitar el monto total y calcular y emitir el precio total con descuento

// float total_compra;
// const float descuento = 0.15F;
// float monto_descontado;
// float precio_total;

// Console.WriteLine("Ingrese el monto total: ");
// total_compra = float.Parse(Console.ReadLine());

// monto_descontado = total_compra * descuento;

// precio_total = total_compra - monto_descontado;

// Console.WriteLine("El precio con 15% de descuento es: " + precio_total);




//8 -----------------------
// Queremos conocer el % de hombres y mujeres de una universidad.
//Cargar datos de cantidad de H y M y mostrar los porcentajes.

// int cant_hombres, cant_mujeres, porc_hombres, porc_mujeres, cant_total;

// Console.WriteLine("Ingrese la cantidad de Hombres: ");
// cant_hombres = int.Parse(Console.ReadLine());
// Console.WriteLine("ingrese la cantidad de Mujeres: ");
// cant_mujeres = int.Parse(Console.ReadLine());

// cant_total = cant_hombres + cant_mujeres;
// porc_hombres = (cant_hombres * 100) / cant_total;
// porc_mujeres = (cant_mujeres * 100) / cant_total;

// Console.WriteLine("Cantidad total de alumnos: " + cant_total);
// Console.WriteLine("El porcentaje de Hombres es: " + porc_hombres + "%");
// Console.WriteLine("El porcentaje de Mujeres es: " + porc_mujeres + "%");


// 9 ---------------------------- PRUEBA
// Calcula la potencia requerida por un ciclista que viaja a 30m/s
// para vencer la resistencia del aire

// float c_velocidad;
// float fuerza_dinamica;
// float potencia_requerida;

// const float resistencia_aire = 0.88F;
// const float area_frontal = 0.36F;
// const float densidad_aire = 1.20F;
// const float un_medio = 0.50F;


// Console.WriteLine("Ingrese la velocidad del ciclista: ");
// c_velocidad = float.Parse(Console.ReadLine());

// fuerza_dinamica = un_medio * resistencia_aire * area_frontal * densidad_aire * (c_velocidad * c_velocidad);

// potencia_requerida = fuerza_dinamica * c_velocidad;

// Console.WriteLine("La potencia requerida es: " + potencia_requerida + "kW");










