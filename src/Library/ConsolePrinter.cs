//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /*
    <summary>
    Se requirere una clase de impresion debido al principio SRP
    Cada clase debe poseer una unica funcionalidad de la que es responsable, y la clase Recipe ya esta encargada de la creacion
    y manejo de data del objeto Receta
    </summary>
    */
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} por {step.EquipmentCost} y {step.MaterialCost}");
            }
            Console.WriteLine($"Costo total de la receta: {recipe.GetProductionCost()}");
        }
    }
}